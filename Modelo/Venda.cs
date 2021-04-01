using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("venda")]
    public class Venda
    {
        [ForeignKey("PessoaFisica")]
        [Key]
        public int IdProduto { get; set; }
        public string Data { get; set; }
        public float Total { get; set; }
        public int IdCliente { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; } 
    }
}
