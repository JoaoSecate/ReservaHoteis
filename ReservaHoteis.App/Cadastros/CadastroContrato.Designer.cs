namespace ReservaHoteis.App.Cadastros
{
    partial class CadastroContrato
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
            txtValor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboHotel = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboHotel);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtValor);
            tabPageCadastro.Size = new Size(786, 355);
            tabPageCadastro.Controls.SetChildIndex(txtValor, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboHotel, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // txtValor
            // 
            txtValor.AnimateReadOnly = false;
            txtValor.AutoCompleteMode = AutoCompleteMode.None;
            txtValor.AutoCompleteSource = AutoCompleteSource.None;
            txtValor.BackgroundImageLayout = ImageLayout.None;
            txtValor.CharacterCasing = CharacterCasing.Normal;
            txtValor.Depth = 0;
            txtValor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValor.HideSelection = true;
            txtValor.Hint = "Valor";
            txtValor.LeadingIcon = null;
            txtValor.Location = new Point(37, 119);
            txtValor.MaxLength = 32767;
            txtValor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValor.Name = "txtValor";
            txtValor.PasswordChar = '\0';
            txtValor.PrefixSuffixText = null;
            txtValor.ReadOnly = false;
            txtValor.RightToLeft = RightToLeft.No;
            txtValor.SelectedText = "";
            txtValor.SelectionLength = 0;
            txtValor.SelectionStart = 0;
            txtValor.ShortcutsEnabled = true;
            txtValor.Size = new Size(70, 48);
            txtValor.TabIndex = 15;
            txtValor.TabStop = false;
            txtValor.TextAlign = HorizontalAlignment.Left;
            txtValor.TrailingIcon = null;
            txtValor.UseSystemPasswordChar = false;
            // 
            // cboHotel
            // 
            cboHotel.AutoResize = false;
            cboHotel.BackColor = Color.FromArgb(255, 255, 255);
            cboHotel.Depth = 0;
            cboHotel.DrawMode = DrawMode.OwnerDrawVariable;
            cboHotel.DropDownHeight = 174;
            cboHotel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHotel.DropDownWidth = 121;
            cboHotel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboHotel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboHotel.FormattingEnabled = true;
            cboHotel.IntegralHeight = false;
            cboHotel.ItemHeight = 43;
            cboHotel.Location = new Point(183, 20);
            cboHotel.MaxDropDownItems = 4;
            cboHotel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboHotel.Name = "cboHotel";
            cboHotel.Size = new Size(110, 49);
            cboHotel.StartIndex = 0;
            cboHotel.TabIndex = 18;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(37, 21);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(110, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(616, 20);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(70, 48);
            txtId.TabIndex = 19;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroContrato";
            Text = "CadastroContrato";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValor;
        private ReaLTaiizor.Controls.MaterialComboBox cboHotel;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}