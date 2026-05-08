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
       

        public FormMenuAdmin()
        {
            InitializeComponent();
            panelContenedor.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContenedor.Width, panelContenedor.Height, 20, 20));
            panelOpciones.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelOpciones.Width, panelOpciones.Height, 20, 20));

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
            // Abrimos el Inicio por defecto apenas carga el menú
            AbrirFormEnPanel(new FormInicio());
        }

        private void AbrirFormEnPanel(object formHijo)
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

    }
}
