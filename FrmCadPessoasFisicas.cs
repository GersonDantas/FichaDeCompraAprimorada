using AulasRADMDIBD.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AulasRADMDIBD
{
    public partial class FrmCadPessoasFisicas : Form
    {
        private int idSelecionado = 0;
        public FrmCadPessoasFisicas()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            using (var db = new BdAppContext())
            {
                vwPessoaFisicaBindingSource.DataSource = db.VwPessoasFisicas.ToList();
            }
        }

        private void Salvar() {
            if (!ValidarForm()) { return; }
            using (var db = new BdAppContext())
            {
                //Testa se é para inserir ou atualizar:
                if (idSelecionado == 0) { Inserir(db); }
                else { Atualizar(db); }
            }
        }
        private void Atualizar(BdAppContext db) {
            var p = db.PessoasFisicas.Find(idSelecionado);
            if (p == null) {
                MessageBox.Show("Identificador inválido. Repita a operação."); return;
            }
            p.Pessoa.Nome = txtNome.Text;
            p.Pessoa.Email = txtEmail.Text;
            p.Pessoa.Telefone = txtTelefone.Text;
            p.CPF = txtCPF.Text.Replace(".", "").Replace("-", "");
            p.RG = txtRG.Text.Replace(".", "").Replace("-", "");
            p.DataNascimento = txtDataNascimento.Text;
            db.SaveChanges();
            //Prepara o formulário para o cadastro:
            Listar();
            Limpar();
            MessageBox.Show("Dados atualizados com sucesso.");
        }

        private void Inserir(BdAppContext db) {
            var p = new PessoaFisica();
            p.Pessoa = new Pessoa() { Nome = txtNome.Text, Email = txtEmail.Text, Telefone = txtTelefone.Text };
            p.CPF = txtCPF.Text.Replace(".", "").Replace("-", "");
            p.RG = txtRG.Text.Replace(".", "").Replace("-", "");
            p.DataNascimento = txtDataNascimento.Text;
            db.PessoasFisicas.Add(p);
            db.SaveChanges();
            //Prepara o formulário para o cadastro:
            Listar();
            Limpar();
            MessageBox.Show("Dados registrados com sucesso.");
        }
        private void Limpar() {
            idSelecionado = 0;
            txtCPF.Text = "";
            txtRG.Text = "";
            txtDataNascimento.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCPF.Focus();
            btnExcluir.Enabled = false;
            dgvPessoasFisicas.ClearSelection();
        }

        private bool ValidarForm()
        {
            if (txtCPF.Text.Trim().Length < 11)
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }
            if (txtRG.Text.Trim() == "")
            {
                MessageBox.Show("RG inválido.");
                return false;
            }
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome inválido.");
                return false;
            }
            if (txtDataNascimento.Text.Trim() == "")
            {
                MessageBox.Show("Data de Nascimento inválida.");
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("E-mail inválido.");
                return false;
            }
            if (txtTelefone.Text.Trim() == "")
            {
                MessageBox.Show("Telefone inválida.");
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvPessoasFisicas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Recupera o id da pessoa selecionada:
            Limpar();
            idSelecionado = int.Parse(dgvPessoasFisicas.Rows[e.RowIndex].Cells[0].Value.ToString());
            Selecionar(idSelecionado);
        }
        private void Selecionar(int id) {
            if (id < 1) {
                MessageBox.Show("Identificador inválido. Repita a operação."); return;
            }
            using (var db = new BdAppContext())
            {
                var p = db.PessoasFisicas.Find(id);
                if (p == null)  {
                    MessageBox.Show("Identificador inválido. Repita a operação."); return;
                }
                txtCPF.Text = p.CPF;
                txtRG.Text = p.RG;
                txtDataNascimento.Text = p.DataNascimento;
                txtNome.Text = p.Pessoa.Nome;
                txtEmail.Text = p.Pessoa.Email;
                txtTelefone.Text = p.Pessoa.Telefone;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Exclusão de registro", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new BdAppContext())
                {
                    var p = db.PessoasFisicas.Find(idSelecionado);
                    if (p == null)
                    {
                        MessageBox.Show("Identificador inválido. Repita a operação.");
                        return;
                    }
                    db.PessoasFisicas.Remove(p);
                    db.SaveChanges();
                    //Prepara o formulário para o cadastro:
                    Listar();
                    Limpar();
                    MessageBox.Show("Dados excluídos com sucesso.");
                }
            }
        }
    }
}
