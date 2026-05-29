namespace Gestion_PaqTuristico
{
    partial class FormClientes
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
            dgvClientes = new DataGridView();
            txtBuscar = new TextBox();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            numPasajeros = new NumericUpDown();
            cmbDestino = new ComboBox();
            lblDaReserva = new Label();
            lblDatos = new Label();
            lblPasaje = new Label();
            label2 = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            btnModificarReserva = new ReaLTaiizor.Controls.MaterialButton();
            lblBotones = new Label();
            btnCancelarReserva = new ReaLTaiizor.Controls.MaterialButton();
            btnActualizarPerfil = new ReaLTaiizor.Controls.MaterialButton();
            btnNuevoCliente = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasajeros).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(172, 444);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(640, 101);
            dgvClientes.TabIndex = 0;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.LightGray;
            txtBuscar.Location = new Point(234, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(545, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox6);
            materialCard1.Controls.Add(pictureBox5);
            materialCard1.Controls.Add(pictureBox4);
            materialCard1.Controls.Add(pictureBox3);
            materialCard1.Controls.Add(pictureBox2);
            materialCard1.Controls.Add(numPasajeros);
            materialCard1.Controls.Add(cmbDestino);
            materialCard1.Controls.Add(lblDaReserva);
            materialCard1.Controls.Add(lblDatos);
            materialCard1.Controls.Add(lblPasaje);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(lblTelefono);
            materialCard1.Controls.Add(txtTelefono);
            materialCard1.Controls.Add(lblCorreo);
            materialCard1.Controls.Add(txtCorreo);
            materialCard1.Controls.Add(txtNombre);
            materialCard1.Controls.Add(lblNombre);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(12, 125);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(602, 273);
            materialCard1.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.boletos_de_avion;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(52, 224);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 23);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.despegue_del_avion;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(52, 198);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 23);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.telefono;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(52, 117);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 23);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.correo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(52, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 23);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.nombres;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(52, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 23);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // numPasajeros
            // 
            numPasajeros.Location = new Point(170, 224);
            numPasajeros.Name = "numPasajeros";
            numPasajeros.Size = new Size(120, 23);
            numPasajeros.TabIndex = 13;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(169, 198);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 23);
            cmbDestino.TabIndex = 12;
            // 
            // lblDaReserva
            // 
            lblDaReserva.AutoSize = true;
            lblDaReserva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaReserva.Location = new Point(52, 167);
            lblDaReserva.Name = "lblDaReserva";
            lblDaReserva.Size = new Size(210, 25);
            lblDaReserva.TabIndex = 11;
            lblDaReserva.Text = "DATOS DE LA RESERVA";
            lblDaReserva.Click += lblDaReserva_Click;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(52, 14);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(186, 25);
            lblDatos.TabIndex = 10;
            lblDatos.Text = "DATOS DEL CLIENTE";
            // 
            // lblPasaje
            // 
            lblPasaje.AutoSize = true;
            lblPasaje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasaje.Location = new Point(88, 224);
            lblPasaje.Name = "lblPasaje";
            lblPasaje.Size = new Size(54, 21);
            lblPasaje.TabIndex = 9;
            lblPasaje.Text = "Pasaj.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 195);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 7;
            label2.Text = "Destino:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(88, 117);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 21);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightBlue;
            txtTelefono.Location = new Point(169, 115);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(390, 23);
            txtTelefono.TabIndex = 4;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(88, 88);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(65, 21);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.LightBlue;
            txtCorreo.Location = new Point(169, 86);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(390, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightBlue;
            txtNombre.Location = new Point(169, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(390, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(88, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnModificarReserva);
            materialCard2.Controls.Add(lblBotones);
            materialCard2.Controls.Add(btnCancelarReserva);
            materialCard2.Controls.Add(btnActualizarPerfil);
            materialCard2.Controls.Add(btnNuevoCliente);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(655, 125);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(274, 273);
            materialCard2.TabIndex = 3;
            // 
            // btnModificarReserva
            // 
            btnModificarReserva.AutoSize = false;
            btnModificarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarReserva.BackColor = Color.White;
            btnModificarReserva.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificarReserva.Depth = 0;
            btnModificarReserva.HighEmphasis = true;
            btnModificarReserva.Icon = null;
            btnModificarReserva.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnModificarReserva.Location = new Point(34, 126);
            btnModificarReserva.Margin = new Padding(4, 6, 4, 6);
            btnModificarReserva.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnModificarReserva.Name = "btnModificarReserva";
            btnModificarReserva.NoAccentTextColor = Color.Empty;
            btnModificarReserva.Size = new Size(212, 36);
            btnModificarReserva.TabIndex = 5;
            btnModificarReserva.Text = "✏️ MODIFICAR RESERVA";
            btnModificarReserva.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificarReserva.UseAccentColor = false;
            btnModificarReserva.UseVisualStyleBackColor = false;
            btnModificarReserva.Click += materialButton2_Click;
            // 
            // lblBotones
            // 
            lblBotones.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBotones.Location = new Point(34, 10);
            lblBotones.Name = "lblBotones";
            lblBotones.Size = new Size(207, 26);
            lblBotones.TabIndex = 4;
            lblBotones.Text = "SOPORTE Y ACCIONES ";
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.AutoSize = false;
            btnCancelarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarReserva.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarReserva.Depth = 0;
            btnCancelarReserva.HighEmphasis = true;
            btnCancelarReserva.Icon = null;
            btnCancelarReserva.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelarReserva.Location = new Point(34, 209);
            btnCancelarReserva.Margin = new Padding(4, 6, 4, 6);
            btnCancelarReserva.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.NoAccentTextColor = Color.Empty;
            btnCancelarReserva.Size = new Size(212, 36);
            btnCancelarReserva.TabIndex = 3;
            btnCancelarReserva.Text = "🚫 CANCELAR RESERVA SELECCIONADA";
            btnCancelarReserva.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarReserva.UseAccentColor = false;
            btnCancelarReserva.UseVisualStyleBackColor = true;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // btnActualizarPerfil
            // 
            btnActualizarPerfil.AutoSize = false;
            btnActualizarPerfil.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActualizarPerfil.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnActualizarPerfil.Depth = 0;
            btnActualizarPerfil.HighEmphasis = true;
            btnActualizarPerfil.Icon = null;
            btnActualizarPerfil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnActualizarPerfil.Location = new Point(34, 82);
            btnActualizarPerfil.Margin = new Padding(4, 6, 4, 6);
            btnActualizarPerfil.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnActualizarPerfil.Name = "btnActualizarPerfil";
            btnActualizarPerfil.NoAccentTextColor = Color.Empty;
            btnActualizarPerfil.Size = new Size(212, 36);
            btnActualizarPerfil.TabIndex = 1;
            btnActualizarPerfil.Text = "✏️ ACTUALIZAR DATOS";
            btnActualizarPerfil.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnActualizarPerfil.UseAccentColor = false;
            btnActualizarPerfil.UseVisualStyleBackColor = true;
            btnActualizarPerfil.Click += materialButton1_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoCliente.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNuevoCliente.Depth = 0;
            btnNuevoCliente.HighEmphasis = true;
            btnNuevoCliente.Icon = null;
            btnNuevoCliente.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNuevoCliente.Location = new Point(34, 42);
            btnNuevoCliente.Margin = new Padding(4, 6, 4, 6);
            btnNuevoCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.NoAccentTextColor = Color.Empty;
            btnNuevoCliente.Size = new Size(212, 36);
            btnNuevoCliente.TabIndex = 0;
            btnNuevoCliente.Text = "💾 GUARDAR NUEVO CLIENTE";
            btnNuevoCliente.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNuevoCliente.UseAccentColor = false;
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.busqueda_de_lupa;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(198, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 23);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 40);
            label1.TabIndex = 5;
            label1.Text = "GESTIÓN DE CLIENTES";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 606);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(txtBuscar);
            Controls.Add(dgvClientes);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasajeros).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtBuscar;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private Label lblDaReserva;
        private Label lblDatos;
        private Label lblPasaje;
        private TextBox textBox5;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnNuevoCliente;
        private ReaLTaiizor.Controls.MaterialButton btnCancelarReserva;
        private ReaLTaiizor.Controls.MaterialButton btnActualizarPerfil;
        private Label lblBotones;
        private ComboBox cmbDestino;
        private NumericUpDown numPasajeros;
        private ReaLTaiizor.Controls.MaterialButton btnModificarReserva;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}