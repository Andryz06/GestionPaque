namespace Gestion_PaqTuristico
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            ctrlLogin = new ReaLTaiizor.Controls.MaterialCard();
            lblCrearCuen = new ReaLTaiizor.Controls.NightLinkLabel();
            lblOlvidoPass = new ReaLTaiizor.Controls.NightLinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnIniciar = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            chkRecordarme = new CheckBox();
            lblPassword = new Label();
            lblUsuario = new Label();
            txtPassword = new ReaLTaiizor.Controls.PoisonTextBox();
            txtUsuario = new ReaLTaiizor.Controls.PoisonTextBox();
            ctrlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlLogin
            // 
            ctrlLogin.BackColor = Color.FromArgb(255, 255, 255);
            ctrlLogin.BorderStyle = BorderStyle.FixedSingle;
            ctrlLogin.Controls.Add(lblCrearCuen);
            ctrlLogin.Controls.Add(lblOlvidoPass);
            ctrlLogin.Controls.Add(pictureBox3);
            ctrlLogin.Controls.Add(pictureBox2);
            ctrlLogin.Controls.Add(btnIniciar);
            ctrlLogin.Controls.Add(pictureBox1);
            ctrlLogin.Controls.Add(chkRecordarme);
            ctrlLogin.Controls.Add(lblPassword);
            ctrlLogin.Controls.Add(lblUsuario);
            ctrlLogin.Controls.Add(txtPassword);
            ctrlLogin.Controls.Add(txtUsuario);
            ctrlLogin.Depth = 0;
            ctrlLogin.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ctrlLogin.Location = new Point(313, 106);
            ctrlLogin.Margin = new Padding(14);
            ctrlLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ctrlLogin.Name = "ctrlLogin";
            ctrlLogin.Padding = new Padding(14);
            ctrlLogin.Size = new Size(326, 407);
            ctrlLogin.TabIndex = 0;
            ctrlLogin.Paint += ctrlLogin_Paint;
            // 
            // lblCrearCuen
            // 
            lblCrearCuen.ActiveLinkColor = Color.FromArgb(222, 89, 84);
            lblCrearCuen.AutoSize = true;
            lblCrearCuen.BackColor = Color.Transparent;
            lblCrearCuen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearCuen.LinkBehavior = LinkBehavior.HoverUnderline;
            lblCrearCuen.LinkColor = Color.RoyalBlue;
            lblCrearCuen.Location = new Point(52, 361);
            lblCrearCuen.Name = "lblCrearCuen";
            lblCrearCuen.Size = new Size(74, 15);
            lblCrearCuen.TabIndex = 10;
            lblCrearCuen.TabStop = true;
            lblCrearCuen.Text = "Crear Cuenta";
            lblCrearCuen.VisitedLinkColor = Color.IndianRed;
            lblCrearCuen.LinkClicked += nightLinkLabel2_LinkClicked;
            // 
            // lblOlvidoPass
            // 
            lblOlvidoPass.ActiveLinkColor = Color.BlueViolet;
            lblOlvidoPass.AutoSize = true;
            lblOlvidoPass.BackColor = Color.Transparent;
            lblOlvidoPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOlvidoPass.LinkBehavior = LinkBehavior.HoverUnderline;
            lblOlvidoPass.LinkColor = Color.RoyalBlue;
            lblOlvidoPass.Location = new Point(161, 361);
            lblOlvidoPass.Name = "lblOlvidoPass";
            lblOlvidoPass.Size = new Size(119, 15);
            lblOlvidoPass.TabIndex = 9;
            lblOlvidoPass.TabStop = true;
            lblOlvidoPass.Text = "Olvidé mi contraseña";
            lblOlvidoPass.VisitedLinkColor = Color.IndianRed;
            lblOlvidoPass.LinkClicked += nightLinkLabel1_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.contraseña;
            pictureBox3.Location = new Point(23, 262);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nombres;
            pictureBox2.Location = new Point(23, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.AutoSize = false;
            btnIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIniciar.Depth = 0;
            btnIniciar.HighEmphasis = true;
            btnIniciar.Icon = null;
            btnIniciar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnIniciar.Location = new Point(39, 319);
            btnIniciar.Margin = new Padding(4, 6, 4, 6);
            btnIniciar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnIniciar.Name = "btnIniciar";
            btnIniciar.NoAccentTextColor = Color.Empty;
            btnIniciar.Size = new Size(252, 36);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIniciar.UseAccentColor = false;
            btnIniciar.UseMnemonic = false;
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += materialButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-38, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // chkRecordarme
            // 
            chkRecordarme.AutoSize = true;
            chkRecordarme.Location = new Point(52, 291);
            chkRecordarme.Name = "chkRecordarme";
            chkRecordarme.Size = new Size(90, 19);
            chkRecordarme.TabIndex = 4;
            chkRecordarme.Text = "Recordarme";
            chkRecordarme.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(52, 244);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(52, 200);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(45, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Correo";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackgroundImageLayout = ImageLayout.Zoom;
            // 
            // 
            // 
            txtPassword.CustomButton.Image = null;
            txtPassword.CustomButton.Location = new Point(233, 1);
            txtPassword.CustomButton.Name = "";
            txtPassword.CustomButton.Size = new Size(21, 21);
            txtPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtPassword.CustomButton.TabIndex = 1;
            txtPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtPassword.CustomButton.UseSelectable = true;
            txtPassword.CustomButton.Visible = false;
            txtPassword.Location = new Point(52, 262);
            txtPassword.MaxLength = 32767;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(255, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSelectable = true;
            txtPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            txtUsuario.CustomButton.Image = null;
            txtUsuario.CustomButton.Location = new Point(233, 1);
            txtUsuario.CustomButton.Name = "";
            txtUsuario.CustomButton.Size = new Size(21, 21);
            txtUsuario.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtUsuario.CustomButton.TabIndex = 1;
            txtUsuario.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtUsuario.CustomButton.UseSelectable = true;
            txtUsuario.CustomButton.Visible = false;
            txtUsuario.Location = new Point(52, 218);
            txtUsuario.MaxLength = 32767;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.ScrollBars = ScrollBars.None;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(255, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.UseSelectable = true;
            txtUsuario.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtUsuario.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(ctrlLogin);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ctrlLogin.ResumeLayout(false);
            ctrlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard ctrlLogin;
        private ReaLTaiizor.Controls.PoisonTextBox txtPassword;
        private ReaLTaiizor.Controls.PoisonTextBox txtUsuario;
        private Label lblPassword;
        private Label lblUsuario;
        private CheckBox chkRecordarme;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialButton btnIniciar;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightLinkLabel lblOlvidoPass;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.NightLinkLabel lblCrearCuen;
    }
}
