using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("produto")]
    public class Produto
    {
        [ForeignKey("CategoriaProduto")]
        [Key]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int IdCategoria { get; set; }
        public virtual CategoriaProduto CategoriaProduto { get; set; } 
    }
}
