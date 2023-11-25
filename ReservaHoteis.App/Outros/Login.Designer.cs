namespace ReservaHoteis.App.Outros
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
            panel1 = new Panel();
            btnCadastrar = new ReaLTaiizor.Controls.HopeRoundButton();
            btnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            hopeSwitch1 = new ReaLTaiizor.Controls.HopeSwitch();
            txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            txtLogin = new ReaLTaiizor.Controls.HopeTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            panel2 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            objectAnimator1 = new ReaLTaiizor.Animate.Parrot.ObjectAnimator();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 102, 173);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(hopeSwitch1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(hopePictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 567);
            panel1.TabIndex = 1;
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
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.login_background;
            panel2.Controls.Add(nightControlBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(367, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 567);
            panel2.TabIndex = 2;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.DimGray;
            nightControlBox1.DisableMinimizeColor = Color.DimGray;
            nightControlBox1.EnableCloseColor = Color.FromArgb(64, 64, 64);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.DimGray;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(64, 64, 64);
            nightControlBox1.Location = new Point(430, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.GrayText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(936, 567);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtLogin;
        private ReaLTaiizor.Animate.Parrot.ObjectAnimator objectAnimator1;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.HopeSwitch hopeSwitch1;
        private ReaLTaiizor.Controls.HopeRoundButton btnCadastrar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEntrar;
    }
}