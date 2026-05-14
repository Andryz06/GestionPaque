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

            //Perpar las variables vacias

            string descripcion = "";
            string promociones = "";

            Image fotoActual = ((PictureBox)presionado.Controls[0]).Image;

            //  LA BASE DE DATOS FAKE (Para la demo)
            // Aquí es donde en el futuro consultarás SQL. Por ahora, usaremos un Switch.
            switch (lugar)
            {
                case "panelFuji": // Asegúrate de que este sea el NOMBRE de tu panel en las propiedades
                    lugar = "Aventura en el Monte Fuji, Japón";
                    descripcion = "Experimenta la majestuosidad del pico más alto de Japón. Incluye transporte desde Tokio, guía bilingüe, equipo de senderismo básico y hospedaje en Ryokan tradicional.";
                    promociones = "💰 PROMO: ¡20% de descuento si reservas antes del verano! 💰";
                    break;

                case "panelAngkor": // Nombre de tu segundo panel
                    lugar = "Angkor Wat - Camboya";
                    descripcion = "Descubre los secretos de la antigua civilización Jemer en el complejo religioso más grande del mundo. Tour al amanecer incluido.";
                    promociones = "PROMO: ¡Tercera noche gratis en hotel 5 estrellas! 🎁";
                    break;
                    // ... Agrega los otros casos para Lisboa y Guanajuato ...

                    // INSTANCIAR LA NUEVA VENTANA Y PASARLE DATOS
                    FormReservas frmR = new FormReservas();
                    frmR.CargarDatosDelLugar(lugar, descripcion, fotoActual, promociones);

                    var menuPrincipal = Application.OpenForms.OfType<FormMenuAdmin>().FirstOrDefault();

                    if (menuPrincipal != null)
                    {
                        menuPrincipal.AbrirFormEnPanel(frmR);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el menú principal abierto. Asegúrate de ponerle el nombre correcto en el código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }
    }
}
