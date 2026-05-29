using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gestion_PaqTuristico
{
    public partial class FormMenuAdmin : Form
    {
        public string RolActivo = "";
        public int IdUsuarioActivo = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        // ESTA ES LA FUNCIÓN QUE TE FALTA (El "Motor")


        public FormMenuAdmin(string rol, int idUsuario)
        {
            InitializeComponent();
            panelContenedor.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContenedor.Width, panelContenedor.Height, 20, 20));
            panelOpciones.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelOpciones.Width, panelOpciones.Height, 20, 20));
            // 1. Modificamos el constructor para recibir los datos

            RolActivo = rol;
            IdUsuarioActivo = idUsuario;
        }

        //lbl de salir o volver al menu
        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms["FormLogin"].Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Esto agarra tu FormInicio que acabas de diseñar y lo embute en la pantalla blanca grande
            AbrirFormEnPanel(new FormInicio());
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInicio());

            // Si el que entra es un Cliente, le escondemos los botones de admi
            if (RolActivo == "Cliente")
            {
                btnPaquetes.Visible = false; // se esconde el crud de paquetes
                btnClientes.Visible = false; // Se esconde la gestion de clientes
                btnInformes.Visible = false;
                picPaquete.Visible = false;
                picClientes.Visible = false;
                picInformes.Visible = false;

                // Deja visible los demas botones
                lblNombreUsuario.Text = "Modo Cliente";
            }
            else if (RolActivo == "Empleado")
            {
                // Si es Empleado, le escondemos SOLO los informes
                btnInformes.Visible = false;
                picInformes.Visible = false;

                lblNombreUsuario.Text = "Modo Empleado";
            }
            else if (RolActivo == "Admin")
            {
                // SI es Adm, Todo se queda visible
                lblNombreUsuario.Text = "Admin: Jeremy";
            }
        }

        public void AbrirFormEnPanel(object formHijo)
        {
            // Usamos el nombre de tu panel grande: panelReservasRecientes
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;

            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            // Llama a la pantalla del CRUD de paquetes y la embute en el panel contenedor
            AbrirFormEnPanel(new PaquetesTuristicos());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            // 1. Creamos la ventana de reservas
            FormReservas frmReservas = new FormReservas();

            // 2. LA MAGIA: Le pasamos el rol y el ID antes de mostrarla
            frmReservas.ConfigurarSeguridad(RolActivo, IdUsuarioActivo);

            // 3. La abrimos en tu panel central (usa el método que ya tienes para abrir forms en el panel)
            AbrirFormEnPanel(frmReservas);
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormClientes());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInformes());
        }

        //Este es el boton de configuracion
        private void poisonButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConfiguracion(IdUsuarioActivo, RolActivo));
        }
    }
}
