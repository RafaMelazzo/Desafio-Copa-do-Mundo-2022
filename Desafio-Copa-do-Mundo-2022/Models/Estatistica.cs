using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("estatisticas")]
    public class Estatistica
    {
        [Key]
        [Column(name: "id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(name: "partidas_id")]
        [ForeignKey("Partida")]
        public int PartidaId { get; set; }
        [JsonIgnore]
        public virtual Partida Partida { get; set; }

        [Required]
        [Column(name: "clubes_id")]
        [ForeignKey("Clube")]
        public int ClubesId { get; set; }
        [JsonIgnore]
        public virtual Clube Clube { get; set; }

        [Column(name: "chutes")]
        public int? Chutes { get; set; }

        [Column(name: "chutes_a_gol")]
        public int? ChutesAGol { get; set; }

        [Column(name: "posse_de_bola")]
        public int? PosseDeBola { get; set; }

        [Column(name: "passes")]
        public int? Passes { get; set; }

        [Column(name: "precisao_de_passes")]
        public int? PrecisaoDePasses { get; set; }

        [Column(name: "faltas")]
        public int? Faltas { get; set; }

        [Column(name: "cartoes_amarelos")]
        public int? CartoesAmarelos { get; set; }

        [Column(name: "cartoes_vermelhos")]
        public int? CartoesVermelhos { get; set; }

        [Column(name: "impedimentos")]
        public int? Impedimentos { get; set; }

        [Column(name: "escanteios")]
        public int? Escanteios { get; set; }
    }
}