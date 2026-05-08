using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Gestion_PaqTuristico
{
    public partial class FormRecuperar : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public FormRecuperar()
        {
            InitializeComponent();

            //Aqui evitamos el secuestro de los paneles 
            panel2_Codigo.Parent = this;
            panel3_NuevaContra.Parent = this;


            //Aqui se obliga a estar en la misma ubicacion 
            panel2_Codigo.Location = ctrlOlvidoPass.Location;
            panel3_NuevaContra.Location = ctrlOlvidoPass.Location;

            

            ctrlOlvidoPass.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ctrlOlvidoPass.Width, ctrlOlvidoPass.Height, 30, 30));
            // Curvas del Panel 
            panel2_Codigo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2_Codigo.Width, panel2_Codigo.Height, 30, 30));

            // Curvas del Panel 
            panel3_NuevaContra.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3_NuevaContra.Width, panel3_NuevaContra.Height, 30, 30));

            ctrlOlvidoPass.Visible = true;
            panel2_Codigo.Visible = false;
            panel3_NuevaContra.Visible = false;
        }
        int codigoGenerado = 0;
        string correoUsuario = "";
        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreoOlv.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo electrónico primero.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Random rnd = new Random();
                codigoGenerado = rnd.Next(100000, 999999);
                correoUsuario = txtCorreoOlv.Text;

                System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
                mensaje.From = new System.Net.Mail.MailAddress("tourhyrule@gmai.com");
                mensaje.To.Add(correoUsuario);
                mensaje.Subject = "Código de Seguridad - Tour Hyrule";
                mensaje.Body = "Tu código de recuperación es:" + codigoGenerado;

                System.Net.Mail.SmtpClient servidor = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                servidor.Port = 587;
                servidor.Credentials = new System.Net.NetworkCredential("tourhyrule@gmail.com", "fepy fzsv gidd ggzj");
                servidor.EnableSsl = true;
                servidor.Send(mensaje);

                MessageBox.Show("Codigo enviado a tu corro.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ctrlOlvidoPass.Visible = false;
                panel2_Codigo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == codigoGenerado.ToString())
            {
                MessageBox.Show("Codigo correcto.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel2_Codigo.Visible = false;
                panel3_NuevaContra.Visible = true;
            }
            else
            {
                MessageBox.Show("Código incorrecto, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarContra_Click(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text == txtConfirmarContra.Text)
            {
                string conexionString = @"Server=(localdb)\Jeremy;Database=TourHyruleDB;Integrated Security=True;";
                string query = "UPDATE Usuarios SET Password = @nuevaContra WHERE Correo = @correoUsuario";

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nuevaContra", txtNuevaContra.Text);
                        comando.Parameters.AddWithValue("correoUsuario", correoUsuario);

                        try
                        {
                            conexion.Open();
                            int filasAfectadas = comando.ExecuteNonQuery(); //Aqui procesa sql

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Contrasña actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Application.OpenForms["FormLogin"].Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se encontro el correo", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Las constraseñas no coinciden. Intenta de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void lblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms["FormLogin"].Show();
            this.Close();
        }

        private void FormRecuperar_Load(object sender, EventArgs e)
        {
            ctrlOlvidoPass.BringToFront();
        }
    }
}
