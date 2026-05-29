using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;
using System.IO.Pipelines;

namespace Gestion_PaqTuristico
{
    public partial class FormInformes : Form
    {
        // VARIABLES GLOBALES
        // =======================================================
        private string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Trusted_Connection=True;";

        // =======================================================
        // LIBRERÍA PARA CURVAR PANELES
        // =======================================================
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void CurvarPanel(Control c, int curvatura)
        {
            c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, curvatura, curvatura));
        }
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    CurvarPanel(c, 20);
                }
            }
            // 2. Disparamos la carga de datos
            CargarTarjetasResumen();
            CargarRankingBarras();
            CargarTablaTopClientes();
        }

        // MOTOR 1: TARJETAS DE RESUMEN EJECUTIVO
        // =======================================================
        private void CargarTarjetasResumen()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // A. Total Clientes
                string queryClientes = "SELECT COUNT(IdCliente) FROM Clientes";
                using (SqlCommand cmd = new SqlCommand(queryClientes, conexion))
                {
                    lblTotalClientes.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }

                // B. Total Reservas Activas
                string queryReservas = "SELECT COUNT(IdReserva) FROM Reservas WHERE Estado != 'Cancelado'";
                using (SqlCommand cmd = new SqlCommand(queryReservas, conexion))
                {
                    lblTotalReservas.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }

                // C. Destino Estrella
                string queryTopDestino = @"
                    SELECT TOP 1 p.Destino 
                    FROM Reservas r 
                    INNER JOIN Paquetes p ON r.IdPaquete = p.IdPaquete 
                    WHERE r.Estado != 'Cancelado' 
                    GROUP BY p.Destino 
                    ORDER BY SUM(r.CantidadPersonas) DESC";

                using (SqlCommand cmd = new SqlCommand(queryTopDestino, conexion))
                {
                    object resultado = cmd.ExecuteScalar();
                    lblDestinoEstrella.Text = resultado != null ? resultado.ToString().ToUpper() : "SIN DATOS";
                }
            }
        }

        private void CargarRankingBarras()
        {
            /// Ocultamos por si no hay datos suficientes
            lblTop1.Visible = pbTop1.Visible = lblVentas1.Visible = false;
            lblTop2.Visible = pbTop2.Visible = lblVentas2.Visible = false;
            lblTop3.Visible = pbTop3.Visible = lblVentas3.Visible = false;

            string queryTop3 = @"SELECT TOP 3 p.Destino, SUM(r.CantidadPersonas) as TotalPasajeros 
                FROM Reservas r 
                INNER JOIN Paquetes p ON r.IdPaquete = p.IdPaquete 
                WHERE r.Estado != 'Cancelado' 
                GROUP BY p.Destino
                ORDER BY TotalPasajeros DESC";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(queryTop3, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int rank = 1;
                        int maxVentas = 0;

                        while (reader.Read())
                        {
                            string destino = reader["Destino"].ToString();
                            int total = Convert.ToInt32(reader["TotalPasajeros"]);

                            if (rank == 1) maxVentas = total; //El 100 de las barras

                            if (rank == 1)
                            {
                                lblTop1.Text = "1. " + destino;
                                lblVentas1.Text = total.ToString() + " pax";
                                pbTop1.Maximum = maxVentas;
                                pbTop1.Value = total;
                                lblTop1.Visible = pbTop1.Visible = lblVentas1.Visible = true;
                            }
                            else if (rank == 2)
                            {
                                lblTop2.Text = "2. " + destino;
                                lblVentas2.Text = total.ToString() + " pax";
                                pbTop2.Maximum = maxVentas;
                                pbTop2.Value = total;
                                lblTop2.Visible = pbTop2.Visible = lblVentas2.Visible = true;
                            }
                            else if (rank == 3)
                            {
                                lblTop3.Text = "3. " + destino;
                                lblVentas3.Text = total.ToString() + " pax";
                                pbTop3.Maximum = maxVentas;
                                pbTop3.Value = total;
                                lblTop3.Visible = pbTop3.Visible = lblVentas3.Visible = true;
                            }
                            rank++;

                        }
                    }
                }
            }
        }

        // MOTOR 3: TABLA DE DATOS
        // =======================================================
        private void CargarTablaTopClientes()
        {
            string queryTabla = @"
                SELECT 
                    c.NombreCompleto AS [CLIENTE], 
                    p.Destino AS [DESTINO], 
                    r.CantidadPersonas AS [PASAJEROS]
                FROM Reservas r
                INNER JOIN Clientes c ON r.IdCliente = c.IdCliente
                INNER JOIN Paquetes p ON r.IdPaquete = p.IdPaquete
                WHERE r.Estado != 'Cancelado'
                ORDER BY r.CantidadPersonas DESC";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(queryTabla, conexion))
                {
                    DataTable dtTop = new DataTable();
                    adaptador.Fill(dtTop);
                    dgvTopClientes.DataSource = dtTop;
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvTopClientes.Rows.Count == 0 || (dgvTopClientes.Rows.Count == 1 && dgvTopClientes.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay datos en la tabla para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo CSV (*.csv)|*.csv";
            guardar.Title = "Guardar Reporte de Ventas";
            guardar.FileName = "Reporte_ourHyrule_" + DateTime.Now.ToString("ddMMyyyy") + ".csv";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter archivo = new StreamWriter(guardar.FileName, false, System.Text.Encoding.UTF8))
                    {
                        string encabezados = "";
                        for (int i = 0; i < dgvTopClientes.Columns.Count; i++)
                        {
                            encabezados += dgvTopClientes.Columns[i].HeaderText;
                            if (i < dgvTopClientes.Columns.Count - 1) encabezados += ",";
                        }
                        archivo.WriteLine(encabezados);

                        
                            foreach (DataGridViewRow fila in dgvTopClientes.Rows) 
                            {
                                if (!fila.IsNewRow)
                                {
                                    string linea = "";
                                    for (int i = 0; i < dgvTopClientes.Columns.Count; i++)
                                    {
                                        // CORREGIDO: Cells con 'C' mayúscula
                                        string valorCelda = fila.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                                        linea += valorCelda;
                                        if (i < dgvTopClientes.Columns.Count - 1) linea += ",";
                                    }
                                    archivo.WriteLine(linea);
                                }
                        }
                    }
                    MessageBox.Show("¡Reporte exportado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
