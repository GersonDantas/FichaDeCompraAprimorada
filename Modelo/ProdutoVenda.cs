using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("produtovenda")]
    public class ProdutoVenda
    {
        [ForeignKey("CategoriaProduto")]
        [Key]
        public int IdProduto { get; set; }
        [Key]
        public int IdVenda { get; set; }
        public float Quantidade { get; set; }
        public float TotalItem { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
