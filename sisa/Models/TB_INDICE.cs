namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_INDICE
    {
        [Key]
        public int ID_INDICE { get; set; }

        [Required]
        [StringLength(255)]
        public string NM_BANCO { get; set; }

        [Required]
        [StringLength(35)]
        public string TIPO { get; set; }

        [Required]
        [StringLength(15)]
        public string INTERVALO { get; set; }

        public decimal? FT_DESC_PARCELA { get; set; }

        public decimal? FT_DESC_PRINCIPAL { get; set; }

        public decimal? FT_JUROS { get; set; }

        public decimal? FT_MULTA { get; set; }

        public decimal? FT_HONORARIOS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }
    }
}
