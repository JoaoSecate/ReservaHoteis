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
            this.button3 = new ReaLTaiizor.Controls.Button();
            this.btnSair = new ReaLTaiizor.Controls.HopeRoundButton();
            this.button2 = new ReaLTaiizor.Controls.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.Perfil_Foto = new System.Windows.Forms.Panel();
            this.Perfil_Mask = new ReaLTaiizor.Controls.ParrotPictureBox();
            this.btnHotel = new ReaLTaiizor.Controls.Button();
            this.panelHotel = new System.Windows.Forms.Panel();
            this.button4 = new ReaLTaiizor.Controls.Button();
            this.panel1.SuspendLayout();
            this.Perfil_Foto.SuspendLayout();
            this.panelHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Perfil_Foto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 567);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button3.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button3.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button3.Location = new System.Drawing.Point(91, 166);
            this.button3.Name = "button3";
            this.button3.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.Size = new System.Drawing.Size(300, 74);
            this.button3.TabIndex = 11;
            this.button3.Text = "Avaliações";
            this.button3.TextAlignment = System.Drawing.StringAlignment.Center;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button2.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button2.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button2.Location = new System.Drawing.Point(48, 444);
            this.button2.Name = "button2";
            this.button2.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.Size = new System.Drawing.Size(300, 74);
            this.button2.TabIndex = 10;
            this.button2.Text = "Contratos";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button1.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button1.Location = new System.Drawing.Point(48, 302);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(300, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clientes";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
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
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.Color.Transparent;
            this.btnHotel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnHotel.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHotel.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnHotel.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHotel.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.btnHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotel.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnHotel.Location = new System.Drawing.Point(91, 444);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHotel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHotel.Size = new System.Drawing.Size(300, 74);
            this.btnHotel.TabIndex = 8;
            this.btnHotel.Text = "Localizações";
            this.btnHotel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelHotel
            // 
            this.panelHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelHotel.BackgroundImage = global::ReservaHoteis.App.Properties.Resources.login_background;
            this.panelHotel.Controls.Add(this.button3);
            this.panelHotel.Controls.Add(this.button4);
            this.panelHotel.Controls.Add(this.btnHotel);
            this.panelHotel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHotel.Location = new System.Drawing.Point(468, 0);
            this.panelHotel.Name = "panelHotel";
            this.panelHotel.Size = new System.Drawing.Size(468, 567);
            this.panelHotel.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button4.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button4.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::ReservaHoteis.App.Properties.Resources.BuscarHotel_btnIcon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.button4.Location = new System.Drawing.Point(91, 302);
            this.button4.Name = "button4";
            this.button4.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.Size = new System.Drawing.Size(300, 74);
            this.button4.TabIndex = 9;
            this.button4.Text = "Hoteis";
            this.button4.TextAlignment = System.Drawing.StringAlignment.Center;
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
        private ReaLTaiizor.Controls.Button btnHotel;
        private Panel panelHotel;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button3;
        private ReaLTaiizor.Controls.Button button4;
    }
}
