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
            this.Login_panel = new System.Windows.Forms.Panel();
            this.btnCadastrar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.hopeSwitch1 = new ReaLTaiizor.Controls.HopeSwitch();
            this.txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtLogin = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.Cad_panel = new System.Windows.Forms.Panel();
            this.Cad_txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            this.Cad_btnVoltar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.Cad_btnConf = new ReaLTaiizor.Controls.HopeRoundButton();
            this.Cad_txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            this.Cad_txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            this.objectAnimator1 = new ReaLTaiizor.Animate.Parrot.ObjectAnimator();
            this.Login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.Cad_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.Login_panel.Controls.Add(this.btnCadastrar);
            this.Login_panel.Controls.Add(this.btnEntrar);
            this.Login_panel.Controls.Add(this.materialLabel1);
            this.Login_panel.Controls.Add(this.hopeSwitch1);
            this.Login_panel.Controls.Add(this.txtSenha);
            this.Login_panel.Controls.Add(this.txtLogin);
            this.Login_panel.Controls.Add(this.hopePictureBox1);
            this.Login_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login_panel.Location = new System.Drawing.Point(0, 0);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(367, 567);
            this.Login_panel.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCadastrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            this.btnCadastrar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCadastrar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCadastrar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCadastrar.Location = new System.Drawing.Point(190, 506);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Size = new System.Drawing.Size(137, 40);
            this.btnCadastrar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.TextColor = System.Drawing.Color.White;
            this.btnCadastrar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnEntrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnEntrar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEntrar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnEntrar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEntrar.Location = new System.Drawing.Point(35, 506);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnEntrar.Size = new System.Drawing.Size(137, 40);
            this.btnEntrar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextColor = System.Drawing.Color.White;
            this.btnEntrar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(81, 364);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 17);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Lembre-se";
            // 
            // hopeSwitch1
            // 
            this.hopeSwitch1.AutoSize = true;
            this.hopeSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.hopeSwitch1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hopeSwitch1.BaseOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(244)))), ((int)(((byte)(206)))));
            this.hopeSwitch1.BaseOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(152)))));
            this.hopeSwitch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeSwitch1.Location = new System.Drawing.Point(35, 361);
            this.hopeSwitch1.Name = "hopeSwitch1";
            this.hopeSwitch1.Size = new System.Drawing.Size(40, 20);
            this.hopeSwitch1.TabIndex = 3;
            this.hopeSwitch1.Text = "hopeSwitch1";
            this.hopeSwitch1.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtSenha.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtSenha.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtSenha.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(35, 305);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(292, 38);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TabStop = false;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtLogin.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtLogin.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtLogin.Hint = "Login";
            this.txtLogin.Location = new System.Drawing.Point(35, 251);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(292, 38);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TabStop = false;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = global::ReservaHoteis.App.Properties.Resources.Logo_Nome;
            this.hopePictureBox1.Location = new System.Drawing.Point(35, 67);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(292, 178);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 0;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Cad_panel
            // 
            this.Cad_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.Cad_panel.Controls.Add(this.Cad_txtNome);
            this.Cad_panel.Controls.Add(this.Cad_btnVoltar);
            this.Cad_panel.Controls.Add(this.Cad_btnConf);
            this.Cad_panel.Controls.Add(this.Cad_txtSenha);
            this.Cad_panel.Controls.Add(this.Cad_txtEmail);
            this.Cad_panel.Controls.Add(this.hopePictureBox2);
            this.Cad_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Cad_panel.Location = new System.Drawing.Point(367, 0);
            this.Cad_panel.Name = "Cad_panel";
            this.Cad_panel.Size = new System.Drawing.Size(367, 567);
            this.Cad_panel.TabIndex = 7;
            this.Cad_panel.Visible = false;
            // 
            // Cad_txtNome
            // 
            this.Cad_txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Cad_txtNome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.Cad_txtNome.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Cad_txtNome.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Cad_txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cad_txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Cad_txtNome.Hint = "Nome Completo";
            this.Cad_txtNome.Location = new System.Drawing.Point(35, 305);
            this.Cad_txtNome.MaxLength = 32767;
            this.Cad_txtNome.Multiline = false;
            this.Cad_txtNome.Name = "Cad_txtNome";
            this.Cad_txtNome.PasswordChar = '\0';
            this.Cad_txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cad_txtNome.SelectedText = "";
            this.Cad_txtNome.SelectionLength = 0;
            this.Cad_txtNome.SelectionStart = 0;
            this.Cad_txtNome.Size = new System.Drawing.Size(292, 38);
            this.Cad_txtNome.TabIndex = 11;
            this.Cad_txtNome.TabStop = false;
            this.Cad_txtNome.UseSystemPasswordChar = false;
            // 
            // Cad_btnVoltar
            // 
            this.Cad_btnVoltar.BackColor = System.Drawing.Color.IndianRed;
            this.Cad_btnVoltar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Cad_btnVoltar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            this.Cad_btnVoltar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Cad_btnVoltar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cad_btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cad_btnVoltar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Cad_btnVoltar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Cad_btnVoltar.Location = new System.Drawing.Point(20, 31);
            this.Cad_btnVoltar.Name = "Cad_btnVoltar";
            this.Cad_btnVoltar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Cad_btnVoltar.Size = new System.Drawing.Size(104, 40);
            this.Cad_btnVoltar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.Cad_btnVoltar.TabIndex = 10;
            this.Cad_btnVoltar.Text = "< Voltar";
            this.Cad_btnVoltar.TextColor = System.Drawing.Color.White;
            this.Cad_btnVoltar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Cad_btnVoltar.Click += new System.EventHandler(this.Cad_btnVoltar_Click);
            // 
            // Cad_btnConf
            // 
            this.Cad_btnConf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Cad_btnConf.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            this.Cad_btnConf.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Cad_btnConf.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cad_btnConf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cad_btnConf.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Cad_btnConf.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.Cad_btnConf.Location = new System.Drawing.Point(109, 506);
            this.Cad_btnConf.Name = "Cad_btnConf";
            this.Cad_btnConf.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Cad_btnConf.Size = new System.Drawing.Size(137, 40);
            this.Cad_btnConf.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(173)))), ((int)(((byte)(178)))));
            this.Cad_btnConf.TabIndex = 6;
            this.Cad_btnConf.Text = "Confirmar";
            this.Cad_btnConf.TextColor = System.Drawing.Color.White;
            this.Cad_btnConf.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.Cad_btnConf.Click += new System.EventHandler(this.Cad_btnConf_Click);
            // 
            // Cad_txtSenha
            // 
            this.Cad_txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Cad_txtSenha.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.Cad_txtSenha.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Cad_txtSenha.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Cad_txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cad_txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Cad_txtSenha.Hint = "Senha";
            this.Cad_txtSenha.Location = new System.Drawing.Point(35, 361);
            this.Cad_txtSenha.MaxLength = 32767;
            this.Cad_txtSenha.Multiline = false;
            this.Cad_txtSenha.Name = "Cad_txtSenha";
            this.Cad_txtSenha.PasswordChar = '*';
            this.Cad_txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cad_txtSenha.SelectedText = "";
            this.Cad_txtSenha.SelectionLength = 0;
            this.Cad_txtSenha.SelectionStart = 0;
            this.Cad_txtSenha.Size = new System.Drawing.Size(292, 38);
            this.Cad_txtSenha.TabIndex = 2;
            this.Cad_txtSenha.TabStop = false;
            this.Cad_txtSenha.UseSystemPasswordChar = true;
            // 
            // Cad_txtEmail
            // 
            this.Cad_txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Cad_txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.Cad_txtEmail.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Cad_txtEmail.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.Cad_txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cad_txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Cad_txtEmail.Hint = "Login";
            this.Cad_txtEmail.Location = new System.Drawing.Point(35, 251);
            this.Cad_txtEmail.MaxLength = 32767;
            this.Cad_txtEmail.Multiline = false;
            this.Cad_txtEmail.Name = "Cad_txtEmail";
            this.Cad_txtEmail.PasswordChar = '\0';
            this.Cad_txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cad_txtEmail.SelectedText = "";
            this.Cad_txtEmail.SelectionLength = 0;
            this.Cad_txtEmail.SelectionStart = 0;
            this.Cad_txtEmail.Size = new System.Drawing.Size(292, 38);
            this.Cad_txtEmail.TabIndex = 1;
            this.Cad_txtEmail.TabStop = false;
            this.Cad_txtEmail.UseSystemPasswordChar = false;
            // 
            // hopePictureBox2
            // 
            this.hopePictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox2.Image = global::ReservaHoteis.App.Properties.Resources.Logo_Nome;
            this.hopePictureBox2.Location = new System.Drawing.Point(35, 67);
            this.hopePictureBox2.Name = "hopePictureBox2";
            this.hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox2.Size = new System.Drawing.Size(292, 178);
            this.hopePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox2.TabIndex = 9;
            this.hopePictureBox2.TabStop = false;
            this.hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::ReservaHoteis.App.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 567);
            this.Controls.Add(this.Cad_panel);
            this.Controls.Add(this.Login_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.Cad_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private ReaLTaiizor.Controls.HopeRoundButton Cad_btnVoltar;
        private ReaLTaiizor.Controls.HopeTextBox Cad_txtNome;
    }
}