using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("pessoajuridica")]
    public class PessoaJuridica
    {
        [ForeignKey("Pessoa")]
        [Key]
        public int IdPessoa { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public virtual Pessoa Pessoa { get; set; } 
    }
}
