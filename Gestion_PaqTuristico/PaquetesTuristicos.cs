using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Gestion_PaqTuristico
{
    public partial class PaquetesTuristicos : Form
    {
        private string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Trusted_Connection=True;";
        private byte[] imagenBytes = null; //Guarda los byte de la foto actual
        private int idSeleccionado = -1; //Aqui rastrea que paquete se selcciono en la tabla
        public PaquetesTuristicos()
        {
            InitializeComponent();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaquetesTuristicos_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }


        //Subir imagen desde la compu
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();
            buscarImagen.Filter = "Archivos de imagem|*.jpp;*.jpeg;*.png;*.bmp";

            // Verifica si el usuario seleccionó una imagen y presionó "Abrir"
            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen seleccionada y la muestra en el PictureBox
                picPreview.Image = Image.FromFile(buscarImagen.FileName);
                // Crea un flujo de memoria temporal para guardar la imagen
                using (MemoryStream ms = new MemoryStream())
                {
                    // Guarda la imagen del PictureBox dentro del MemoryStream
                    // manteniendo el formato original (jpg, png, bmp, etc.)
                    picPreview.Image.Save(ms, picPreview.Image.RawFormat);
                    imagenBytes = ms.ToArray();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDestino.Text) || imagenBytes == null)
            {
                MessageBox.Show("Llena los campos principales y sube una imagen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregamos @Fecha en la consulta SQL
            string query = "INSERT INTO Paquetes (NombrePaquete, Destino, DuracionDias, Precio, CuposDisponibles, Descripcion, Imagen, FechaSalida) " +
                           "VALUES (@Nombre, @Destino, @Dias, @Precio, @Cupos, @Desc, @Img, @Fecha)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Destino", txtDestino.Text);
                    // 1. Mandamos la fecha directo desde tu calendario (Asegúrate de que se llame dtpFechaSalida en el diseño)
                    comando.Parameters.AddWithValue("@Dias", dtpFechaSalida.Value);
                    // 2. Volvemos a usar el Convert para leer tus cajas de texto normales
                    comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                    comando.Parameters.AddWithValue("@Cupos", Convert.ToInt32(txtCupos.Text));
                    comando.Parameters.AddWithValue("@Desc", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@Img", imagenBytes);

                    // ¡EL CALENDARIO ENTRA AQUÍ! Mandamos el valor de la fecha puro
                    comando.Parameters.AddWithValue("@Fecha", dtpFechaSalida.Value);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("¡Paquete internacional guardado con éxito!", "Éxito");
                }
            }
            LimpiarCampos();
            RefrescarTabla();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
                return;

            string query = "UPDATE Paquetes SET NombrePaquete=@Nombre, Destino=@Destino, DuracionDias=@Dias, " +
                   "Precio=@Precio, CuposDisponibles=@Cupos, Descripcion=@Desc, Imagen=@Img WHERE IdPaquete=@Id";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", idSeleccionado);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text); // Corregido de lbl a txt
                    comando.Parameters.AddWithValue("@Destino", txtDestino.Text); // Corregido de lbl a txt
                    comando.Parameters.AddWithValue("@Dias", dtpFechaSalida.Value);
                    comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text)); // Corregido de lbl a txt
                    comando.Parameters.AddWithValue("@Cupos", Convert.ToInt32(txtCupos.Text));
                    comando.Parameters.AddWithValue("@Desc", txtDescripcion.Text); // Corregido de lbl a txt
                                                                                   // Verificamos si hay una imagen cargada en memoria
                    if (imagenBytes != null)
                    {
                        comando.Parameters.AddWithValue("@Img", imagenBytes);
                    }
                    else
                    {
                        // Si no hay foto, le mandamos el NULO oficial de la base de datos
                        comando.Parameters.AddWithValue("@Img", DBNull.Value);
                    }


                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Paquete actualizado correctamente");
                }
            }
            LimpiarCampos();
            RefrescarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
                return;

            if (MessageBox.Show("¿Desea borrar este paquete?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM Paquetes WHERE IdPaquete = @Id";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", idSeleccionado);

                        // AQUÍ EMPIEZA LA MAGIA DEL ESCUDO
                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Paquete eliminado del sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            // Si el error es el 547 (Choque con Reservas), mostramos el mensaje amigable
                            if (ex.Number == 547)
                            {
                                MessageBox.Show("¡Acción bloqueada! \n\nNo puedes eliminar este paquete porque ya existen reservaciones ligadas a él.\n\nDebes eliminar las reservas primero si quieres borrar este destino.", "Protección de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else // Si es cualquier otro error, lo mostramos normal
                            {
                                MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        LimpiarCampos();
                        RefrescarTabla();
                    }
                }
            }
        }

        // Método que actualiza y muestra los datos de la tabla Paquetes en el DataGridView
        private void RefrescarTabla()
        {
            // Consulta SQL que obtiene todos los campos de la tabla Paquetes
            string query = "SELECT IdPaquete, NombrePaquete, Destino, DuracionDias, Precio, CuposDisponibles, Descripcion, Imagen FROM Paquetes";

            // Crea una conexión a la base de datos usando la cadena de conexión definida previamente
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {

                // Crea un adaptador de datos que ejecutará la consulta SQL
                // y traerá la información desde la base de datos
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                {
                    // Crea una tabla en memoria para almacenar los datos obtenidos
                    DataTable dt = new DataTable();

                    // Ejecuta la consulta y llena el DataTable con los registros encontrados
                    adaptador.Fill(dt);

                    // Asigna los datos del DataTable al DataGridView para mostrarlos en pantalla
                    dgvPaquetes.DataSource = dt;

                    // Verifica si existe una columna llamada "Imagen" en el DataGridView
                    if (dgvPaquetes.Columns.Contains("Imagen"))
                    {
                        ((DataGridViewImageColumn)dgvPaquetes.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }
        }

        // Evento que se ejecuta cuando el usuario hace clic en una celda del DataGridView
        

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDestino.Clear();
            dtpFechaSalida.Value = DateTime.Now; // Regresa a la fecha de hoy
            txtPrecio.Clear();
            txtCupos.Clear();
            txtDescripcion.Clear();
            picPreview.Image = null;
            imagenBytes = null;
            idSeleccionado = -1;
        }

        // Evento que se ejecuta cuando el usuario hace clic en una celda del DataGridView
        private void dgvPaquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPaquetes.Rows[e.RowIndex];

                // 1. Recuperamos los datos de texto y números normales
                idSeleccionado = Convert.ToInt32(fila.Cells["IdPaquete"].Value);
                txtNombre.Text = fila.Cells["NombrePaquete"].Value.ToString();
                txtDestino.Text = fila.Cells["Destino"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtCupos.Text = fila.Cells["CuposDisponibles"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();

                // 2. ¡CORRECCIÓN AQUÍ! Leemos la fecha de la tabla y la cargamos en el calendario
                if (fila.Cells["DuracionDias"].Value != DBNull.Value)
                {
                    dtpFechaSalida.Value = Convert.ToDateTime(fila.Cells["DuracionDias"].Value);
                }
                else
                {
                    dtpFechaSalida.Value = DateTime.Now; // Fecha de hoy por defecto si está vacío
                }

                // 3. Recuperamos la imagen binaria
                if (fila.Cells["Imagen"].Value != DBNull.Value)
                {
                    imagenBytes = (byte[])fila.Cells["Imagen"].Value;
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        picPreview.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picPreview.Image = null;
                    imagenBytes = null;
                }
            }
        }
    }
}
