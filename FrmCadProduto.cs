using AulasRADMDIBD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulasRADMDIBD
{
    public partial class FrmCadProduto : Form
    {
        public FrmCadProduto()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            using (var db = new BdAppContext())
            {
                categoriaProdutoBindingSource.DataSource = db.CategoriasProdutos.ToList();
            }
        }
    }
}
