using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Policy;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("partidas_clubes")]
    [Keyless]
    [Index(nameof(PartidaId), IsUnique = true)]
    public class PartidaClube
    {
        [Required]
        [Column(name: "partidas_id")]
        [ForeignKey("Partida")]
        public int PartidaId { get; set; }
        public Partida Partida { get; set; }

        [ForeignKey("Clube")]
        [NotMapped]
        public virtual int ClubeIdA { get; set; }
        [Required]
        public Clube ClubeA { get; set; }

        [ForeignKey("Clube")]
        [NotMapped]
        public virtual int ClubeIdB { get; set; }
        [Required]
        public Clube ClubeB { get; set; }
    }
}