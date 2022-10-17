using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("clubes")]
    public class Clube
    {
        [Key]
        [Column(name: "id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(name: "nome")]
        [MaxLength(80)]
        public string Nome { get; set; }

        [Column(name: "descricao")]
        [MaxLength(250)]
        public string Descricao { get; set; }

        [Required]
        [Column(name: "url_bandeira")]
        [MaxLength(250)]
        public string UrlBandeira { get; set; }

        [Required]
        [Column(name: "grupos_id")]
        [ForeignKey("Grupo")]
        public int GruposId { get; set; }
        public virtual Grupo Grupo { get; set; }

        public ICollection<PartidaClube> PartidasClubesA { get; set; }
        public ICollection<PartidaClube> PartidasClubesB { get; set; }
    }
}