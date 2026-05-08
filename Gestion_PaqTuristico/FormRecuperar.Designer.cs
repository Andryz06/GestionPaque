namespace Gestion_PaqTuristico
{
    partial class FormRecuperar
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
            ctrlOlvidoPass = new ReaLTaiizor.Controls.MaterialCard();
            panel2_Codigo = new ReaLTaiizor.Controls.MaterialCard();
            panel3_NuevaContra = new ReaLTaiizor.Controls.MaterialCard();
            txtConfirmarContra = new ReaLTaiizor.Controls.PoisonTextBox();
            txtNuevaContra = new ReaLTaiizor.Controls.PoisonTextBox();
            lblConfirmar = new ReaLTaiizor.Controls.NightLabel();
            nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            lblIngresePass = new ReaLTaiizor.Controls.NightLabel();
            btnGuardarContra = new ReaLTaiizor.Controls.MaterialButton();
            txtCode = new ReaLTaiizor.Controls.PoisonTextBox();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            btnValidar = new ReaLTaiizor.Controls.MaterialButton();
            lblInformacion = new ReaLTaiizor.Controls.NightLabel();
            lblRecuperarPass = new ReaLTaiizor.Controls.NightLabel();
            lblVolver = new ReaLTaiizor.Controls.NightLinkLabel();
            btnEnviarCodigo = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            txtCorreoOlv = new ReaLTaiizor.Controls.PoisonTextBox();
            ctrlOlvidoPass.SuspendLayout();
            panel2_Codigo.SuspendLayout();
            panel3_NuevaContra.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlOlvidoPass
            // 
            ctrlOlvidoPass.BackColor = Color.FromArgb(255, 255, 255);
            ctrlOlvidoPass.Controls.Add(panel2_Codigo);
            ctrlOlvidoPass.Controls.Add(lblInformacion);
            ctrlOlvidoPass.Controls.Add(lblRecuperarPass);
            ctrlOlvidoPass.Controls.Add(lblVolver);
            ctrlOlvidoPass.Controls.Add(btnEnviarCodigo);
            ctrlOlvidoPass.Controls.Add(label1);
            ctrlOlvidoPass.Controls.Add(txtCorreoOlv);
            ctrlOlvidoPass.Depth = 0;
            ctrlOlvidoPass.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ctrlOlvidoPass.Location = new Point(358, 167);
            ctrlOlvidoPass.Margin = new Padding(14);
            ctrlOlvidoPass.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ctrlOlvidoPass.Name = "ctrlOlvidoPass";
            ctrlOlvidoPass.Padding = new Padding(14);
            ctrlOlvidoPass.Size = new Size(269, 224);
            ctrlOlvidoPass.TabIndex = 1;
            // 
            // panel2_Codigo
            // 
            panel2_Codigo.BackColor = Color.FromArgb(255, 255, 255);
            panel2_Codigo.Controls.Add(txtCode);
            panel2_Codigo.Controls.Add(nightLabel2);
            panel2_Codigo.Controls.Add(nightLabel1);
            panel2_Codigo.Controls.Add(btnValidar);
            panel2_Codigo.Depth = 0;
            panel2_Codigo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2_Codigo.Location = new Point(0, 0);
            panel2_Codigo.Margin = new Padding(14);
            panel2_Codigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panel2_Codigo.Name = "panel2_Codigo";
            panel2_Codigo.Padding = new Padding(14);
            panel2_Codigo.Size = new Size(269, 224);
            panel2_Codigo.TabIndex = 7;
            // 
            // panel3_NuevaContra
            // 
            panel3_NuevaContra.BackColor = Color.FromArgb(255, 255, 255);
            panel3_NuevaContra.Controls.Add(txtConfirmarContra);
            panel3_NuevaContra.Controls.Add(txtNuevaContra);
            panel3_NuevaContra.Controls.Add(lblConfirmar);
            panel3_NuevaContra.Controls.Add(nightLabel4);
            panel3_NuevaContra.Controls.Add(lblIngresePass);
            panel3_NuevaContra.Controls.Add(btnGuardarContra);
            panel3_NuevaContra.Depth = 0;
            panel3_NuevaContra.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel3_NuevaContra.Location = new Point(358, 167);
            panel3_NuevaContra.Margin = new Padding(14);
            panel3_NuevaContra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panel3_NuevaContra.Name = "panel3_NuevaContra";
            panel3_NuevaContra.Padding = new Padding(14);
            panel3_NuevaContra.Size = new Size(269, 224);
            panel3_NuevaContra.TabIndex = 8;
            // 
            // txtConfirmarContra
            // 
            // 
            // 
            // 
            txtConfirmarContra.CustomButton.Image = null;
            txtConfirmarContra.CustomButton.Location = new Point(187, 1);
            txtConfirmarContra.CustomButton.Name = "";
            txtConfirmarContra.CustomButton.Size = new Size(21, 21);
            txtConfirmarContra.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtConfirmarContra.CustomButton.TabIndex = 1;
            txtConfirmarContra.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtConfirmarContra.CustomButton.UseSelectable = true;
            txtConfirmarContra.CustomButton.Visible = false;
            txtConfirmarContra.Location = new Point(37, 135);
            txtConfirmarContra.MaxLength = 32767;
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.PasswordChar = '\0';
            txtConfirmarContra.ScrollBars = ScrollBars.None;
            txtConfirmarContra.SelectedText = "";
            txtConfirmarContra.SelectionLength = 0;
            txtConfirmarContra.SelectionStart = 0;
            txtConfirmarContra.ShortcutsEnabled = true;
            txtConfirmarContra.Size = new Size(209, 23);
            txtConfirmarContra.TabIndex = 22;
            txtConfirmarContra.UseSelectable = true;
            txtConfirmarContra.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtConfirmarContra.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // txtNuevaContra
            // 
            // 
            // 
            // 
            txtNuevaContra.CustomButton.Image = null;
            txtNuevaContra.CustomButton.Location = new Point(187, 1);
            txtNuevaContra.CustomButton.Name = "";
            txtNuevaContra.CustomButton.Size = new Size(21, 21);
            txtNuevaContra.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtNuevaContra.CustomButton.TabIndex = 1;
            txtNuevaContra.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtNuevaContra.CustomButton.UseSelectable = true;
            txtNuevaContra.CustomButton.Visible = false;
            txtNuevaContra.Location = new Point(37, 86);
            txtNuevaContra.MaxLength = 32767;
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.PasswordChar = '\0';
            txtNuevaContra.ScrollBars = ScrollBars.None;
            txtNuevaContra.SelectedText = "";
            txtNuevaContra.SelectionLength = 0;
            txtNuevaContra.SelectionStart = 0;
            txtNuevaContra.ShortcutsEnabled = true;
            txtNuevaContra.Size = new Size(209, 23);
            txtNuevaContra.TabIndex = 21;
            txtNuevaContra.UseSelectable = true;
            txtNuevaContra.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtNuevaContra.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.BackColor = Color.Transparent;
            lblConfirmar.Font = new Font("Segoe UI", 9F);
            lblConfirmar.ForeColor = Color.Black;
            lblConfirmar.Location = new Point(26, 117);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(120, 15);
            lblConfirmar.TabIndex = 20;
            lblConfirmar.Text = "Confirmar Contaseña";
            // 
            // nightLabel4
            // 
            nightLabel4.AutoSize = true;
            nightLabel4.BackColor = Color.Transparent;
            nightLabel4.Font = new Font("Segoe UI", 9F);
            nightLabel4.ForeColor = Color.Black;
            nightLabel4.Location = new Point(26, 66);
            nightLabel4.Name = "nightLabel4";
            nightLabel4.Size = new Size(100, 15);
            nightLabel4.TabIndex = 18;
            nightLabel4.Text = "Nueva Contaseña";
            // 
            // lblIngresePass
            // 
            lblIngresePass.AutoSize = true;
            lblIngresePass.BackColor = Color.Transparent;
            lblIngresePass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresePass.ForeColor = Color.Black;
            lblIngresePass.Location = new Point(37, 30);
            lblIngresePass.Name = "lblIngresePass";
            lblIngresePass.Size = new Size(189, 17);
            lblIngresePass.TabIndex = 17;
            lblIngresePass.Text = "Ingrese su nueva Contraseña ";
            // 
            // btnGuardarContra
            // 
            btnGuardarContra.AutoSize = false;
            btnGuardarContra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarContra.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarContra.Depth = 0;
            btnGuardarContra.HighEmphasis = true;
            btnGuardarContra.Icon = null;
            btnGuardarContra.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGuardarContra.Location = new Point(37, 164);
            btnGuardarContra.Margin = new Padding(4, 6, 4, 6);
            btnGuardarContra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardarContra.Name = "btnGuardarContra";
            btnGuardarContra.NoAccentTextColor = Color.Empty;
            btnGuardarContra.Size = new Size(196, 28);
            btnGuardarContra.TabIndex = 16;
            btnGuardarContra.Text = "Guardar Contraseña";
            btnGuardarContra.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarContra.UseAccentColor = false;
            btnGuardarContra.UseVisualStyleBackColor = true;
            btnGuardarContra.Click += btnGuardarContra_Click;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            txtCode.CustomButton.Image = null;
            txtCode.CustomButton.Location = new Point(145, 1);
            txtCode.CustomButton.Name = "";
            txtCode.CustomButton.Size = new Size(21, 21);
            txtCode.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtCode.CustomButton.TabIndex = 1;
            txtCode.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtCode.CustomButton.UseSelectable = true;
            txtCode.CustomButton.Visible = false;
            txtCode.Location = new Point(49, 107);
            txtCode.MaxLength = 32767;
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '\0';
            txtCode.ScrollBars = ScrollBars.None;
            txtCode.SelectedText = "";
            txtCode.SelectionLength = 0;
            txtCode.SelectionStart = 0;
            txtCode.ShortcutsEnabled = true;
            txtCode.Size = new Size(167, 23);
            txtCode.TabIndex = 18;
            txtCode.UseSelectable = true;
            txtCode.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtCode.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 9F);
            nightLabel2.ForeColor = Color.Black;
            nightLabel2.Location = new Point(37, 89);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(46, 15);
            nightLabel2.TabIndex = 17;
            nightLabel2.Text = "Código";
            // 
            // nightLabel1
            // 
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel1.ForeColor = Color.Black;
            nightLabel1.Location = new Point(37, 39);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(197, 38);
            nightLabel1.TabIndex = 16;
            nightLabel1.Text = "Hemos enviado un código de           6 digitos a tu correo";
            // 
            // btnValidar
            // 
            btnValidar.AutoSize = false;
            btnValidar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnValidar.Depth = 0;
            btnValidar.HighEmphasis = true;
            btnValidar.Icon = null;
            btnValidar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnValidar.Location = new Point(49, 145);
            btnValidar.Margin = new Padding(4, 6, 4, 6);
            btnValidar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnValidar.Name = "btnValidar";
            btnValidar.NoAccentTextColor = Color.Empty;
            btnValidar.Size = new Size(167, 28);
            btnValidar.TabIndex = 15;
            btnValidar.Text = "Validar Código";
            btnValidar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnValidar.UseAccentColor = false;
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblInformacion
            // 
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Segoe UI", 9F);
            lblInformacion.ForeColor = Color.Black;
            lblInformacion.Location = new Point(17, 50);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(235, 48);
            lblInformacion.TabIndex = 17;
            lblInformacion.Text = "Ingrese su correo registrado para recibir un                     código de seguridad";
            // 
            // lblRecuperarPass
            // 
            lblRecuperarPass.AutoSize = true;
            lblRecuperarPass.BackColor = Color.Transparent;
            lblRecuperarPass.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecuperarPass.ForeColor = Color.Black;
            lblRecuperarPass.Location = new Point(26, 20);
            lblRecuperarPass.Name = "lblRecuperarPass";
            lblRecuperarPass.Size = new Size(223, 30);
            lblRecuperarPass.TabIndex = 16;
            lblRecuperarPass.Text = "Recuperar Contraseña";
            // 
            // lblVolver
            // 
            lblVolver.ActiveLinkColor = Color.FromArgb(222, 89, 84);
            lblVolver.AutoSize = true;
            lblVolver.BackColor = Color.Transparent;
            lblVolver.Font = new Font("Segoe UI", 9F);
            lblVolver.LinkBehavior = LinkBehavior.HoverUnderline;
            lblVolver.LinkColor = Color.RoyalBlue;
            lblVolver.Location = new Point(89, 189);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new Size(84, 15);
            lblVolver.TabIndex = 15;
            lblVolver.TabStop = true;
            lblVolver.Text = "Volver al Login";
            lblVolver.VisitedLinkColor = Color.FromArgb(254, 89, 84);
            lblVolver.LinkClicked += lblVolver_LinkClicked;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.AutoSize = false;
            btnEnviarCodigo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnviarCodigo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEnviarCodigo.Depth = 0;
            btnEnviarCodigo.HighEmphasis = true;
            btnEnviarCodigo.Icon = null;
            btnEnviarCodigo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEnviarCodigo.Location = new Point(49, 146);
            btnEnviarCodigo.Margin = new Padding(4, 6, 4, 6);
            btnEnviarCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.NoAccentTextColor = Color.Empty;
            btnEnviarCodigo.Size = new Size(167, 28);
            btnEnviarCodigo.TabIndex = 14;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEnviarCodigo.UseAccentColor = false;
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(37, 98);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 13;
            label1.Text = "Correo Electrónico";
            // 
            // txtCorreoOlv
            // 
            // 
            // 
            // 
            txtCorreoOlv.CustomButton.Image = null;
            txtCorreoOlv.CustomButton.Location = new Point(177, 1);
            txtCorreoOlv.CustomButton.Name = "";
            txtCorreoOlv.CustomButton.Size = new Size(21, 21);
            txtCorreoOlv.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtCorreoOlv.CustomButton.TabIndex = 1;
            txtCorreoOlv.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtCorreoOlv.CustomButton.UseSelectable = true;
            txtCorreoOlv.CustomButton.Visible = false;
            txtCorreoOlv.Location = new Point(26, 116);
            txtCorreoOlv.MaxLength = 32767;
            txtCorreoOlv.Name = "txtCorreoOlv";
            txtCorreoOlv.PasswordChar = '\0';
            txtCorreoOlv.ScrollBars = ScrollBars.None;
            txtCorreoOlv.SelectedText = "";
            txtCorreoOlv.SelectionLength = 0;
            txtCorreoOlv.SelectionStart = 0;
            txtCorreoOlv.ShortcutsEnabled = true;
            txtCorreoOlv.Size = new Size(199, 23);
            txtCorreoOlv.TabIndex = 18;
            txtCorreoOlv.UseSelectable = true;
            txtCorreoOlv.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtCorreoOlv.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // FormRecuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(panel3_NuevaContra);
            Controls.Add(ctrlOlvidoPass);
            Name = "FormRecuperar";
            Text = "FormRecuperar";
            Load += FormRecuperar_Load;
            ctrlOlvidoPass.ResumeLayout(false);
            ctrlOlvidoPass.PerformLayout();
            panel2_Codigo.ResumeLayout(false);
            panel2_Codigo.PerformLayout();
            panel3_NuevaContra.ResumeLayout(false);
            panel3_NuevaContra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard ctrlOlvidoPass;
        private ReaLTaiizor.Controls.NightLabel lblInformacion;
        private ReaLTaiizor.Controls.NightLabel lblRecuperarPass;
        private ReaLTaiizor.Controls.NightLinkLabel lblVolver;
        private ReaLTaiizor.Controls.MaterialButton btnEnviarCodigo;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialCard panel2_Codigo;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.MaterialButton btnValidar;
        private ReaLTaiizor.Controls.FoxTextBox txtCodigo;
        private ReaLTaiizor.Controls.MaterialCard panel3_NuevaContra;
        private ReaLTaiizor.Controls.NightLabel lblConfirmar;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private ReaLTaiizor.Controls.NightLabel lblIngresePass;
        private ReaLTaiizor.Controls.MaterialButton btnGuardarContra;
        private ReaLTaiizor.Controls.PoisonTextBox poisonTextBox1;
        private ReaLTaiizor.Controls.PoisonTextBox txtCode;
        private ReaLTaiizor.Controls.PoisonTextBox txtConfirmarContra;
        private ReaLTaiizor.Controls.PoisonTextBox txtNuevaContra;
        private ReaLTaiizor.Controls.PoisonTextBox txtCorreoOlv;
    }
}