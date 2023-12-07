namespace ReservaHoteis.App.Cadastros
{
    partial class CadastroCliente
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
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 383);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.materialTextBoxEdit1);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 355);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.materialTextBoxEdit1, 0);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(17, 18);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(554, 48);
            this.txtNome.TabIndex = 14;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit1
            // 
            this.materialTextBoxEdit1.AnimateReadOnly = false;
            this.materialTextBoxEdit1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBoxEdit1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBoxEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxEdit1.Depth = 0;
            this.materialTextBoxEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEdit1.HideSelection = true;
            this.materialTextBoxEdit1.Hint = "Nome";
            this.materialTextBoxEdit1.LeadingIcon = null;
            this.materialTextBoxEdit1.Location = new System.Drawing.Point(17, 84);
            this.materialTextBoxEdit1.MaxLength = 32767;
            this.materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            this.materialTextBoxEdit1.PasswordChar = '\0';
            this.materialTextBoxEdit1.PrefixSuffixText = null;
            this.materialTextBoxEdit1.ReadOnly = false;
            this.materialTextBoxEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxEdit1.SelectedText = "";
            this.materialTextBoxEdit1.SelectionLength = 0;
            this.materialTextBoxEdit1.SelectionStart = 0;
            this.materialTextBoxEdit1.ShortcutsEnabled = true;
            this.materialTextBoxEdit1.Size = new System.Drawing.Size(554, 48);
            this.materialTextBoxEdit1.TabIndex = 15;
            this.materialTextBoxEdit1.TabStop = false;
            this.materialTextBoxEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxEdit1.TrailingIcon = null;
            this.materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}