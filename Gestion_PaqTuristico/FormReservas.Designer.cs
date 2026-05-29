namespace Gestion_PaqTuristico
{
    partial class FormReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            lblCantidad = new Label();
            lblTituloCliente = new Label();
            lblPrecioPersona = new Label();
            lblTotal = new Label();
            btnConfirmar = new ReaLTaiizor.Controls.MaterialButton();
            numPersonas = new NumericUpDown();
            cmbClientes = new ComboBox();
            lblPromociones = new Label();
            lblDescripcion = new Label();
            lblTituloDestino = new Label();
            picDestino = new PictureBox();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtBuscar = new TextBox();
            dgvCatalogo = new DataGridView();
            lblTitulo = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDestino).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblCantidad);
            materialCard1.Controls.Add(lblTituloCliente);
            materialCard1.Controls.Add(lblPrecioPersona);
            materialCard1.Controls.Add(lblTotal);
            materialCard1.Controls.Add(btnConfirmar);
            materialCard1.Controls.Add(numPersonas);
            materialCard1.Controls.Add(cmbClientes);
            materialCard1.Controls.Add(lblPromociones);
            materialCard1.Controls.Add(lblDescripcion);
            materialCard1.Controls.Add(lblTituloDestino);
            materialCard1.Controls.Add(picDestino);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(517, 88);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(427, 474);
            materialCard1.TabIndex = 0;
            materialCard1.Paint += materialCard1_Paint;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(93, 69);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(170, 21);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad de Personas:";
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.AutoSize = true;
            lblTituloCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCliente.Location = new Point(191, 42);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(72, 21);
            lblTituloCliente.TabIndex = 9;
            lblTituloCliente.Text = "Clientes:";
            // 
            // lblPrecioPersona
            // 
            lblPrecioPersona.AutoSize = true;
            lblPrecioPersona.Location = new Point(165, 373);
            lblPrecioPersona.Name = "lblPrecioPersona";
            lblPrecioPersona.Size = new Size(0, 15);
            lblPrecioPersona.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 375);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = false;
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConfirmar.Location = new Point(18, 418);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(391, 36);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar Reserva";
            btnConfirmar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // numPersonas
            // 
            numPersonas.Location = new Point(269, 69);
            numPersonas.Name = "numPersonas";
            numPersonas.Size = new Size(124, 23);
            numPersonas.TabIndex = 5;
            numPersonas.ValueChanged += numPersonas_ValueChanged;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(269, 40);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(117, 23);
            cmbClientes.TabIndex = 4;
            // 
            // lblPromociones
            // 
            lblPromociones.AutoSize = true;
            lblPromociones.Location = new Point(18, 342);
            lblPromociones.Name = "lblPromociones";
            lblPromociones.Size = new Size(0, 15);
            lblPromociones.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(18, 315);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(0, 15);
            lblDescripcion.TabIndex = 2;
            // 
            // lblTituloDestino
            // 
            lblTituloDestino.AutoSize = true;
            lblTituloDestino.Location = new Point(18, 288);
            lblTituloDestino.Name = "lblTituloDestino";
            lblTituloDestino.Size = new Size(0, 15);
            lblTituloDestino.TabIndex = 1;
            // 
            // picDestino
            // 
            picDestino.BackgroundImageLayout = ImageLayout.Zoom;
            picDestino.Location = new Point(17, 128);
            picDestino.Name = "picDestino";
            picDestino.Size = new Size(393, 146);
            picDestino.SizeMode = PictureBoxSizeMode.Zoom;
            picDestino.TabIndex = 0;
            picDestino.TabStop = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(label1);
            materialCard2.Controls.Add(pictureBox1);
            materialCard2.Controls.Add(txtBuscar);
            materialCard2.Controls.Add(dgvCatalogo);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(23, 88);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(478, 474);
            materialCard2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(335, 32);
            label1.TabIndex = 4;
            label1.Text = "CATÁLOGO PUNTO DE VENTA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.busqueda_de_lupa;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(420, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 23);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(23, 84);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(389, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(17, 128);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.Size = new Size(444, 329);
            dgvCatalogo.TabIndex = 0;
            dgvCatalogo.SelectionChanged += dgvCatalogo_SelectionChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(23, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(445, 40);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "CATÁLOGO Y PUNTO DE VENTA";
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 606);
            Controls.Add(lblTitulo);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "FormReservas";
            Text = "FormReservas";
            Load += FormReservas_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDestino).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label lblPromociones;
        private Label lblDescripcion;
        private Label lblTituloDestino;
        private PictureBox picDestino;
        private NumericUpDown numPersonas;
        private ComboBox cmbClientes;
        private ReaLTaiizor.Controls.MaterialButton btnConfirmar;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private DataGridView dgvCatalogo;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblTotal;
        private Label lblPrecioPersona;
        private Label lblCantidad;
        private Label lblTituloCliente;
    }
}