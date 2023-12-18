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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnContratos = new ReaLTaiizor.Controls.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnClientes = new ReaLTaiizor.Controls.Button();
            this.Perfil_Foto = new System.Windows.Forms.Panel();
            this.Perfil_Mask = new ReaLTaiizor.Controls.ParrotPictureBox();
            this.btnAvaliações = new ReaLTaiizor.Controls.Button();
            this.btnCidades = new ReaLTaiizor.Controls.Button();
            this.panelHotel = new System.Windows.Forms.Panel();
            this.btnHoteis = new ReaLTaiizor.Controls.Button();
            this.panel1.SuspendLayout();
            this.Perfil_Foto.SuspendLayout();
            this.panelHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnContratos);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.Perfil_Foto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 567);
            this.panel1.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSair.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            this.btnSair.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSair.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSair.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSair.Location = new System.Drawing.Point(234, 141);
            this.btnSair.Name = "btnSair";
            this.btnSair.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnSair.Size = new System.Drawing.Size(81, 40);
            this.btnSair.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.BackColor = System.Drawing.Color.Transparent;
            this.btnContratos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnContratos.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnContratos.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnContratos.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContratos.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratos.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnContratos.Location = new System.Drawing.Point(48, 444);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnContratos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnContratos.Size = new System.Drawing.Size(300, 74);
            this.btnContratos.TabIndex = 10;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtNome.Location = new System.Drawing.Point(225, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 28);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Login Usuário";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnClientes.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnClientes.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnClientes.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnClientes.Location = new System.Drawing.Point(48, 302);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnClientes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnClientes.Size = new System.Drawing.Size(300, 74);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Perfil_Foto
            // 
            this.Perfil_Foto.BackColor = System.Drawing.Color.White;
            this.Perfil_Foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Perfil_Foto.BackgroundImage")));
            this.Perfil_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Perfil_Foto.Controls.Add(this.Perfil_Mask);
            this.Perfil_Foto.Location = new System.Drawing.Point(34, 26);
            this.Perfil_Foto.Name = "Perfil_Foto";
            this.Perfil_Foto.Size = new System.Drawing.Size(194, 194);
            this.Perfil_Foto.TabIndex = 0;
            // 
            // Perfil_Mask
            // 
            this.Perfil_Mask.BackColor = System.Drawing.Color.Transparent;
            this.Perfil_Mask.BackgroundImage = global::ReservaHoteis.App.Properties.Resources.Perfil_Mask;
            this.Perfil_Mask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Perfil_Mask.ColorLeft = System.Drawing.Color.DodgerBlue;
            this.Perfil_Mask.ColorRight = System.Drawing.Color.DodgerBlue;
            this.Perfil_Mask.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.Perfil_Mask.FilterAlpha = 200;
            this.Perfil_Mask.FilterEnabled = true;
            this.Perfil_Mask.Image = null;
            this.Perfil_Mask.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.Perfil_Mask.IsElipse = false;
            this.Perfil_Mask.IsParallax = false;
            this.Perfil_Mask.Location = new System.Drawing.Point(0, 0);
            this.Perfil_Mask.Name = "Perfil_Mask";
            this.Perfil_Mask.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.Perfil_Mask.Size = new System.Drawing.Size(194, 194);
            this.Perfil_Mask.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.Perfil_Mask.TabIndex = 1;
            this.Perfil_Mask.Text = "parrotPictureBox1";
            this.Perfil_Mask.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnAvaliações
            // 
            this.btnAvaliações.BackColor = System.Drawing.Color.Transparent;
            this.btnAvaliações.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAvaliações.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAvaliações.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnAvaliações.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAvaliações.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.btnAvaliações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvaliações.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnAvaliações.Location = new System.Drawing.Point(91, 166);
            this.btnAvaliações.Name = "btnAvaliações";
            this.btnAvaliações.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAvaliações.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAvaliações.Size = new System.Drawing.Size(300, 74);
            this.btnAvaliações.TabIndex = 11;
            this.btnAvaliações.Text = "Avaliações";
            this.btnAvaliações.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAvaliações.Click += new System.EventHandler(this.btnAvaliações_Click);
            // 
            // btnCidades
            // 
            this.btnCidades.BackColor = System.Drawing.Color.Transparent;
            this.btnCidades.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCidades.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCidades.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnCidades.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCidades.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.btnCidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCidades.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnCidades.Location = new System.Drawing.Point(91, 444);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCidades.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCidades.Size = new System.Drawing.Size(300, 74);
            this.btnCidades.TabIndex = 8;
            this.btnCidades.Text = "Localizações";
            this.btnCidades.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // panelHotel
            // 
            this.panelHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelHotel.BackgroundImage = global::ReservaHoteis.App.Properties.Resources.login_background;
            this.panelHotel.Controls.Add(this.btnAvaliações);
            this.panelHotel.Controls.Add(this.btnHoteis);
            this.panelHotel.Controls.Add(this.btnCidades);
            this.panelHotel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHotel.Location = new System.Drawing.Point(468, 0);
            this.panelHotel.Name = "panelHotel";
            this.panelHotel.Size = new System.Drawing.Size(468, 567);
            this.panelHotel.TabIndex = 3;
            // 
            // btnHoteis
            // 
            this.btnHoteis.BackColor = System.Drawing.Color.Transparent;
            this.btnHoteis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnHoteis.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHoteis.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnHoteis.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoteis.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.btnHoteis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoteis.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnHoteis.Location = new System.Drawing.Point(91, 302);
            this.btnHoteis.Name = "btnHoteis";
            this.btnHoteis.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHoteis.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHoteis.Size = new System.Drawing.Size(300, 74);
            this.btnHoteis.TabIndex = 9;
            this.btnHoteis.Text = "Hoteis";
            this.btnHoteis.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnHoteis.Click += new System.EventHandler(this.btnHoteis_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(936, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHotel);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Perfil_Foto.ResumeLayout(false);
            this.panelHotel.ResumeLayout(false);
            this.ResumeLayout(false);

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
