namespace Gestion_PaqTuristico
{
    partial class PaquetesTuristicos
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
            dtpFechaSalida = new DateTimePicker();
            label1 = new Label();
            lblDias = new Label();
            txtCupos = new TextBox();
            btnSeleccionarImagen = new ReaLTaiizor.Controls.MaterialButton();
            btnEliminar = new ReaLTaiizor.Controls.MaterialButton();
            btnModificar = new ReaLTaiizor.Controls.MaterialButton();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            txtTITULO = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblDestino = new Label();
            lblNombre = new Label();
            dgvPaquetes = new DataGridView();
            picPreview = new PictureBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtDestino = new TextBox();
            txtNombre = new TextBox();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dtpFechaSalida);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(lblDias);
            materialCard1.Controls.Add(txtCupos);
            materialCard1.Controls.Add(btnSeleccionarImagen);
            materialCard1.Controls.Add(btnEliminar);
            materialCard1.Controls.Add(btnModificar);
            materialCard1.Controls.Add(btnAgregar);
            materialCard1.Controls.Add(txtTITULO);
            materialCard1.Controls.Add(lblDescripcion);
            materialCard1.Controls.Add(lblPrecio);
            materialCard1.Controls.Add(lblDestino);
            materialCard1.Controls.Add(lblNombre);
            materialCard1.Controls.Add(dgvPaquetes);
            materialCard1.Controls.Add(picPreview);
            materialCard1.Controls.Add(txtDescripcion);
            materialCard1.Controls.Add(txtPrecio);
            materialCard1.Controls.Add(txtDestino);
            materialCard1.Controls.Add(txtNombre);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(-3, 1);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(961, 607);
            materialCard1.TabIndex = 0;
            materialCard1.Paint += materialCard1_Paint;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Format = DateTimePickerFormat.Short;
            dtpFechaSalida.Location = new Point(459, 97);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(159, 23);
            dtpFechaSalida.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 219);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 19;
            label1.Text = "Cupos disponibles:";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(459, 72);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(109, 17);
            lblDias.TabIndex = 18;
            lblDias.Text = "Dias Disponibles:";
            // 
            // txtCupos
            // 
            txtCupos.Location = new Point(459, 237);
            txtCupos.Name = "txtCupos";
            txtCupos.Size = new Size(159, 23);
            txtCupos.TabIndex = 17;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.AutoSize = false;
            btnSeleccionarImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSeleccionarImagen.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSeleccionarImagen.Depth = 0;
            btnSeleccionarImagen.HighEmphasis = true;
            btnSeleccionarImagen.Icon = null;
            btnSeleccionarImagen.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSeleccionarImagen.Location = new Point(648, 324);
            btnSeleccionarImagen.Margin = new Padding(4, 6, 4, 6);
            btnSeleccionarImagen.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.NoAccentTextColor = Color.Empty;
            btnSeleccionarImagen.Size = new Size(262, 36);
            btnSeleccionarImagen.TabIndex = 15;
            btnSeleccionarImagen.Text = "Subir Imagen    📁";
            btnSeleccionarImagen.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSeleccionarImagen.UseAccentColor = false;
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = false;
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEliminar.Location = new Point(773, 519);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(137, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = false;
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnModificar.Location = new Point(773, 460);
            btnModificar.Margin = new Padding(4, 6, 4, 6);
            btnModificar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(137, 36);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "✏️ Modificar";
            btnModificar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = false;
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregar.Depth = 0;
            btnAgregar.HighEmphasis = true;
            btnAgregar.Icon = null;
            btnAgregar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAgregar.Location = new Point(773, 401);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(137, 36);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTITULO
            // 
            txtTITULO.AutoSize = true;
            txtTITULO.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTITULO.Location = new Point(36, 14);
            txtTITULO.Name = "txtTITULO";
            txtTITULO.Size = new Size(243, 30);
            txtTITULO.TabIndex = 11;
            txtTITULO.Text = "PAQUETES TURISTICOS";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(41, 243);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(80, 17);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(41, 185);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(67, 17);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio ($):";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(40, 132);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(57, 17);
            lblDestino.TabIndex = 8;
            lblDestino.Text = "Destino:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(41, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre del Paquete";
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Location = new Point(36, 401);
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.Size = new Size(730, 173);
            dgvPaquetes.TabIndex = 6;
            dgvPaquetes.CellClick += dgvPaquetes_CellClick;
            // 
            // picPreview
            // 
            picPreview.BackgroundImageLayout = ImageLayout.Zoom;
            picPreview.Location = new Point(648, 61);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(262, 242);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 4;
            picPreview.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.LightBlue;
            txtDescripcion.Location = new Point(36, 264);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(403, 96);
            txtDescripcion.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.LightBlue;
            txtPrecio.Location = new Point(36, 207);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(403, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtDestino
            // 
            txtDestino.BackColor = Color.LightBlue;
            txtDestino.Location = new Point(36, 153);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(403, 23);
            txtDestino.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightBlue;
            txtNombre.Location = new Point(36, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(403, 23);
            txtNombre.TabIndex = 0;
            // 
            // PaquetesTuristicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 606);
            Controls.Add(materialCard1);
            Name = "PaquetesTuristicos";
            Text = "ooo";
            Load += PaquetesTuristicos_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtDestino;
        private PictureBox picPreview;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private DataGridView dgvPaquetes;
        private Label lblPrecio;
        private Label lblDestino;
        private Label lblDescripcion;
        private Label txtTITULO;
        private ReaLTaiizor.Controls.MaterialButton btnModificar;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
        private ReaLTaiizor.Controls.MaterialButton btnEliminar;
        private ReaLTaiizor.Controls.MaterialButton btnSeleccionarImagen;
        private Label label1;
        private Label lblDias;
        private TextBox txtCupos;
        private DateTimePicker dtpFechaSalida;
    }
}