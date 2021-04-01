
namespace AulasRADMDIBD
{
    partial class FrmCadPessoasFisicas
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
            this.components = new System.ComponentModel.Container();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgvPessoasFisicas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.vwPessoaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasFisicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPessoaFisicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(388, 230);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 31);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(203, 183);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 27);
            this.txtTelefone.TabIndex = 11;
            // 
            // dgvPessoasFisicas
            // 
            this.dgvPessoasFisicas.AllowUserToAddRows = false;
            this.dgvPessoasFisicas.AllowUserToDeleteRows = false;
            this.dgvPessoasFisicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoasFisicas.AutoGenerateColumns = false;
            this.dgvPessoasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoasFisicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgvPessoasFisicas.DataSource = this.vwPessoaFisicaBindingSource;
            this.dgvPessoasFisicas.Location = new System.Drawing.Point(12, 288);
            this.dgvPessoasFisicas.Name = "dgvPessoasFisicas";
            this.dgvPessoasFisicas.ReadOnly = true;
            this.dgvPessoasFisicas.RowHeadersWidth = 51;
            this.dgvPessoasFisicas.RowTemplate.Height = 24;
            this.dgvPessoasFisicas.Size = new System.Drawing.Size(801, 375);
            this.dgvPessoasFisicas.TabIndex = 15;
            this.dgvPessoasFisicas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoasFisicas_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(296, 230);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(203, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 31);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(203, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(478, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "E-mail:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(203, 107);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(168, 27);
            this.txtDataNascimento.TabIndex = 7;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nascido em:";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(513, 25);
            this.txtRG.Mask = "000000000000";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(168, 27);
            this.txtRG.TabIndex = 3;
            this.txtRG.ValidatingType = typeof(int);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(470, 28);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(39, 20);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(203, 25);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(168, 27);
            this.txtCPF.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(203, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(478, 27);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(83, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(83, 28);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(110, 20);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "Digite o CPF:";
            // 
            // vwPessoaFisicaBindingSource
            // 
            this.vwPessoaFisicaBindingSource.DataSource = typeof(AulasRADMDIBD.Modelo.VwPessoaFisica);
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn.Visible = false;
            this.idPessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 125;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            this.rGDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmCadPessoasFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 675);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.dgvPessoasFisicas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Name = "FrmCadPessoasFisicas";
            this.Text = "Cadastro de Pessoas Físicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasFisicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPessoaFisicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridView dgvPessoasFisicas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.BindingSource vwPessoaFisicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}