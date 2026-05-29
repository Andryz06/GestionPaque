using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
namespace Gestion_PaqTuristico

{
    public partial class FormLogin : Form
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
        public FormLogin()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlLogin.Region = System.Drawing.Region.FromHrgn
                (CreateRoundRectRgn(0, 0, ctrlLogin.Width, ctrlLogin.Height, 30, 30));
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña para continuar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //COnsula para filtro de usuario 
            string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT * FROM Usuarios Where Correo = @user AND password = @pass";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@user", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@pass", txtPassword.Text);

                    //Aqui se lee la respuesta
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            if (chkRecordarme.Checked == true) //Aqui va la funcion del check para recordar al usuari
                            {
                                Properties.Settings.Default.CorreoGuardado = txtUsuario.Text;
                                Properties.Settings.Default.RecordarCheck = true;
                            }
                            else
                            {
                                Properties.Settings.Default.CorreoGuardado = "";
                                Properties.Settings.Default.RecordarCheck = false;
                            }
                            Properties.Settings.Default.Save();

                            //Roles se obtine el rol y el id de la base de datos
                            string rolUSuario = lector["Rol"].ToString();
                            int idUsuario = Convert.ToInt32(lector["IdUsuario"]);

                            //Abrimos el mismo menu para todos pero le pasamos los datos

                            FormMenuAdmin menuPrincipal = new FormMenuAdmin(rolUSuario, idUsuario);
                            menuPrincipal.Show();


                            // 3. Saludo según la jerarquía (sin volver a abrir ventanas)
                            if (rolUSuario == "Admin")
                            {
                                MessageBox.Show("¡Bienvenido de vuelta, Administrador! Sistemas listos.", "Acceso Root");
                            }
                            else if (rolUSuario == "Empleado")
                            {
                                MessageBox.Show("¡Bienvenido! Que tengas un excelente turno de trabajo.", "Acceso de Empleado");
                            }
                            else if (rolUSuario == "Cliente")
                            {
                                MessageBox.Show("¡Bienvenido a Tour Hyrule! Prepara tu próxima aventura.", "Acceso de Cliente");
                            }

                            this.Hide(); // ocultar el formulario de login actual sin cerrarlo
                        }
                        else
                        {
                            MessageBox.Show("Correo o Contraseña incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ctrlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        //Aqui es para abrir la ventana de recuperacion de contraseña
        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperar ventanaRecuperacion = new FormRecuperar();

            ventanaRecuperacion.Show();

            this.Hide(); // para ocltar la pantalla de login
        }

        private void nightLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormElegirPerfil Elegir = new FormElegirPerfil();
            Elegir.Show();
            this.Hide();
        }
    }
}
