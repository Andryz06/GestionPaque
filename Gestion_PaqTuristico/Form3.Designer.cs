namespace Gestion_PaqTuristico
{
    partial class FormElegirPerfil
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
            panelPrincipalOp = new ReaLTaiizor.Controls.MaterialCard();
            lblVolverLog = new ReaLTaiizor.Controls.NightLinkLabel();
            panelClave = new ReaLTaiizor.Controls.MaterialCard();
            btnValidarCodigo = new ReaLTaiizor.Controls.MaterialButton();
            label2 = new Label();
            txtCodigoEm = new ReaLTaiizor.Controls.PoisonTextBox();
            btnEmpleado = new ReaLTaiizor.Controls.MaterialButton();
            btnCliente = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelPrincipalOp.SuspendLayout();
            panelClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipalOp
            // 
            panelPrincipalOp.BackColor = Color.FromArgb(255, 255, 255);
            panelPrincipalOp.Controls.Add(lblVolverLog);
            panelPrincipalOp.Controls.Add(panelClave);
            panelPrincipalOp.Controls.Add(btnEmpleado);
            panelPrincipalOp.Controls.Add(btnCliente);
            panelPrincipalOp.Controls.Add(label1);
            panelPrincipalOp.Controls.Add(pictureBox1);
            panelPrincipalOp.Depth = 0;
            panelPrincipalOp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelPrincipalOp.Location = new Point(338, 64);
            panelPrincipalOp.Margin = new Padding(14);
            panelPrincipalOp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelPrincipalOp.Name = "panelPrincipalOp";
            panelPrincipalOp.Padding = new Padding(14);
            panelPrincipalOp.Size = new Size(285, 320);
            panelPrincipalOp.TabIndex = 0;
            panelPrincipalOp.Paint += materialCard1_Paint;
            // 
            // lblVolverLog
            // 
            lblVolverLog.ActiveLinkColor = Color.FromArgb(222, 89, 84);
            lblVolverLog.AutoSize = true;
            lblVolverLog.BackColor = Color.Transparent;
            lblVolverLog.Font = new Font("Segoe UI", 9F);
            lblVolverLog.LinkBehavior = LinkBehavior.HoverUnderline;
            lblVolverLog.LinkColor = Color.Blue;
            lblVolverLog.Location = new Point(100, 291);
            lblVolverLog.Name = "lblVolverLog";
            lblVolverLog.Size = new Size(84, 15);
            lblVolverLog.TabIndex = 4;
            lblVolverLog.TabStop = true;
            lblVolverLog.Text = "Volver al Login";
            lblVolverLog.VisitedLinkColor = Color.FromArgb(254, 89, 84);
            lblVolverLog.LinkClicked += lblVolverLog_LinkClicked;
            // 
            // panelClave
            // 
            panelClave.BackColor = Color.FromArgb(255, 255, 255);
            panelClave.Controls.Add(btnValidarCodigo);
            panelClave.Controls.Add(label2);
            panelClave.Controls.Add(txtCodigoEm);
            panelClave.Depth = 0;
            panelClave.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelClave.Location = new Point(15, 92);
            panelClave.Margin = new Padding(14);
            panelClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelClave.Name = "panelClave";
            panelClave.Padding = new Padding(14);
            panelClave.Size = new Size(255, 169);
            panelClave.TabIndex = 1;
            // 
            // btnValidarCodigo
            // 
            btnValidarCodigo.AutoSize = false;
            btnValidarCodigo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidarCodigo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnValidarCodigo.Depth = 0;
            btnValidarCodigo.HighEmphasis = true;
            btnValidarCodigo.Icon = null;
            btnValidarCodigo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnValidarCodigo.Location = new Point(56, 113);
            btnValidarCodigo.Margin = new Padding(4, 6, 4, 6);
            btnValidarCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnValidarCodigo.Name = "btnValidarCodigo";
            btnValidarCodigo.NoAccentTextColor = Color.Empty;
            btnValidarCodigo.Size = new Size(143, 36);
            btnValidarCodigo.TabIndex = 2;
            btnValidarCodigo.Text = "Validar Código";
            btnValidarCodigo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnValidarCodigo.UseAccentColor = false;
            btnValidarCodigo.UseVisualStyleBackColor = true;
            btnValidarCodigo.Click += btnValidarCodigo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 25);
            label2.Name = "label2";
            label2.Size = new Size(198, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese código de acceso";
            // 
            // txtCodigoEm
            // 
            // 
            // 
            // 
            txtCodigoEm.CustomButton.Image = null;
            txtCodigoEm.CustomButton.Location = new Point(142, 1);
            txtCodigoEm.CustomButton.Name = "";
            txtCodigoEm.CustomButton.Size = new Size(21, 21);
            txtCodigoEm.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtCodigoEm.CustomButton.TabIndex = 1;
            txtCodigoEm.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtCodigoEm.CustomButton.UseSelectable = true;
            txtCodigoEm.CustomButton.Visible = false;
            txtCodigoEm.Location = new Point(44, 69);
            txtCodigoEm.MaxLength = 32767;
            txtCodigoEm.Name = "txtCodigoEm";
            txtCodigoEm.PasswordChar = '\0';
            txtCodigoEm.ScrollBars = ScrollBars.None;
            txtCodigoEm.SelectedText = "";
            txtCodigoEm.SelectionLength = 0;
            txtCodigoEm.SelectionStart = 0;
            txtCodigoEm.ShortcutsEnabled = true;
            txtCodigoEm.Size = new Size(164, 23);
            txtCodigoEm.TabIndex = 0;
            txtCodigoEm.UseSelectable = true;
            txtCodigoEm.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtCodigoEm.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // btnEmpleado
            // 
            btnEmpleado.AutoSize = false;
            btnEmpleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmpleado.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEmpleado.Depth = 0;
            btnEmpleado.HighEmphasis = true;
            btnEmpleado.Icon = null;
            btnEmpleado.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEmpleado.Location = new Point(60, 245);
            btnEmpleado.Margin = new Padding(4, 6, 4, 6);
            btnEmpleado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.NoAccentTextColor = Color.Empty;
            btnEmpleado.Size = new Size(167, 36);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Soy Empleado";
            btnEmpleado.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEmpleado.UseAccentColor = false;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnCliente
            // 
            btnCliente.AutoSize = false;
            btnCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCliente.BackColor = Color.White;
            btnCliente.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCliente.Depth = 0;
            btnCliente.HighEmphasis = true;
            btnCliente.Icon = null;
            btnCliente.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCliente.Location = new Point(60, 178);
            btnCliente.Margin = new Padding(4, 6, 4, 6);
            btnCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCliente.Name = "btnCliente";
            btnCliente.NoAccentTextColor = Color.Empty;
            btnCliente.Size = new Size(167, 36);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Soy Cliente";
            btnCliente.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCliente.UseAccentColor = false;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 116);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 1;
            label1.Text = "Elegir Perfil";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-25, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormElegirPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(panelPrincipalOp);
            MaximizeBox = false;
            Name = "FormElegirPerfil";
            Text = "Elegir Perfil";
            panelPrincipalOp.ResumeLayout(false);
            panelPrincipalOp.PerformLayout();
            panelClave.ResumeLayout(false);
            panelClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard panelPrincipalOp;
        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnEmpleado;
        private ReaLTaiizor.Controls.MaterialButton btnCliente;
        private ReaLTaiizor.Controls.MaterialCard panelClave;
        private ReaLTaiizor.Controls.PoisonTextBox txtCodigoEm;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnValidarCodigo;
        private ReaLTaiizor.Controls.NightLinkLabel lblVolverLog;
    }
}