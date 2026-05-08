using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Gestion_PaqTuristico
{
    public partial class FormElegirPerfil : Form
    {
        //Codigo para curvas en los paneles :v

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
        public FormElegirPerfil()
        {
            InitializeComponent();
            panelClave.Parent = this;

            panelClave.Location = panelPrincipalOp.Location;

            panelClave.BringToFront();

            //Para curvear la ventana principal
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));

            // curvear panel codigo
            panelClave.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelClave.Width, panelClave.Height, 20, 20)); // Le puse 20 para que la curva sea más suave por ser más pequeño

            panelClave.Visible = false;
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCrearUsuario registro = new FormCrearUsuario();
            registro.rolSeleccionado = "Cliente";

            registro.Show();
            this.Hide();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            panelPrincipalOp.Visible = false; //Para esconder el panel
            panelClave.Visible = true; //Para mostrar l panel de codigo de aceso
            txtCodigoEm.Focus();
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            //Aqui se definine el codigo de acces

            string codigoSecreto = "Tour2026";

            if (txtCodigoEm.Text == codigoSecreto)
            {
                MessageBox.Show("Codido Verificado", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Aqui abre el formu
                FormCrearUsuario registro = new FormCrearUsuario();
                registro.rolSeleccionado = "Empleado";
                registro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Código de acceso incorrecto, Acceso denegado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoEm.Clear(); //limpiamos la caja para otro intento

                panelClave.Visible = false;
                panelPrincipalOp.Visible = true;
            }
        }

        private void lblVolverLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms["FormLogin"].Show();
            this.Close();
        }
    }
}
