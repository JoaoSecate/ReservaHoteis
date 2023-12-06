namespace ReservaHoteis.App.Base
{
    partial class BaseHotel
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
            pictureBox1 = new PictureBox();
            txtCidadeHotel = new TextBox();
            txtNomeHotel = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            Cad_btnConf = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.login_background;
            pictureBox1.Location = new Point(51, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtCidadeHotel
            // 
            txtCidadeHotel.BackColor = Color.FromArgb(243, 243, 243);
            txtCidadeHotel.BorderStyle = BorderStyle.None;
            txtCidadeHotel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCidadeHotel.ForeColor = Color.FromArgb(64, 64, 64);
            txtCidadeHotel.Location = new Point(305, 115);
            txtCidadeHotel.Name = "txtCidadeHotel";
            txtCidadeHotel.ReadOnly = true;
            txtCidadeHotel.Size = new Size(165, 20);
            txtCidadeHotel.TabIndex = 6;
            txtCidadeHotel.Text = "Cidade - SP";
            // 
            // txtNomeHotel
            // 
            txtNomeHotel.BackColor = Color.FromArgb(243, 243, 243);
            txtNomeHotel.BorderStyle = BorderStyle.None;
            txtNomeHotel.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeHotel.ForeColor = Color.FromArgb(28, 28, 28);
            txtNomeHotel.Location = new Point(296, 81);
            txtNomeHotel.Name = "txtNomeHotel";
            txtNomeHotel.Size = new Size(195, 37);
            txtNomeHotel.TabIndex = 5;
            txtNomeHotel.Text = "Nome do Hotel";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(243, 243, 243);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(28, 28, 28);
            textBox3.Location = new Point(411, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 32);
            textBox3.TabIndex = 8;
            textBox3.Text = "0,00";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(243, 243, 243);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(28, 28, 28);
            textBox1.Location = new Point(315, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 32);
            textBox1.TabIndex = 7;
            textBox1.Text = "Preço: ";
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
            Cad_btnConf.Location = new Point(108, 280);
            Cad_btnConf.Name = "Cad_btnConf";
            Cad_btnConf.PrimaryColor = Color.FromArgb(64, 158, 255);
            Cad_btnConf.Size = new Size(137, 40);
            Cad_btnConf.SuccessColor = Color.FromArgb(41, 173, 178);
            Cad_btnConf.TabIndex = 9;
            Cad_btnConf.Text = "Gerenciar";
            Cad_btnConf.TextColor = Color.White;
            Cad_btnConf.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // BaseHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(843, 343);
            Controls.Add(Cad_btnConf);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(txtCidadeHotel);
            Controls.Add(txtNomeHotel);
            Controls.Add(pictureBox1);
            Name = "BaseHotel";
            Text = "BaseHotel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtCidadeHotel;
        private TextBox txtNomeHotel;
        private TextBox textBox3;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.HopeRoundButton Cad_btnConf;
    }
}