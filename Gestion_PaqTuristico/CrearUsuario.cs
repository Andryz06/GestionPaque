using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Gestion_PaqTuristico
{
    public partial class FormCrearUsuario : Form
    {
        //Se declara el rol
        public string rolSeleccionado = "";
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
           
        }



        private void btnCrearCuen_Click(object sender, EventArgs e)
        {
            //Validacion para revisar que las contraseñas coincidan
            if (txtContra.Text != txtConfirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, Revisa e intenta de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            

            string conexionString = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Integrated Security=True;";

            // 1. Modificamos el INSERT de Usuarios para atrapar el ID que genere la base de datos
            string queryUsuario = "INSERT INTO Usuarios (Nombres, Apellidos, Telefono, Correo, Rol, Password) OUTPUT INSERTED.IdUsuario VALUES (@nombres, @apellidos, @telefono, @correo, @rol, @password)";
            
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                {
                    try
                    {
                        conexion.Open();

                        //Usamos una Transaccion si fall lacreacion del cliente no se creara el usuario a medias
                        using (SqlTransaction transaccion = conexion.BeginTransaction())
                        {
                            int nuevoIdUsuario = 0;

                            //Paso a  registrar en la tabla usario 
                            using (SqlCommand comando = new SqlCommand(queryUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@nombres", txtNombres.Text);
                                comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                                comando.Parameters.AddWithValue("@rol", rolSeleccionado);
                                comando.Parameters.AddWithValue("@password", txtContra.Text);

                                // ExecuteScalar ejecuta el comando y nos devuelve el IdUsuario recién generado
                                nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                            }
                            //segundo paso si es cliente crear peril automatico en la tabla cliente
                            if (rolSeleccionado == "Cliente")
                            {
                                string queryCliente = "INSERT INTO Clientes (IdUsuario, NombreCompleto, Telefono, Email, Nacionalidad) VALUES (@idUsuario, @nombreCompleto, @telefono, @email, 'Por Definir')";

                                using (SqlCommand comandoCliente = new SqlCommand(queryCliente, conexion, transaccion))
                                {
                                    // Combinamos nombre y apellido para el perfil
                                    string nombreCompleto = txtNombres.Text + " " + txtApellidos.Text;

                                    comandoCliente.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario); // El ID que capturamos arriba
                                    comandoCliente.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                                    comandoCliente.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                                    comandoCliente.Parameters.AddWithValue("@email", txtCorreo.Text);

                                    comandoCliente.ExecuteNonQuery();
                                }
                            }

                            //si ambos insert se ejuctaron sin prblema confirmar cambios
                            transaccion.Commit();

                            MessageBox.Show("Cuenta Creada con éxito, Ya puedes iniciar sesión", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Se regresa al login
                            FormLogin login = new FormLogin();
                            login.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Si algo truena, revertimos todo para evitar datos basura corruptos
                        MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void lbllinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms["FormLogin"].Show();
            this.Close();
        }
    }
}
