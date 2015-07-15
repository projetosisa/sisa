namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ACORDO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_CLIENTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NM_BANCO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NR_OPERACAO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NR_PARCELA { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string NR_ACORDO { get; set; }

        [StringLength(8)]
        public string CD_BOLETO { get; set; }

        [StringLength(100)]
        public string NM_CLIENTE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_VCTO { get; set; }

        public decimal? VL_TITULO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PAGTO { get; set; }

        public decimal? VL_HONORARIOS { get; set; }

        public decimal? VL_CUSTAS { get; set; }

        public decimal? VL_TARIFA { get; set; }

        public decimal? VL_TOTAL_GERAL { get; set; }

        [StringLength(1000)]
        public string TX_OBSERVACAO { get; set; }

        [StringLength(15)]
        public string AN_TIPO_PAGTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ACORDO { get; set; }

        [StringLength(8)]
        public string HR_ACORDO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ACORDO { get; set; }

        public decimal? VL_BANCO { get; set; }

        public decimal? VL_REPASSE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_REPASSE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? HR_REPASSE { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_REPASSE { get; set; }

        [StringLength(50)]
        public string AN_TIPO_ACORDO { get; set; }

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
