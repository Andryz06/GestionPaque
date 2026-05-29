using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_PaqTuristico
{
    public partial class FormConfiguracion : Form
    {
        // VARIABLES GLOBALES Y DE SESIÓN
        // =======================================================
        private string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Trusted_Connection=True;";
        private int idUsuarioLogueado;
        private string rolUsuarioLogueado;

        // LIBRERÍA PARA CURVAR PANELES
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void CurvarPanel(Control c, int curvatura)
        {
            c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, curvatura, curvatura));
        }

        //L CONSTRUCTOR AHORA RECIBE QUIEN INICO SESIN

        public FormConfiguracion(int idUsuario, string rol)
        {
            InitializeComponent();
            this.idUsuarioLogueado = idUsuario;
            this.rolUsuarioLogueado = rol;
        }
        private void lblInf_Click(object sender, EventArgs e)
        { }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            //Curvamos lod paneles
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    CurvarPanel(c, 20);
                }
            }

            //Cargamos los datos del usuario en la tajeta de perfil
            CargarDatosPerfil();

            if (rolUsuarioLogueado.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                rolUsuarioLogueado.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                btnEliminarCuenta.Enabled = false;
                btnEliminarCuenta.BackColor = Color.LightGray;
                btnEliminarCuenta.Text = "ACCESO DENEGADO (ADMIN)";
            }
        }
        //CARGAR PERFIL SECC 1
        //===========================
        private void CargarDatosPerfil()
        {
            string query = "SELECT Nombres, Correo, Rol FROM Usuarios WHERE IdUsuario = @Id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Id", idUsuarioLogueado);
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNombre.Text = reader["Nombres"].ToString();
                            lblCorreo.Text = reader["Correo"].ToString();
                            lblRol.Text = "[ " + reader["Rol"].ToString().ToUpper() + " ]";
                        }
                    }
                }
            }
        }
        //CAMBIAR CONTRASEÑA

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraActual.Text) ||
                string.IsNullOrWhiteSpace(txtContraNueva.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContra.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraNueva.Text != txtConfirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // Verificar contraseña actual
                string queryVerificar = "SELECT COUNT(1) FROM Usuarios WHERE IdUsuario = @Id AND Password = @Contra";
                using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion))
                {
                    cmdVerificar.Parameters.AddWithValue("@Id", idUsuarioLogueado);
                    cmdVerificar.Parameters.AddWithValue("@Contra", txtContraActual.Text);

                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    if (existe == 0)
                    {
                        MessageBox.Show("La contraseña actual es incorrecta.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Actualizar contraseña
                string queryActualizar = "UPDATE Usuarios SET Password = @NuevaContra WHERE IdUsuario = @Id";
                using (SqlCommand cmdActualizar = new SqlCommand(queryActualizar, conexion))
                {
                    cmdActualizar.Parameters.AddWithValue("@NuevaContra", txtContraNueva.Text);
                    cmdActualizar.Parameters.AddWithValue("@Id", idUsuarioLogueado);
                    cmdActualizar.ExecuteNonQuery();

                    MessageBox.Show("¡Contraseña actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContraActual.Clear();
                    txtContraNueva.Clear();
                    txtConfirmarContra.Clear();
                }
            }
        }
        //ELIMINAR CUENTA
        //===========================
        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            // Doble validación por si lograron habilitar el botón de alguna forma
            if (rolUsuarioLogueado.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                rolUsuarioLogueado.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Las cuentas de Administrador no pueden eliminarse.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar tu cuenta permanentemente?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Perderás el acceso a Tour Hyrule. ¿Proceder?", "Confirmación Final", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        SqlTransaction transaccion = conexion.BeginTransaction();
                        try
                        {
                            // Borramos en cascada (primero dependencias, luego el usuario)
                            string queryDelCliente = "DELETE FROM Clientes WHERE IdUsuario = @IdUser";
                            using (SqlCommand cmdDelCliente = new SqlCommand(queryDelCliente, conexion, transaccion))
                            {
                                cmdDelCliente.Parameters.AddWithValue("@IdUser", idUsuarioLogueado);
                                cmdDelCliente.ExecuteNonQuery();
                            }

                            string queryDelUsuario = "DELETE FROM Usuarios WHERE IdUsuario = @IdUser";
                            using (SqlCommand cmdDelUsuario = new SqlCommand(queryDelUsuario, conexion, transaccion))
                            {
                                cmdDelUsuario.Parameters.AddWithValue("@IdUser", idUsuarioLogueado);
                                cmdDelUsuario.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            MessageBox.Show("Tu cuenta ha sido eliminada. El sistema se reiniciará.", "Despedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            MessageBox.Show("Error al eliminar la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
