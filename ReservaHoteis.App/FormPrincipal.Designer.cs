namespace ReservaHoteis.App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            btnSair = new ReaLTaiizor.Controls.HopeRoundButton();
            txtNome = new TextBox();
            Perfil_Foto = new Panel();
            Perfil_Mask = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnHotel = new ReaLTaiizor.Controls.Button();
            panelHotel = new Panel();
            button2 = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            button3 = new ReaLTaiizor.Controls.Button();
            panel1.SuspendLayout();
            Perfil_Foto.SuspendLayout();
            panelHotel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 102, 173);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(Perfil_Foto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 567);
            panel1.TabIndex = 2;
            // 
            // btnSair
            // 
            btnSair.BorderColor = Color.FromArgb(220, 223, 230);
            btnSair.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            btnSair.DangerColor = Color.FromArgb(245, 108, 108);
            btnSair.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSair.InfoColor = Color.FromArgb(144, 147, 153);
            btnSair.Location = new Point(234, 141);
            btnSair.Name = "btnSair";
            btnSair.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSair.Size = new Size(81, 40);
            btnSair.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.TextColor = Color.White;
            btnSair.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(7, 102, 173);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.FromArgb(243, 243, 243);
            txtNome.Location = new Point(225, 86);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 28);
            txtNome.TabIndex = 2;
            txtNome.Text = "Login Usuário";
            // 
            // Perfil_Foto
            // 
            Perfil_Foto.BackColor = Color.White;
            Perfil_Foto.BackgroundImage = (Image)resources.GetObject("Perfil_Foto.BackgroundImage");
            Perfil_Foto.BackgroundImageLayout = ImageLayout.Stretch;
            Perfil_Foto.Controls.Add(Perfil_Mask);
            Perfil_Foto.Location = new Point(34, 26);
            Perfil_Foto.Name = "Perfil_Foto";
            Perfil_Foto.Size = new Size(194, 194);
            Perfil_Foto.TabIndex = 0;
            // 
            // Perfil_Mask
            // 
            Perfil_Mask.BackColor = Color.Transparent;
            Perfil_Mask.BackgroundImage = Properties.Resources.Perfil_Mask;
            Perfil_Mask.BackgroundImageLayout = ImageLayout.Zoom;
            Perfil_Mask.ColorLeft = Color.DodgerBlue;
            Perfil_Mask.ColorRight = Color.DodgerBlue;
            Perfil_Mask.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Perfil_Mask.FilterAlpha = 200;
            Perfil_Mask.FilterEnabled = true;
            Perfil_Mask.Image = null;
            Perfil_Mask.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            Perfil_Mask.IsElipse = false;
            Perfil_Mask.IsParallax = false;
            Perfil_Mask.Location = new Point(0, 0);
            Perfil_Mask.Name = "Perfil_Mask";
            Perfil_Mask.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Perfil_Mask.Size = new Size(194, 194);
            Perfil_Mask.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Perfil_Mask.TabIndex = 1;
            Perfil_Mask.Text = "parrotPictureBox1";
            Perfil_Mask.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnHotel
            // 
            btnHotel.BackColor = Color.Transparent;
            btnHotel.BorderColor = Color.FromArgb(220, 223, 230);
            btnHotel.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnHotel.EnteredColor = Color.DimGray;
            btnHotel.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHotel.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnHotel.ImageAlign = ContentAlignment.MiddleLeft;
            btnHotel.InactiveColor = Color.FromArgb(243, 243, 243);
            btnHotel.Location = new Point(80, 107);
            btnHotel.Name = "btnHotel";
            btnHotel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnHotel.PressedColor = Color.FromArgb(165, 37, 37);
            btnHotel.Size = new Size(300, 74);
            btnHotel.TabIndex = 8;
            btnHotel.Text = "Hoteis";
            btnHotel.TextAlignment = StringAlignment.Center;
            // 
            // panelHotel
            // 
            panelHotel.BackColor = Color.FromArgb(243, 243, 243);
            panelHotel.BackgroundImage = Properties.Resources.login_background;
            panelHotel.Controls.Add(button3);
            panelHotel.Controls.Add(button2);
            panelHotel.Controls.Add(button1);
            panelHotel.Controls.Add(btnHotel);
            panelHotel.Dock = DockStyle.Right;
            panelHotel.Location = new Point(468, 0);
            panelHotel.Name = "panelHotel";
            panelHotel.Size = new Size(468, 567);
            panelHotel.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(220, 223, 230);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.DimGray;
            button2.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.BuscarHotel_btnIcon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(243, 243, 243);
            button2.Location = new Point(80, 326);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(300, 74);
            button2.TabIndex = 10;
            button2.Text = "Contratos";
            button2.TextAlignment = StringAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(220, 223, 230);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.DimGray;
            button1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.BuscarHotel_btnIcon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(243, 243, 243);
            button1.Location = new Point(80, 213);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(300, 74);
            button1.TabIndex = 9;
            button1.Text = "Clientes";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BorderColor = Color.FromArgb(220, 223, 230);
            button3.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button3.EnteredColor = Color.DimGray;
            button3.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.BuscarHotel_btnIcon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.InactiveColor = Color.FromArgb(243, 243, 243);
            button3.Location = new Point(80, 429);
            button3.Name = "button3";
            button3.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button3.PressedColor = Color.FromArgb(165, 37, 37);
            button3.Size = new Size(300, 74);
            button3.TabIndex = 11;
            button3.Text = "Avaliação";
            button3.TextAlignment = StringAlignment.Center;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 102, 173);
            ClientSize = new Size(936, 567);
            Controls.Add(panel1);
            Controls.Add(panelHotel);
            IsMdiContainer = true;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Perfil_Foto.ResumeLayout(false);
            panelHotel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnSair;
        private TextBox txtNome;
        private Panel Perfil_Foto;
        private ReaLTaiizor.Controls.ParrotPictureBox Perfil_Mask;
        private ReaLTaiizor.Controls.Button btnHotel;
        private Panel panelHotel;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button3;
    }
}
