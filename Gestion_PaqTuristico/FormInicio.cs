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

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void Aventuras_Click(object sender, EventArgs e)
        {
            //Averiguar que panel se presono o que control dentro del panel
            Control presionado = sender as Control;

            //Si presiona la foto o el texto, se necesita que busque el papá que es el panel

            if (!(presionado is Panel))
            {
                presionado = presionado.Parent;
            }

            //Identificar el lugar usar el nombre del panel
            string lugar = presionado.Name;
        }
    }
}
