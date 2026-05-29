using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace Gestion_PaqTuristico
{
    public partial class FormInicio : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public FormInicio()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                if (c is Panel) // Si es un panel...
                {
                    // Le damos una curva de 15, 15
                    c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, 15, 15));
                }
            }
        }

        private string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Trusted_Connection=True;";
        private void FormInicio_Load(object sender, EventArgs e)
        {
            CargarPaquetesRecientes();
        }

        private void Aventuras_Click(object sender, EventArgs e)
        {
            Control presionado = sender as Control;
            if (!(presionado is Panel)) presionado = presionado.Parent;

            //Se revisa el tag oculto si esta vacio no hace nada

            if (presionado.Tag == null)
                return;

            int idPaqueteReal = Convert.ToInt32(presionado.Tag);

            string lugar = "";
            string descripcion = "";
            Image fotoActual = null;
            string promociones = "Reserva este paquete ahora";

            string query = "SELECT NombrePaquete, Destino, Descripcion, Imagen FROM Paquetes WHERE IdPaquete = @Id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Id", idPaqueteReal);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    lugar = reader["NombrePaquete"].ToString() + " - " + reader["Destino"].ToString();
                    descripcion = reader["Descripcion"].ToString();
                    byte[] imgBytes = reader["Imagen"] as byte[];

                    if ((imgBytes !=null))
                    { 
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            fotoActual = Image.FromStream(ms);
                        }
                    }
                }
            }
            // INSTANCIAR LA NUEVA VENTANA Y PASARLE DATOS REALES
            FormReservas frmR = new FormReservas();
            frmR.CargarDatosDelLugar(lugar, descripcion, fotoActual, promociones);

            // Código para abrirlo en el menú principal
            FormMenuAdmin menuPrincipal = Application.OpenForms.OfType<FormMenuAdmin>().FirstOrDefault();
            if (menuPrincipal != null)
            {
                // =========================================================
                // EL PUENTE  DE SEGURIDAD! 
                // agarramos el Rol y el ID del Menú Principal y los inyectamos
                // =========================================================
                frmR.ConfigurarSeguridad(menuPrincipal.RolActivo, menuPrincipal.IdUsuarioActivo);

                // Obligamos a la tabla a seleccionar este viaje específico
                frmR.SeleccionarPaquetesDesdeInicio(idPaqueteReal);

                // Y finalmente abrimos la ventana blindada en el panel
                menuPrincipal.AbrirFormEnPanel(frmR);
            }
        }
        private void Tarjeta_MouseEnter(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (!(c is Panel)) c = c.Parent;

            c.BackColor = Color.LightSkyBlue; // Color azul clarito al poner el mouse
        }

        private void Tarjeta_MouseLeave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (!(c is Panel)) c = c.Parent;

            c.BackColor = Color.White; // Regresa al color original al quitar el mouse
        }
        //=======================================================================
        private void CargarPaquetesRecientes()
        {
            // 1. Ponemos tus 4 paneles actuales en una lista (Asegúrate de que los nombres coincidan con tu diseño)
            Panel[] paneles = { panelfuji, panelAngkor, panelLisboa, panelGuanajuato };
            int indice = 0;

            // 2. Traemos los 4 paquetes más nuevos de la BD
            string query = "SELECT TOP 4 IdPaquete, NombrePaquete, Destino, Descripcion, Imagen FROM Paquetes ORDER BY IdPaquete DESC";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read() && indice < paneles.Length)
                    {
                        Panel pActual = paneles[indice];

                        // TRUCO PRO: Guardamos el ID de la base de datos escondido en la propiedad Tag del panel
                        pActual.Tag = reader["IdPaquete"].ToString();

                        string titulo = reader["NombrePaquete"].ToString();
                        string desc = reader["Descripcion"].ToString();
                        byte[] imgBytes = reader["Imagen"] as byte[];

                        // Buscamos la foto y el texto adentro de tu panel y los sobreescribimos
                        foreach (Control c in pActual.Controls)
                        {
                            if (c is PictureBox pic && imgBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    pic.Image = Image.FromStream(ms);
                                }
                            }
                            else if (c is Label lbl)
                            {
                                // Le ponemos el nombre y la descripción real de la base de datos
                                lbl.Text = titulo + "\n" + desc;
                            }
                        }

                        pActual.Visible = true; // Lo mostramos
                        indice++;
                    }

                    // Si tienes menos de 4 paquetes creados en tu sistema, ocultamos los cuadros vacíos que sobren
                    for (int i = indice; i < paneles.Length; i++)
                    {
                        paneles[i].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el inicio: " + ex.Message);
                }
            }
        }
    }
}
