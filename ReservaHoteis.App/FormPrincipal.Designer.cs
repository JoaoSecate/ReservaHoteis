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
            btnContratos = new ReaLTaiizor.Controls.Button();
            txtNome = new TextBox();
            btnClientes = new ReaLTaiizor.Controls.Button();
            Perfil_Foto = new Panel();
            Perfil_Mask = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnAvaliações = new ReaLTaiizor.Controls.Button();
            btnCidades = new ReaLTaiizor.Controls.Button();
            panelHotel = new Panel();
            btnHoteis = new ReaLTaiizor.Controls.Button();
            panel1.SuspendLayout();
            Perfil_Foto.SuspendLayout();
            panelHotel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 102, 173);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnContratos);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnClientes);
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
            btnSair.Click += btnSair_Click;
            // 
            // btnContratos
            // 
            btnContratos.BackColor = Color.Transparent;
            btnContratos.BorderColor = Color.FromArgb(220, 223, 230);
            btnContratos.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnContratos.EnteredColor = Color.FromArgb(41, 173, 178);
            btnContratos.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContratos.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnContratos.ImageAlign = ContentAlignment.MiddleLeft;
            btnContratos.InactiveColor = Color.FromArgb(41, 173, 178);
            btnContratos.Location = new Point(48, 444);
            btnContratos.Name = "btnContratos";
            btnContratos.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnContratos.PressedColor = Color.FromArgb(165, 37, 37);
            btnContratos.Size = new Size(300, 74);
            btnContratos.TabIndex = 10;
            btnContratos.Text = "Contratos";
            btnContratos.TextAlignment = StringAlignment.Center;
            btnContratos.Click += btnContratos_Click;
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
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.BorderColor = Color.FromArgb(220, 223, 230);
            btnClientes.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnClientes.EnteredColor = Color.FromArgb(41, 173, 178);
            btnClientes.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.InactiveColor = Color.FromArgb(41, 173, 178);
            btnClientes.Location = new Point(48, 302);
            btnClientes.Name = "btnClientes";
            btnClientes.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnClientes.PressedColor = Color.FromArgb(165, 37, 37);
            btnClientes.Size = new Size(300, 74);
            btnClientes.TabIndex = 9;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlignment = StringAlignment.Center;
            btnClientes.Click += btnClientes_Click;
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
            // btnAvaliações
            // 
            btnAvaliações.BackColor = Color.Transparent;
            btnAvaliações.BorderColor = Color.FromArgb(220, 223, 230);
            btnAvaliações.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnAvaliações.EnteredColor = Color.FromArgb(41, 173, 178);
            btnAvaliações.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvaliações.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnAvaliações.ImageAlign = ContentAlignment.MiddleLeft;
            btnAvaliações.InactiveColor = Color.FromArgb(41, 173, 178);
            btnAvaliações.Location = new Point(91, 166);
            btnAvaliações.Name = "btnAvaliações";
            btnAvaliações.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnAvaliações.PressedColor = Color.FromArgb(165, 37, 37);
            btnAvaliações.Size = new Size(300, 74);
            btnAvaliações.TabIndex = 11;
            btnAvaliações.Text = "Avaliações";
            btnAvaliações.TextAlignment = StringAlignment.Center;
            btnAvaliações.Click += btnAvaliações_Click;
            // 
            // btnCidades
            // 
            btnCidades.BackColor = Color.Transparent;
            btnCidades.BorderColor = Color.FromArgb(220, 223, 230);
            btnCidades.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCidades.EnteredColor = Color.FromArgb(41, 173, 178);
            btnCidades.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCidades.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnCidades.ImageAlign = ContentAlignment.MiddleLeft;
            btnCidades.InactiveColor = Color.FromArgb(41, 173, 178);
            btnCidades.Location = new Point(91, 444);
            btnCidades.Name = "btnCidades";
            btnCidades.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCidades.PressedColor = Color.FromArgb(165, 37, 37);
            btnCidades.Size = new Size(300, 74);
            btnCidades.TabIndex = 8;
            btnCidades.Text = "Localizações";
            btnCidades.TextAlignment = StringAlignment.Center;
            btnCidades.Click += btnCidades_Click;
            // 
            // panelHotel
            // 
            panelHotel.BackColor = Color.FromArgb(243, 243, 243);
            panelHotel.BackgroundImage = Properties.Resources.login_background;
            panelHotel.Controls.Add(btnAvaliações);
            panelHotel.Controls.Add(btnHoteis);
            panelHotel.Controls.Add(btnCidades);
            panelHotel.Dock = DockStyle.Right;
            panelHotel.Location = new Point(468, 0);
            panelHotel.Name = "panelHotel";
            panelHotel.Size = new Size(468, 567);
            panelHotel.TabIndex = 3;
            // 
            // btnHoteis
            // 
            btnHoteis.BackColor = Color.Transparent;
            btnHoteis.BorderColor = Color.FromArgb(220, 223, 230);
            btnHoteis.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnHoteis.EnteredColor = Color.FromArgb(41, 173, 178);
            btnHoteis.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoteis.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnHoteis.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoteis.InactiveColor = Color.FromArgb(41, 173, 178);
            btnHoteis.Location = new Point(91, 302);
            btnHoteis.Name = "btnHoteis";
            btnHoteis.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnHoteis.PressedColor = Color.FromArgb(165, 37, 37);
            btnHoteis.Size = new Size(300, 74);
            btnHoteis.TabIndex = 9;
            btnHoteis.Text = "Hoteis";
            btnHoteis.TextAlignment = StringAlignment.Center;
            btnHoteis.Click += btnHoteis_Click;
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
        private ReaLTaiizor.Controls.Button btnCidades;
        private Panel panelHotel;
        private ReaLTaiizor.Controls.Button btnContratos;
        private ReaLTaiizor.Controls.Button btnClientes;
        private ReaLTaiizor.Controls.Button btnAvaliações;
        private ReaLTaiizor.Controls.Button btnHoteis;
    }
}
