namespace ReservaHoteis.App.Cadastros
{
    partial class CadastroAvaliacao
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
            txtNota = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboHotel = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboHotel);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtNota);
            tabPageCadastro.Size = new Size(786, 355);
            tabPageCadastro.Controls.SetChildIndex(txtNota, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboHotel, 0);
            // 
            // txtNota
            // 
            txtNota.AnimateReadOnly = false;
            txtNota.AutoCompleteMode = AutoCompleteMode.None;
            txtNota.AutoCompleteSource = AutoCompleteSource.None;
            txtNota.BackgroundImageLayout = ImageLayout.None;
            txtNota.CharacterCasing = CharacterCasing.Normal;
            txtNota.Depth = 0;
            txtNota.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNota.HideSelection = true;
            txtNota.Hint = "Nota";
            txtNota.LeadingIcon = null;
            txtNota.Location = new Point(23, 6);
            txtNota.MaxLength = 32767;
            txtNota.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNota.Name = "txtNota";
            txtNota.PasswordChar = '\0';
            txtNota.PrefixSuffixText = null;
            txtNota.ReadOnly = false;
            txtNota.RightToLeft = RightToLeft.No;
            txtNota.SelectedText = "";
            txtNota.SelectionLength = 0;
            txtNota.SelectionStart = 0;
            txtNota.ShortcutsEnabled = true;
            txtNota.Size = new Size(70, 48);
            txtNota.TabIndex = 11;
            txtNota.TabStop = false;
            txtNota.TextAlign = HorizontalAlignment.Left;
            txtNota.TrailingIcon = null;
            txtNota.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(23, 70);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(554, 48);
            txtDescricao.TabIndex = 13;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
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
            cboCliente.Location = new Point(23, 202);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(110, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 15;
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
            cboHotel.Location = new Point(169, 201);
            cboHotel.MaxDropDownItems = 4;
            cboHotel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboHotel.Name = "cboHotel";
            cboHotel.Size = new Size(110, 49);
            cboHotel.StartIndex = 0;
            cboHotel.TabIndex = 16;
            // 
            // CadastroAvaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroAvaliacao";
            Text = "CadastroAvaliacao";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNota;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialComboBox cboHotel;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
    }
}