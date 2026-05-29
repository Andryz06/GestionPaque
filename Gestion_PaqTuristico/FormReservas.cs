using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_PaqTuristico
{
    public partial class FormReservas : Form
    {
        // Cadena de conexión local sincronizada con tu base de datos
        private string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Trusted_Connection=True;";
        // Variables globales para el control logístico de la reserva activa
        private int idPaqueteSeleccionado = -1;
        private decimal precioPaqueteSelccionado = 0;
        private int cuposDisponiblesSeleccionados = 0;

        //Variables de seguidad
        public string RolActivo = "";
        public int IdUsuarioActivo = 0;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //Tabla en memoria para permitir el filtrado del buscardor sin recargar la base de datos
        private DataTable dtCatalogo = new DataTable();



        public FormReservas()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                if (c is Panel || c.Name.Contains("card") || c.Name.Contains("panel"))
                {
                    CurvarPanel(c, 25); 
                }
            }
            // Aplicamos la curva directamente al PictureBox para que encaje perfecto
            picDestino.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, picDestino.Width, picDestino.Height, 20, 20));
        }




        //Control de seguridad inicial y coniguracion
        //===========================================

        public void ConfigurarSeguridad(string rol, int idUSuarioLogueado)
        {
            // Solo guardamos los datos para usarlos cuando la caja ya esté llena
            RolActivo = rol.Trim();
            IdUsuarioActivo = idUSuarioLogueado;
            
        }
        // FUNCIÓN MAESTRA QUE LLAMAREMOS DESDE INICIO
        public void CargarDatosDelLugar(string nombre, string descripcion, Image foto, string promos)
        {
            lblTituloDestino.Text = nombre;
            lblDescripcion.Text = descripcion;
            picDestino.Image = foto;
            picDestino.SizeMode = PictureBoxSizeMode.Zoom; // Para que se vea bonita
            lblPromociones.Text = promos;
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            // ¡LA TRAMPA DE DEBUG! (Pon esto de primera línea)
            //MessageBox.Show("Atención: El rol que me llegó es: [" + RolActivo + "]", "Prueba de Rayos X");
            // 1. PRIMERO llenamos el ComboBox con todos los clientes para que ya existan
            CargarClientes();
            // Llenamos la tabla de viajes
            CargarCatalogoPaquetes();

            //Si la tabla cargo registro con exito, selecciona el primero por defecto

            if (dgvCatalogo.CurrentRow != null)
            {
                InterfazDestino();
            }
            // 2. DESPUÉS aplicamos la seguridad para seleccionar al usuario que entró
            if (RolActivo == "Cliente")
            {
                cmbClientes.Enabled = false;
                cmbClientes.Visible = false; // Lo ocultamos para que se vea limpio
                lblTituloCliente.Visible = false;

            }
            else
            {
                // Si es Admin o Empleado, se queda encendido para que puedan trabajar
                cmbClientes.Enabled = true;
                cmbClientes.Visible = true;
            }
        }
        
        private void CargarClientes()
        {
            //Jalamos el email junto al nombre para poder despachar la boleta
            string query = "Select IdCliente, NombreCompleto, Email FROM Clientes";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                {
                    DataTable dtClientes = new DataTable();
                    adaptador.Fill(dtClientes);

                    cmbClientes.DataSource = dtClientes;
                    cmbClientes.DisplayMember = "NombreCompleto";
                    cmbClientes.ValueMember = "IdCliente";
                }
            }
        }

        private void CargarCatalogoPaquetes()
        {
            string query = "SELECT IdPaquete, Imagen, NombrePaquete AS [PAQUETE], Destino AS [DESTINO], " +
                           "DuracionDias AS [SALIDA], CuposDisponibles AS [CUPOS], Precio, Descripcion FROM Paquetes";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                {
                    dtCatalogo.Clear();
                    adaptador.Fill(dtCatalogo);

                    dgvCatalogo.DataSource = dtCatalogo;

                    //Se ocultan las columbas tecnicas

                    if (dgvCatalogo.Columns.Contains("IdPaquete")) dgvCatalogo.Columns["IdPaquete"].Visible = false;
                    if (dgvCatalogo.Columns.Contains("Precio")) dgvCatalogo.Columns["Precio"].Visible = false;
                    if (dgvCatalogo.Columns.Contains("Descripcion")) dgvCatalogo.Columns["Descripcion"].Visible = false;

                    //AJuste de imagen en miniatura en modo zoom auto
                    if (dgvCatalogo.Columns.Contains("Imagen"))
                    {
                        DataGridViewImageColumn colImg = (DataGridViewImageColumn)dgvCatalogo.Columns["Imagen"];
                        colImg.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        colImg.Width = 70; // Ancho perfecto para que parezca un icono de catálogo
                    }
                }
            }
        }

       
        private void materialCard1_Paint(object sender, PaintEventArgs e)
        { }





        //Buscador en tiempo real con filtro dinamico
        //============================================
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (dtCatalogo.Rows.Count > 0)
            {
                //Filtra de inmediato por el destino o el nombre del paquete segun lo que escriba el usuario 
                dtCatalogo.DefaultView.RowFilter = string.Format("DESTINO LIKE '%{0}%' OR PAQUETE LIKE '%{0}%'", txtBuscar.Text.Replace("'", "''"));

            }
        }

        //Evento de la tabla y sincronizacion de sub panel derecho
        //===========================================================




        //Recuerda: vincula este método al evento 
        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            InterfazDestino();
        }









        private void InterfazDestino()
        {
            if (dgvCatalogo.CurrentRow != null && dgvCatalogo.CurrentRow.Index >= 0)
            {
                DataGridViewRow fila = dgvCatalogo.CurrentRow;

                //Se extraen los valores de la tabla seleccionada 

                idPaqueteSeleccionado = Convert.ToInt32(fila.Cells["IdPaquete"].Value);
                precioPaqueteSelccionado = Convert.ToDecimal(fila.Cells["Precio"].Value);
                cuposDisponiblesSeleccionados = Convert.ToInt32(fila.Cells["CUPOS"].Value);

                //. Sincronizamos los textos del sub-panel de detalles (Derecha)
                lblTitulo.Text = fila.Cells["PAQUETE"].Value.ToString() + " - " + fila.Cells["DESTINO"].Value.ToString();
                lblDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                lblPrecioPersona.Text = "Precio por Persona: $" + precioPaqueteSelccionado.ToString("0.00");

                if (fila.Cells["Imagen"].Value != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])fila.Cells["Imagen"].Value;
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        picDestino.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picDestino.Image = null; //limpio su no tiene foto
                }

                //Blindaje de seguridad contrla el limite del NumericUpDOw segun los cupos reales de la base de datos
                if (cuposDisponiblesSeleccionados > 0)
                {
                    numPersonas.Minimum = 1;
                    numPersonas.Maximum = cuposDisponiblesSeleccionados;
                    numPersonas.Enabled = true;
                }
                else
                {
                    numPersonas.Minimum = 0;
                    numPersonas.Maximum = 0;
                    numPersonas.Value = 0;
                    numPersonas.Enabled = false;
                    MessageBox.Show("¡Alerta! Este paquete  no cuenta con cupos disponibles en este momento.", "Destino Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CalcularTotal();
            }

        }








        private void numPersonas_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }




        private void CalcularTotal()
        {
            decimal total = numPersonas.Value * precioPaqueteSelccionado;
            lblTotal.Text = "Total a Pagar: $" + total.ToString("0.00");
        }













        //Conexion con el form inicio 
        //===========================

        public void SeleccionarPaquetesDesdeInicio(int idPaquete)
        {
            // Busca el ID de la tarjeta cliqueada adentro de las filas de la tabla
            // Usamos un bucle for tradicional que es 100% a prueba de balas en WinForms
            for (int i = 0; i < dgvCatalogo.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvCatalogo.Rows[i];

                // ESCUDO: Saltamos la fila vacía de abajo o celdas nulas
                if (fila.IsNewRow || fila.Cells["IdPaquete"].Value == null || fila.Cells["IdPaquete"].Value == DBNull.Value)
                {
                    continue;
                }

                // Hacemos la comparación
                if (Convert.ToInt32(fila.Cells["IdPaquete"].Value) == idPaquete)
                {
                    fila.Selected = true;
                    dgvCatalogo.CurrentCell = fila.Cells[2];
                    InterfazDestino();
                    break;
                }
            }

        }







        //Registro de transaccion y envio de recibo
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Validacion basica de paquete seleccionado
            if (idPaqueteSeleccionado == -1 || numPersonas.Value <= 0)
            {
                MessageBox.Show("Seleccione un destino turístico del catálogo antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = -1;
            string nombreCliente = "";
            string correoCliente = "";

            decimal totalFinal = numPersonas.Value * precioPaqueteSelccionado;

            //Escudo de seguridad para la obtencion el cliente
            //====================

            if (RolActivo == "Cliente")
            {
                // BYPASS: Si es cliente, ignoramos el ComboBox visual e irnos directo a SQL usando el ID de la sesión activa
                string queryFiel = "SELECT IdCliente, NombreCompleto, Email FROM Clientes WHERE IdUsuario = @IdUser";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(queryFiel, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUser", IdUsuarioActivo);
                        try
                        {
                            conn.Open();
                            using (SqlDataReader rd = cmd.ExecuteReader())
                            {
                                if (rd.Read())
                                {
                                    idCliente = Convert.ToInt32(rd["IdCliente"]);
                                    nombreCliente = rd["NombreCompleto"].ToString();
                                    correoCliente = rd["Email"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error crítico al recuperar los datos de sesión del cliente: " + ex.Message, "Error de Mapeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                // MODO ADMIN / EMPLEADO: Conserva tu lógica original porque ellos sí usan el ComboBox visible
                if (cmbClientes.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione el cliente que procesará la compra.", "Falta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                DataRowView filaCliente = (DataRowView)cmbClientes.SelectedItem;
                nombreCliente = filaCliente["NombreCompleto"].ToString();
                correoCliente = filaCliente["Email"].ToString();
            }

            // Aseguramos que los datos se extrajeron correctamente antes de proceder a la compra
            if (idCliente == -1 || string.IsNullOrEmpty(correoCliente))
            {
                MessageBox.Show("No se pudieron verificar las credenciales del perfil activo para procesar el pago.", "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombrePaquete = dgvCatalogo.CurrentRow.Cells["PAQUETE"].Value.ToString();
            string destinoPaquete = dgvCatalogo.CurrentRow.Cells["DESTINO"].Value.ToString();

            // Consultas relacionales cruzadas
            string queryInsertReserva = "INSERT INTO Reservas (IdCliente, IdPaquete, CantidadPersonas, TotalPagar, Estado) " +
                                        "VALUES (@IdCliente, @IdPaquete, @Personas, @Total, 'Confirmado');";

            string queryUpdateCupos = "UPDATE Paquetes SET CuposDisponibles = CuposDisponibles - @Personas WHERE IdPaquete = @IdPaquete;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // 1. Guardamos la Reservación
                    using (SqlCommand cmdReserva = new SqlCommand(queryInsertReserva, conexion, transaccion))
                    {
                        cmdReserva.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmdReserva.Parameters.AddWithValue("@IdPaquete", idPaqueteSeleccionado);
                        cmdReserva.Parameters.AddWithValue("@Personas", numPersonas.Value);
                        cmdReserva.Parameters.AddWithValue("@Total", totalFinal);
                        cmdReserva.ExecuteNonQuery();
                    }

                    // 2. Restamos los cupos vendidos del paquete global
                    using (SqlCommand cmdCupos = new SqlCommand(queryUpdateCupos, conexion, transaccion))
                    {
                        cmdCupos.Parameters.AddWithValue("@Personas", numPersonas.Value);
                        cmdCupos.Parameters.AddWithValue("@IdPaquete", idPaqueteSeleccionado);
                        cmdCupos.ExecuteNonQuery();
                    }

                    // Consolidamos la base de datos
                    transaccion.Commit();

                    MessageBox.Show("¡Venta autorizada y registrada con éxito en TourHyruleDB! ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. DISPARAR ENVÍO DE CORREO AUTOMÁTICO con los datos 100% reales obtenidos
                    DespacharBoletaElectronica(nombreCliente, correoCliente, nombrePaquete, destinoPaquete, numPersonas.Value, totalFinal);

                    // Refrescamos la tabla para actualizar el número de cupos que se ve en pantalla
                    CargarCatalogoPaquetes();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error crítico en el proceso de reserva relacional: " + ex.Message, "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        





        private void DespacharBoletaElectronica(string cliente, string correo, string paquete, string destino, decimal boletos, decimal total)
        {
            // Validación preventiva de cuentas de correo
            if (string.IsNullOrEmpty(correo) || !correo.Contains("@"))
            {
                MessageBox.Show("La reservación está a salvo, pero el cliente no posee un correo electrónico válido. Se omitió el despacho de la boleta.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //Configuracionn de crendeciales seguras 
                string correoCorporativo = "tourhyrule@gmail.com";
                string tokenSeguridadGoogle = "fepy fzsv gidd ggzj"; // Clave de 16 letras de Google Apps

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correoCorporativo, "Tour Hyrule Global 🗺");
                mail.To.Add(new MailAddress(correo));
                mail.Subject = "Tu orden de viaje ha sido Confirmada - Boleta Electrónica ✈️";

                // Formato HTML  para el cuerpo del mensaje
                mail.Body = $@"
                    <div style='font-family: Arial, sans-serif; border: 1px solid #e0e0e0; padding: 25px; max-width: 550px; border-radius: 10px; margin: 0 auto;'>
                        <h2 style='color: #1a4373; text-align: center; margin-top: 0;'>COMPROBANTE DE RESERVA DIGITAL</h2>
                        <p>Hola <strong>{cliente}</strong>,</p>
                        <p>¡Gracias por tu compra! Tu solicitud de vuelo  ha sido procesada de manera exitosa. Detalles de la Reserva:</p>
                        <div style='background-color: #f9f9f9; padding: 15px; border-radius: 5px; margin: 20px 0;'>
                            <table style='width: 100%; font-size: 14px;'>
                                  <tr><td style='padding: 5px 0; color: #666;'><strong>Tour Reservado:</strong></td><td>{paquete}</td></tr>
                                  <tr><td style='padding: 5px 0; color: #666;'><strong>Destino Oficial:</strong></td><td>{destino}</td></tr>
                                  <tr><td style='padding: 5px 0; color: #666;'><strong>Pasajeros:</strong></td><td>{boletos} boleto(s) asignado(s)</td></tr>
                                  <tr><td style='padding: 5px 0; color: #666;'><strong>Estado de Transacción:</strong></td><td style='color: #2e7d32; font-weight: bold;'>Aprobado / Pago Recibido</td></tr>
                            </table>
                        </div>
                        <h3 style='text-align: right; color: #1a4373; margin-bottom: 25px;'>Total Liquidado: ${total.ToString("0.00")}</h3>
                        <hr style='border: 0; border-top: 1px solid #eeeeee;' />
                        <p style='font-size: 11px; color: #999; text-align: center; line-height: 1.4;'>
                            Este es un comprobante de compra automatizado. Por favor no respondas directamente a esta dirección de correo.<br/>
                            <strong>Tour Hyrule Automation System v2.5</strong><br/>Estudiante de Ingeniería en Sistemas y Computación
                        </p>
                    </div>";

                mail.IsBodyHtml = true;

                // Enlace SMTP con el servidor de Gmail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(correoCorporativo, tokenSeguridadGoogle);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show($"¡Boleta de reserva despachada con éxito al correo:\n{correo}! ", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La venta se guardó de forma exitosa, pero la boleta electrónica falló al enviarse por red.\nDetalle: " + ex.Message, "Aviso de Red", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void CurvarPanel(Control c, int curvatura)
        {
            c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, curvatura, curvatura));
        }
    }
}
