using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("administradores")]
    public class Administrador
    {
        [Key]
        [Column(name: "id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(name: "nome")]
        [MaxLength(80)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Column(name: "email")]
        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [Column(name: "senha")]
        [MaxLength(50)]
        public string Senha { get; set; }
    }
}