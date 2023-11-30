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
            this.test_btnCidade = new ReaLTaiizor.Controls.AirButton();
            this.SuspendLayout();
            // 
            // test_btnCidade
            // 
            this.test_btnCidade.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.test_btnCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test_btnCidade.Image = null;
            this.test_btnCidade.Location = new System.Drawing.Point(31, 99);
            this.test_btnCidade.Name = "test_btnCidade";
            this.test_btnCidade.NoRounding = false;
            this.test_btnCidade.Size = new System.Drawing.Size(100, 45);
            this.test_btnCidade.TabIndex = 0;
            this.test_btnCidade.Text = "Cidade";
            this.test_btnCidade.Transparent = false;
            this.test_btnCidade.Click += new System.EventHandler(this.test_btnCidade_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.test_btnCidade);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirButton test_btnCidade;
    }
}
