using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    [Table("Pessoa_PF")]
    public abstract class Pessoa
    {
        [Key]
        [Column("Id")]
        public int PessoaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DataNascimento { get; set; }
    }
}
