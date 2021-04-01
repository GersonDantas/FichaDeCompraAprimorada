using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasRADMDIBD.Modelo
{
    [Table("usuario")]
    public class Usuario
    {
        [ForeignKey("PessoaFisica")]
        [Key]
        public int IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; } 
    }
}
