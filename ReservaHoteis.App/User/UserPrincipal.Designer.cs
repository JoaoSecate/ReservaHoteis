namespace ReservaHoteis.App.User
{
    partial class UserPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPrincipal));
            panel1 = new Panel();
            btnBuscar = new ReaLTaiizor.Controls.Button();
            btnSair = new ReaLTaiizor.Controls.HopeRoundButton();
            btnEditarPerfil = new ReaLTaiizor.Controls.HopeRoundButton();
            txtNome = new TextBox();
            txtLogin = new TextBox();
            Perfil_Foto = new Panel();
            Perfil_Mask = new ReaLTaiizor.Controls.ParrotPictureBox();
            panelHotel = new Panel();
            textBox1 = new TextBox();
            txtCidadeHotel = new TextBox();
            txtNomeHotel = new TextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Cad_btnConf = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1.SuspendLayout();
            Perfil_Foto.SuspendLayout();
            panelHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 102, 173);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnEditarPerfil);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(Perfil_Foto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 567);
            panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BorderColor = Color.FromArgb(220, 223, 230);
            btnBuscar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnBuscar.EnteredColor = Color.DimGray;
            btnBuscar.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Image = Properties.Resources.BuscarHotel_btnIcon;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.InactiveColor = Color.FromArgb(243, 243, 243);
            btnBuscar.Location = new Point(75, 412);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnBuscar.PressedColor = Color.FromArgb(165, 37, 37);
            btnBuscar.Size = new Size(300, 74);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar Hoteis";
            btnBuscar.TextAlignment = StringAlignment.Center;
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
            btnSair.Location = new Point(360, 143);
            btnSair.Name = "btnSair";
            btnSair.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSair.Size = new Size(81, 40);
            btnSair.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.TextColor = Color.White;
            btnSair.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BorderColor = Color.FromArgb(220, 223, 230);
            btnEditarPerfil.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEditarPerfil.DangerColor = Color.FromArgb(245, 108, 108);
            btnEditarPerfil.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEditarPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarPerfil.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEditarPerfil.InfoColor = Color.FromArgb(144, 147, 153);
            btnEditarPerfil.Location = new Point(225, 143);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnEditarPerfil.Size = new Size(129, 40);
            btnEditarPerfil.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEditarPerfil.TabIndex = 6;
            btnEditarPerfil.Text = "Editar Perfil";
            btnEditarPerfil.TextColor = Color.White;
            btnEditarPerfil.WarningColor = Color.FromArgb(230, 162, 60);
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
            txtNome.Text = "Nome de Usuário";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(7, 102, 173);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.FromArgb(154, 154, 154);
            txtLogin.Location = new Point(234, 111);
            txtLogin.Name = "txtLogin";
            txtLogin.ReadOnly = true;
            txtLogin.Size = new Size(165, 16);
            txtLogin.TabIndex = 1;
            txtLogin.Text = "Login de Usuário";
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
            // panelHotel
            // 
            panelHotel.BackColor = Color.FromArgb(243, 243, 243);
            panelHotel.Controls.Add(Cad_btnConf);
            panelHotel.Controls.Add(textBox3);
            panelHotel.Controls.Add(textBox2);
            panelHotel.Controls.Add(textBox1);
            panelHotel.Controls.Add(txtCidadeHotel);
            panelHotel.Controls.Add(txtNomeHotel);
            panelHotel.Controls.Add(hopePictureBox1);
            panelHotel.Dock = DockStyle.Right;
            panelHotel.Location = new Point(483, 0);
            panelHotel.Name = "panelHotel";
            panelHotel.Size = new Size(453, 567);
            panelHotel.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(243, 243, 243);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(28, 28, 28);
            textBox1.Location = new Point(55, 363);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 32);
            textBox1.TabIndex = 5;
            textBox1.Text = "Total:   R$";
            // 
            // txtCidadeHotel
            // 
            txtCidadeHotel.BackColor = Color.FromArgb(243, 243, 243);
            txtCidadeHotel.BorderStyle = BorderStyle.None;
            txtCidadeHotel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCidadeHotel.ForeColor = Color.FromArgb(64, 64, 64);
            txtCidadeHotel.Location = new Point(36, 311);
            txtCidadeHotel.Name = "txtCidadeHotel";
            txtCidadeHotel.ReadOnly = true;
            txtCidadeHotel.Size = new Size(165, 20);
            txtCidadeHotel.TabIndex = 4;
            txtCidadeHotel.Text = "Cidade - SP";
            // 
            // txtNomeHotel
            // 
            txtNomeHotel.BackColor = Color.FromArgb(243, 243, 243);
            txtNomeHotel.BorderStyle = BorderStyle.None;
            txtNomeHotel.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeHotel.ForeColor = Color.FromArgb(28, 28, 28);
            txtNomeHotel.Location = new Point(27, 277);
            txtNomeHotel.Name = "txtNomeHotel";
            txtNomeHotel.Size = new Size(195, 37);
            txtNomeHotel.TabIndex = 3;
            txtNomeHotel.Text = "Nome do Hotel";
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.BackgroundImageLayout = ImageLayout.None;
            hopePictureBox1.BorderStyle = BorderStyle.FixedSingle;
            hopePictureBox1.Image = Properties.Resources.login_background;
            hopePictureBox1.Location = new Point(3, 0);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(447, 271);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(243, 243, 243);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(28, 28, 28);
            textBox2.Location = new Point(151, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 32);
            textBox2.TabIndex = 6;
            textBox2.Text = "0,00";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(243, 243, 243);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(28, 28, 28);
            textBox3.Location = new Point(151, 363);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 32);
            textBox3.TabIndex = 6;
            textBox3.Text = "0,00";
            // 
            // Cad_btnConf
            // 
            Cad_btnConf.BorderColor = Color.FromArgb(220, 223, 230);
            Cad_btnConf.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            Cad_btnConf.DangerColor = Color.FromArgb(245, 108, 108);
            Cad_btnConf.DefaultColor = Color.FromArgb(255, 255, 255);
            Cad_btnConf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_btnConf.HoverTextColor = Color.FromArgb(48, 49, 51);
            Cad_btnConf.InfoColor = Color.FromArgb(144, 147, 153);
            Cad_btnConf.Location = new Point(164, 428);
            Cad_btnConf.Name = "Cad_btnConf";
            Cad_btnConf.PrimaryColor = Color.FromArgb(64, 158, 255);
            Cad_btnConf.Size = new Size(137, 40);
            Cad_btnConf.SuccessColor = Color.FromArgb(41, 173, 178);
            Cad_btnConf.TabIndex = 7;
            Cad_btnConf.Text = "Gerenciar";
            Cad_btnConf.TextColor = Color.White;
            Cad_btnConf.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // UserPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(936, 567);
            Controls.Add(panelHotel);
            Controls.Add(panel1);
            Name = "UserPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Perfil_Foto.ResumeLayout(false);
            panelHotel.ResumeLayout(false);
            panelHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelHotel;
        private ReaLTaiizor.Controls.ParrotPictureBox Perfil_Pic;
        private ReaLTaiizor.Controls.ParrotPictureBox Perfil_Mask;
        private Panel Perfil_Foto;
        private TextBox txtLogin;
        private TextBox txtNome;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditarPerfil;
        private ReaLTaiizor.Controls.HopeRoundButton btnSair;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private TextBox txtCidadeHotel;
        private TextBox txtNomeHotel;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ReaLTaiizor.Controls.HopeRoundButton Cad_btnConf;
    }
}