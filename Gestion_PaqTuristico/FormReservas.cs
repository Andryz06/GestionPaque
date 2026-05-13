using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_PaqTuristico
{
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
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

        }
    }
}
