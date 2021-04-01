using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("pessoafisica")]
    public class PessoaFisica
    {
        [ForeignKey("Pessoa")]
        [Key]
        public int IdPessoa { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
        public virtual Pessoa Pessoa { get; set; } 
    }
}
