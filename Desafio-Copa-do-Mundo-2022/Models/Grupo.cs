using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("grupos")]
    public class Grupo
    {
        [Key]
        [Column(name: "id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(name: "nome")]
        [MaxLength(1)]
        public char Nome { get; set; }
    }
}