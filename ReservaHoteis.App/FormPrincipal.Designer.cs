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
            test_btnCidade = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // test_btnCidade
            // 
            test_btnCidade.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            test_btnCidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            test_btnCidade.Image = null;
            test_btnCidade.Location = new Point(558, 97);
            test_btnCidade.Name = "test_btnCidade";
            test_btnCidade.NoRounding = false;
            test_btnCidade.Size = new Size(100, 45);
            test_btnCidade.TabIndex = 0;
            test_btnCidade.Text = "Cidade";
            test_btnCidade.Transparent = false;
            test_btnCidade.Click += test_btnCidade_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(test_btnCidade);
            Name = "FormPrincipal";
            Text = "Form Principal";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton test_btnCidade;
    }
}
