using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("categoriaproduto")]
    public class CategoriaProduto
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}
