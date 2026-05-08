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

            // El comando INSERT Verificar que los nombres de las columnas coincidan con la tabla en SQL
            string query = "INSERT INTO Usuarios (Nombres, Apellidos, Telefono, Correo, Rol, Password) VALUES (@nombres, @apellidos, @telefono, @correo, @rol, @password)";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombres", txtNombres.Text);
                    comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    comando.Parameters.AddWithValue("@rol", rolSeleccionado);
                    comando.Parameters.AddWithValue("@password", txtContra.Text);

                    try
                    {
                        conexion.Open();
                        int filasGuardadas = comando.ExecuteNonQuery();

                        if (filasGuardadas > 0)
                        {
                            MessageBox.Show("Cuenta Creada con éxito, Ya puedes iniciar sesión", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Se rregresa al login
                            FormLogin Login = new FormLogin();
                            Login.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
