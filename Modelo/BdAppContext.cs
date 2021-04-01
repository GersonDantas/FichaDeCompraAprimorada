using System.Data.Entity;

namespace AulasRADMDIBD.Modelo
{
    class BdAppContext : DbContext
    {
        public BdAppContext() : base("BdAppConStr")
        {
        }

        public DbSet<CategoriaProduto> CategoriasProdutos { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoVenda> ProdutosVendas { get; set; }        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }        
        public DbSet<VwPessoaFisica> VwPessoasFisicas { get; set; }
    }
}