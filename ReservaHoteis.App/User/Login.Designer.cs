namespace ReservaHoteis.App.User
{
    partial class Login
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
            Login_panel = new Panel();
            btnCadastrar = new ReaLTaiizor.Controls.HopeRoundButton();
            btnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            hopeSwitch1 = new ReaLTaiizor.Controls.HopeSwitch();
            txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            txtLogin = new ReaLTaiizor.Controls.HopeTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            Cad_panel = new Panel();
            Cad_txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            Cad_btnVoltar = new ReaLTaiizor.Controls.HopeRoundButton();
            Cad_txtConfSenha = new ReaLTaiizor.Controls.HopeTextBox();
            Cad_txtDoc = new ReaLTaiizor.Controls.HopeTextBox();
            Cad_btnConf = new ReaLTaiizor.Controls.HopeRoundButton();
            Cad_txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            Cad_txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            objectAnimator1 = new ReaLTaiizor.Animate.Parrot.ObjectAnimator();
            Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            Cad_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Login_panel
            // 
            Login_panel.BackColor = Color.FromArgb(7, 102, 173);
            Login_panel.Controls.Add(btnCadastrar);
            Login_panel.Controls.Add(btnEntrar);
            Login_panel.Controls.Add(materialLabel1);
            Login_panel.Controls.Add(hopeSwitch1);
            Login_panel.Controls.Add(txtSenha);
            Login_panel.Controls.Add(txtLogin);
            Login_panel.Controls.Add(hopePictureBox1);
            Login_panel.Dock = DockStyle.Left;
            Login_panel.Location = new Point(0, 0);
            Login_panel.Name = "Login_panel";
            Login_panel.Size = new Size(367, 567);
            Login_panel.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BorderColor = Color.FromArgb(220, 223, 230);
            btnCadastrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            btnCadastrar.DangerColor = Color.FromArgb(245, 108, 108);
            btnCadastrar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCadastrar.InfoColor = Color.FromArgb(144, 147, 153);
            btnCadastrar.Location = new Point(190, 506);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnCadastrar.Size = new Size(137, 40);
            btnCadastrar.SuccessColor = Color.FromArgb(41, 173, 178);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BorderColor = Color.FromArgb(220, 223, 230);
            btnEntrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEntrar.DangerColor = Color.FromArgb(245, 108, 108);
            btnEntrar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEntrar.InfoColor = Color.FromArgb(144, 147, 153);
            btnEntrar.Location = new Point(35, 506);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnEntrar.Size = new Size(137, 40);
            btnEntrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnEntrar.Click += btnEntrar_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel1.Location = new Point(81, 364);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(70, 17);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Lembre-se";
            // 
            // hopeSwitch1
            // 
            hopeSwitch1.AutoSize = true;
            hopeSwitch1.BackColor = Color.FromArgb(7, 102, 173);
            hopeSwitch1.BaseColor = Color.FromArgb(64, 64, 64);
            hopeSwitch1.BaseOffColor = Color.FromArgb(227, 244, 206);
            hopeSwitch1.BaseOnColor = Color.FromArgb(197, 232, 152);
            hopeSwitch1.FlatStyle = FlatStyle.Flat;
            hopeSwitch1.Location = new Point(35, 361);
            hopeSwitch1.Name = "hopeSwitch1";
            hopeSwitch1.Size = new Size(40, 20);
            hopeSwitch1.TabIndex = 3;
            hopeSwitch1.Text = "hopeSwitch1";
            hopeSwitch1.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(243, 243, 243);
            txtSenha.BaseColor = Color.FromArgb(44, 55, 66);
            txtSenha.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSenha.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.FromArgb(48, 49, 51);
            txtSenha.Hint = "Senha";
            txtSenha.Location = new Point(35, 305);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.ScrollBars = ScrollBars.None;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.Size = new Size(292, 38);
            txtSenha.TabIndex = 2;
            txtSenha.TabStop = false;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(243, 243, 243);
            txtLogin.BaseColor = Color.FromArgb(44, 55, 66);
            txtLogin.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLogin.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.FromArgb(48, 49, 51);
            txtLogin.Hint = "Login";
            txtLogin.Location = new Point(35, 251);
            txtLogin.MaxLength = 32767;
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.ScrollBars = ScrollBars.None;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.Size = new Size(292, 38);
            txtLogin.TabIndex = 1;
            txtLogin.TabStop = false;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.Logo_Nome;
            hopePictureBox1.Location = new Point(35, 67);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(292, 178);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Cad_panel
            // 
            Cad_panel.BackColor = Color.FromArgb(7, 102, 173);
            Cad_panel.Controls.Add(Cad_txtNome);
            Cad_panel.Controls.Add(Cad_btnVoltar);
            Cad_panel.Controls.Add(Cad_txtConfSenha);
            Cad_panel.Controls.Add(Cad_txtDoc);
            Cad_panel.Controls.Add(Cad_btnConf);
            Cad_panel.Controls.Add(Cad_txtSenha);
            Cad_panel.Controls.Add(Cad_txtEmail);
            Cad_panel.Controls.Add(hopePictureBox2);
            Cad_panel.Dock = DockStyle.Left;
            Cad_panel.Location = new Point(367, 0);
            Cad_panel.Name = "Cad_panel";
            Cad_panel.Size = new Size(367, 567);
            Cad_panel.TabIndex = 7;
            Cad_panel.Visible = false;
            // 
            // Cad_txtNome
            // 
            Cad_txtNome.BackColor = Color.FromArgb(243, 243, 243);
            Cad_txtNome.BaseColor = Color.FromArgb(44, 55, 66);
            Cad_txtNome.BorderColorA = Color.FromArgb(64, 158, 255);
            Cad_txtNome.BorderColorB = Color.FromArgb(220, 223, 230);
            Cad_txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_txtNome.ForeColor = Color.FromArgb(48, 49, 51);
            Cad_txtNome.Hint = "Nome Completo";
            Cad_txtNome.Location = new Point(35, 273);
            Cad_txtNome.MaxLength = 32767;
            Cad_txtNome.Multiline = false;
            Cad_txtNome.Name = "Cad_txtNome";
            Cad_txtNome.PasswordChar = '\0';
            Cad_txtNome.ScrollBars = ScrollBars.None;
            Cad_txtNome.SelectedText = "";
            Cad_txtNome.SelectionLength = 0;
            Cad_txtNome.SelectionStart = 0;
            Cad_txtNome.Size = new Size(292, 38);
            Cad_txtNome.TabIndex = 11;
            Cad_txtNome.TabStop = false;
            Cad_txtNome.UseSystemPasswordChar = false;
            // 
            // Cad_btnVoltar
            // 
            Cad_btnVoltar.BackColor = Color.IndianRed;
            Cad_btnVoltar.BorderColor = Color.FromArgb(220, 223, 230);
            Cad_btnVoltar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            Cad_btnVoltar.DangerColor = Color.FromArgb(245, 108, 108);
            Cad_btnVoltar.DefaultColor = Color.FromArgb(255, 255, 255);
            Cad_btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_btnVoltar.HoverTextColor = Color.FromArgb(48, 49, 51);
            Cad_btnVoltar.InfoColor = Color.FromArgb(144, 147, 153);
            Cad_btnVoltar.Location = new Point(20, 31);
            Cad_btnVoltar.Name = "Cad_btnVoltar";
            Cad_btnVoltar.PrimaryColor = Color.FromArgb(64, 158, 255);
            Cad_btnVoltar.Size = new Size(104, 40);
            Cad_btnVoltar.SuccessColor = Color.FromArgb(103, 194, 58);
            Cad_btnVoltar.TabIndex = 10;
            Cad_btnVoltar.Text = "< Voltar";
            Cad_btnVoltar.TextColor = Color.White;
            Cad_btnVoltar.WarningColor = Color.FromArgb(230, 162, 60);
            Cad_btnVoltar.Click += Cad_btnVoltar_Click;
            // 
            // Cad_txtConfSenha
            // 
            Cad_txtConfSenha.BackColor = Color.FromArgb(243, 243, 243);
            Cad_txtConfSenha.BaseColor = Color.FromArgb(44, 55, 66);
            Cad_txtConfSenha.BorderColorA = Color.FromArgb(64, 158, 255);
            Cad_txtConfSenha.BorderColorB = Color.FromArgb(220, 223, 230);
            Cad_txtConfSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_txtConfSenha.ForeColor = Color.FromArgb(48, 49, 51);
            Cad_txtConfSenha.Hint = "Confirmar Senha";
            Cad_txtConfSenha.Location = new Point(35, 446);
            Cad_txtConfSenha.MaxLength = 32767;
            Cad_txtConfSenha.Multiline = false;
            Cad_txtConfSenha.Name = "Cad_txtConfSenha";
            Cad_txtConfSenha.PasswordChar = '*';
            Cad_txtConfSenha.ScrollBars = ScrollBars.None;
            Cad_txtConfSenha.SelectedText = "";
            Cad_txtConfSenha.SelectionLength = 0;
            Cad_txtConfSenha.SelectionStart = 0;
            Cad_txtConfSenha.Size = new Size(292, 38);
            Cad_txtConfSenha.TabIndex = 8;
            Cad_txtConfSenha.TabStop = false;
            Cad_txtConfSenha.UseSystemPasswordChar = true;
            // 
            // Cad_txtDoc
            // 
            Cad_txtDoc.BackColor = Color.FromArgb(243, 243, 243);
            Cad_txtDoc.BaseColor = Color.FromArgb(44, 55, 66);
            Cad_txtDoc.BorderColorA = Color.FromArgb(64, 158, 255);
            Cad_txtDoc.BorderColorB = Color.FromArgb(220, 223, 230);
            Cad_txtDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_txtDoc.ForeColor = Color.FromArgb(48, 49, 51);
            Cad_txtDoc.Hint = "Documento";
            Cad_txtDoc.Location = new Point(35, 328);
            Cad_txtDoc.MaxLength = 32767;
            Cad_txtDoc.Multiline = false;
            Cad_txtDoc.Name = "Cad_txtDoc";
            Cad_txtDoc.PasswordChar = '\0';
            Cad_txtDoc.ScrollBars = ScrollBars.None;
            Cad_txtDoc.SelectedText = "";
            Cad_txtDoc.SelectionLength = 0;
            Cad_txtDoc.SelectionStart = 0;
            Cad_txtDoc.Size = new Size(292, 38);
            Cad_txtDoc.TabIndex = 7;
            Cad_txtDoc.TabStop = false;
            Cad_txtDoc.UseSystemPasswordChar = false;
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
            Cad_btnConf.Location = new Point(109, 506);
            Cad_btnConf.Name = "Cad_btnConf";
            Cad_btnConf.PrimaryColor = Color.FromArgb(64, 158, 255);
            Cad_btnConf.Size = new Size(137, 40);
            Cad_btnConf.SuccessColor = Color.FromArgb(41, 173, 178);
            Cad_btnConf.TabIndex = 6;
            Cad_btnConf.Text = "Confirmar";
            Cad_btnConf.TextColor = Color.White;
            Cad_btnConf.WarningColor = Color.FromArgb(230, 162, 60);
            Cad_btnConf.Click += Cad_btnConf_Click;
            // 
            // Cad_txtSenha
            // 
            Cad_txtSenha.BackColor = Color.FromArgb(243, 243, 243);
            Cad_txtSenha.BaseColor = Color.FromArgb(44, 55, 66);
            Cad_txtSenha.BorderColorA = Color.FromArgb(64, 158, 255);
            Cad_txtSenha.BorderColorB = Color.FromArgb(220, 223, 230);
            Cad_txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_txtSenha.ForeColor = Color.FromArgb(48, 49, 51);
            Cad_txtSenha.Hint = "Senha";
            Cad_txtSenha.Location = new Point(35, 392);
            Cad_txtSenha.MaxLength = 32767;
            Cad_txtSenha.Multiline = false;
            Cad_txtSenha.Name = "Cad_txtSenha";
            Cad_txtSenha.PasswordChar = '*';
            Cad_txtSenha.ScrollBars = ScrollBars.None;
            Cad_txtSenha.SelectedText = "";
            Cad_txtSenha.SelectionLength = 0;
            Cad_txtSenha.SelectionStart = 0;
            Cad_txtSenha.Size = new Size(292, 38);
            Cad_txtSenha.TabIndex = 2;
            Cad_txtSenha.TabStop = false;
            Cad_txtSenha.UseSystemPasswordChar = true;
            // 
            // Cad_txtEmail
            // 
            Cad_txtEmail.BackColor = Color.FromArgb(243, 243, 243);
            Cad_txtEmail.BaseColor = Color.FromArgb(44, 55, 66);
            Cad_txtEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            Cad_txtEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            Cad_txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad_txtEmail.ForeColor = Color.FromArgb(48, 49, 51);
            Cad_txtEmail.Hint = "Login";
            Cad_txtEmail.Location = new Point(35, 219);
            Cad_txtEmail.MaxLength = 32767;
            Cad_txtEmail.Multiline = false;
            Cad_txtEmail.Name = "Cad_txtEmail";
            Cad_txtEmail.PasswordChar = '\0';
            Cad_txtEmail.ScrollBars = ScrollBars.None;
            Cad_txtEmail.SelectedText = "";
            Cad_txtEmail.SelectionLength = 0;
            Cad_txtEmail.SelectionStart = 0;
            Cad_txtEmail.Size = new Size(292, 38);
            Cad_txtEmail.TabIndex = 1;
            Cad_txtEmail.TabStop = false;
            Cad_txtEmail.UseSystemPasswordChar = false;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox2.Image = Properties.Resources.Logo_Nome;
            hopePictureBox2.Location = new Point(35, 67);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(292, 178);
            hopePictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox2.TabIndex = 9;
            hopePictureBox2.TabStop = false;
            hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GrayText;
            BackgroundImage = Properties.Resources.login_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 567);
            Controls.Add(Cad_panel);
            Controls.Add(Login_panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Login_panel.ResumeLayout(false);
            Login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            Cad_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Login_panel;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtLogin;
        private ReaLTaiizor.Animate.Parrot.ObjectAnimator objectAnimator1;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.HopeSwitch hopeSwitch1;
        private ReaLTaiizor.Controls.HopeRoundButton btnCadastrar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEntrar;
        private Panel Cad_panel;
        private ReaLTaiizor.Controls.HopeRoundButton Cad_btnConf;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.HopeSwitch hopeSwitch2;
        private ReaLTaiizor.Controls.HopeTextBox Cad_txtSenha;
        private ReaLTaiizor.Controls.HopeTextBox Cad_txtEmail;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private ReaLTaiizor.Controls.HopeTextBox Cad_txtConfSenha;
        private ReaLTaiizor.Controls.HopeTextBox Cad_txtDoc;
        private ReaLTaiizor.Controls.HopeRoundButton Cad_btnVoltar;
        private ReaLTaiizor.Controls.HopeTextBox Cad_txtNome;
    }
}