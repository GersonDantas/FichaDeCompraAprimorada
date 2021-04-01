using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
