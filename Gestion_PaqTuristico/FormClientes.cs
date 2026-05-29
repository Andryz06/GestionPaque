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
    public partial class FormClientes : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        //  VARIABLES GLOBALES Y ARRANQUE
        // ===============================================
        private string cadenaConexion = @"Server=(localdb)\Jeremy; Database=TourHyruleDB; Trusted_Connection=True;";
        private DataTable dtClientesReservas = new DataTable();


        public FormClientes()
        {
            InitializeComponent();
            // Puedes hacerlo panel por panel:
            // CurvarPanel(panelDatos, 20);

            // O con el bucle para curvar TODOS los paneles de un solo golpe:
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    CurvarPanel(c, 20); // El 20 es el nivel de curva
                }
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarDestinosCombo();
            CargarClientesYReservas();
        }

        private void CargarDestinosCombo()
        {
            string query = "SELECT IdPaquete, (NombrePaquete + ' - ' + Destino) AS NombreCompleto FROM Paquetes";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                {
                    DataTable dtDestinos = new DataTable();
                    adaptador.Fill(dtDestinos);
                    cmbDestino.DataSource = dtDestinos;
                    cmbDestino.DisplayMember = "NombreCompleto";
                    cmbDestino.ValueMember = "IdPaquete";
                }
            }
        }

        private void CargarClientesYReservas()
        {
            string query = @"
                SELECT 
                    c.IdCliente, 
                    r.IdReserva,
                    c.NombreCompleto AS [CLIENTE], 
                    c.Email AS [CORREO], 
                    c.Telefono AS [TELÉFONO],
                    ISNULL(p.NombrePaquete, 'Sin reservas') AS [DESTINO], 
                    ISNULL(r.CantidadPersonas, 0) AS [PASAJEROS],
                    ISNULL(r.Estado, 'N/A') AS [ESTADO]
                FROM Clientes c
                LEFT JOIN Reservas r ON c.IdCliente = r.IdCliente
                LEFT JOIN Paquetes p ON r.IdPaquete = p.IdPaquete
                ORDER BY c.NombreCompleto ASC";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                {
                    dtClientesReservas.Clear();
                    adaptador.Fill(dtClientesReservas);
                    dgvClientes.DataSource = dtClientesReservas;

                    if (dgvClientes.Columns.Contains("IdCliente")) dgvClientes.Columns["IdCliente"].Visible = false;
                    if (dgvClientes.Columns.Contains("IdReserva")) dgvClientes.Columns["IdReserva"].Visible = false;
                }
            }
        }



        //INTERACTIVIDAD Y BUSCADOR
        // ====================================
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dtClientesReservas.Rows.Count > 0)
            {
                dtClientesReservas.DefaultView.RowFilter = string.Format("CLIENTE LIKE '%{0}%' OR CORREO LIKE '%{0}%'", txtBuscar.Text.Replace("'", "''"));
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentCell != null && dgvClientes.CurrentRow.Index >= 0)
            {
                DataGridViewRow fila = dgvClientes.CurrentRow;

                // Subimos los datos del cliente a los TextBox
                txtNombre.Text = fila.Cells["CLIENTE"].Value.ToString();
                txtCorreo.Text = fila.Cells["CORREO"].Value.ToString();
                txtTelefono.Text = fila.Cells["TELÉFONO"].Value.ToString();

                //Revisamos la reserva
                if (fila.Cells["DESTINO"].Value.ToString() != "Sin Reservas")
                {
                    cmbDestino.Text = fila.Cells["DESTINO"].Value.ToString();
                    numPasajeros.Value = Convert.ToInt32(fila.Cells["PASAJEROS"].Value);
                }
                else
                {
                    cmbDestino.SelectedIndex = -1;
                    numPasajeros.Value = 0;
                }
            }
        }
        //  MÓDULO DE DATOS PERSONALES (CRUD LIGERO)
        // ==================================================
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El Nombre y Correo son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserción Doble: Primero en Usuarios (para el Login), luego en Clientes

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    // 1. Crear el acceso de usuario con clave genérica "12345" y rol "Cliente"
                    string queryUser = "INSERT INTO Usuarios (Nombres, Correo, Password, Rol) VALUES (@Nom, @Cor, '12345', 'Cliente'); SELECT SCOPE_IDENTITY();";
                    int nuevoIdUsuario = 0;
                    using (SqlCommand cmdUser = new SqlCommand(queryUser, conexion, transaccion))
                    {
                        cmdUser.Parameters.AddWithValue("@Nom", txtNombre.Text);
                        cmdUser.Parameters.AddWithValue("@Cor", txtCorreo.Text);
                        nuevoIdUsuario = Convert.ToInt32(cmdUser.ExecuteScalar());
                    }

                    // 2. Crear su perfil oficial de Cliente enlazado al Usuario
                    string queryCliente = "INSERT INTO Clientes (IdUsuario, NombreCompleto, Email, Telefono) VALUES (@IdUser, @Nom, @Cor, @Tel)";
                    using (SqlCommand cmdCliente = new SqlCommand(queryCliente, conexion, transaccion))
                    {
                        cmdCliente.Parameters.AddWithValue("@IdUser", nuevoIdUsuario);
                        cmdCliente.Parameters.AddWithValue("@Nom", txtNombre.Text);
                        cmdCliente.Parameters.AddWithValue("@Cor", txtCorreo.Text);
                        cmdCliente.Parameters.AddWithValue("@Tel", txtTelefono.Text);
                        cmdCliente.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    MessageBox.Show("Cliente registrado con éxito. Su clave temporal es: 12345", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientesYReservas();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al registrar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //BOTON MODIFICAR PERFIL
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);
            string query = "UPDATE Clientes SET NombreCompleto = @Nom, Email = @Cor, Telefono = @Tel WHERE IdCliente = @IdCliente";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Cor", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Perfil actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientesYReservas();
                }
            }
        }
        //BOTON MODIFICAR RESERVA
        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null || dgvClientes.CurrentRow.Cells["IdReserva"].Value == DBNull.Value)
            {
                MessageBox.Show("Este cliente no tiene una reserva activa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idReserva = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdReserva"].Value);
            int pasajerosViejos = Convert.ToInt32(dgvClientes.CurrentRow.Cells["PASAJEROS"].Value);
            int idPaqueteNuevo = Convert.ToInt32(cmbDestino.SelectedValue);
            int pasajerosNuevos = Convert.ToInt32(numPasajeros.Value);

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    // 1. Regresamos cupos a origen
                    string q1 = "UPDATE Paquetes SET CuposDisponibles = CuposDisponibles + @PasViejos WHERE IdPaquete = (SELECT IdPaquete FROM Reservas WHERE IdReserva = @IdRes)";
                    using (SqlCommand c1 = new SqlCommand(q1, conexion, transaccion))
                    {
                        c1.Parameters.AddWithValue("@PasViejos", pasajerosViejos);
                        c1.Parameters.AddWithValue("@IdRes", idReserva);
                        c1.ExecuteNonQuery();
                    }

                    // 2. Restamos cupos al nuevo destino
                    string q2 = "UPDATE Paquetes SET CuposDisponibles = CuposDisponibles - @PasNuevos WHERE IdPaquete = @IdPaqNuevo";
                    using (SqlCommand c2 = new SqlCommand(q2, conexion, transaccion))
                    {
                        c2.Parameters.AddWithValue("@PasNuevos", pasajerosNuevos);
                        c2.Parameters.AddWithValue("@IdPaqNuevo", idPaqueteNuevo);
                        c2.ExecuteNonQuery();
                    }

                    // 3. Actualizamos la reserva
                    string q3 = "UPDATE Reservas SET IdPaquete = @IdPaqNuevo, CantidadPersonas = @PasNuevos WHERE IdReserva = @IdRes";
                    using (SqlCommand c3 = new SqlCommand(q3, conexion, transaccion))
                    {
                        c3.Parameters.AddWithValue("@IdPaqNuevo", idPaqueteNuevo);
                        c3.Parameters.AddWithValue("@PasNuevos", pasajerosNuevos);
                        c3.Parameters.AddWithValue("@IdRes", idReserva);
                        c3.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    MessageBox.Show("Reserva modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientesYReservas();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al modificar reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null || dgvClientes.CurrentRow.Cells["IdReserva"].Value == DBNull.Value) return;

            int idReserva = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdReserva"].Value);
            int pasajeros = Convert.ToInt32(dgvClientes.CurrentRow.Cells["PASAJEROS"].Value);

            if (dgvClientes.CurrentRow.Cells["ESTADO"].Value.ToString() == "Cancelado")
            {
                MessageBox.Show("Ya está cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Seguro que desea cancelar la reserva y devolver los cupos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlTransaction transaccion = conexion.BeginTransaction();
                    try
                    {
                        string q1 = "UPDATE Reservas SET Estado = 'Cancelado' WHERE IdReserva = @IdRes";
                        using (SqlCommand c1 = new SqlCommand(q1, conexion, transaccion))
                        {
                            c1.Parameters.AddWithValue("@IdRes", idReserva);
                            c1.ExecuteNonQuery();
                        }

                        string q2 = "UPDATE Paquetes SET CuposDisponibles = CuposDisponibles + @Pasajeros WHERE IdPaquete = (SELECT IdPaquete FROM Reservas WHERE IdReserva = @IdRes)";
                        using (SqlCommand c2 = new SqlCommand(q2, conexion, transaccion))
                        {
                            c2.Parameters.AddWithValue("@Pasajeros", pasajeros);
                            c2.Parameters.AddWithValue("@IdRes", idReserva);
                            c2.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        MessageBox.Show("Reserva cancelada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarClientesYReservas();
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error al cancelar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lblDaReserva_Click(object sender, EventArgs e)
        {

        }
        private void CurvarPanel(Control c, int curvatura)
        {
            c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, curvatura, curvatura));
        }
    }

}
