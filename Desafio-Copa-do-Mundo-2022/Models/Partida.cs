using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("partidas")]
    public class Partida
    {
        [Key]
        [Column(name: "id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(name: "fases_id")]
        [ForeignKey("Fase")]
        public int FasesId { get; set; }
        public virtual Fase Fase { get; set; }

        [Required]
        [Column(name: "data_hora")]
        public DateTime DataHora { get; set; }

        [Column(name: "iniciado")]
        public byte? Iniciado { get; set; }

        [Column(name: "finalizado")]
        public byte? Finalizado { get; set; }
        public ICollection<PartidaClube> PartidasClubes { get; set; }

    }
}