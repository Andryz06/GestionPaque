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
            picDestino = new PictureBox();
            lblTituloDestino = new Label();
            lblDescripcion = new Label();
            lblPromociones = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDestino).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblPromociones);
            materialCard1.Controls.Add(lblDescripcion);
            materialCard1.Controls.Add(lblTituloDestino);
            materialCard1.Controls.Add(picDestino);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(46, 23);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(864, 552);
            materialCard1.TabIndex = 0;
            // 
            // picDestino
            // 
            picDestino.Location = new Point(17, 17);
            picDestino.Name = "picDestino";
            picDestino.Size = new Size(216, 192);
            picDestino.TabIndex = 0;
            picDestino.TabStop = false;
            // 
            // lblTituloDestino
            // 
            lblTituloDestino.AutoSize = true;
            lblTituloDestino.Location = new Point(17, 230);
            lblTituloDestino.Name = "lblTituloDestino";
            lblTituloDestino.Size = new Size(38, 15);
            lblTituloDestino.TabIndex = 1;
            lblTituloDestino.Text = "label1";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(17, 254);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(38, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "label1";
            // 
            // lblPromociones
            // 
            lblPromociones.AutoSize = true;
            lblPromociones.Location = new Point(315, 17);
            lblPromociones.Name = "lblPromociones";
            lblPromociones.Size = new Size(38, 15);
            lblPromociones.TabIndex = 3;
            lblPromociones.Text = "label1";
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 606);
            Controls.Add(materialCard1);
            Name = "FormReservas";
            Text = "FormReservas";
            Load += FormReservas_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDestino).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label lblPromociones;
        private Label lblDescripcion;
        private Label lblTituloDestino;
        private PictureBox picDestino;
    }
}