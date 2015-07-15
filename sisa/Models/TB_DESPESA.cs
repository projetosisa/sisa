namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DESPESA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_CLIENTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NR_OPERACAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SQ_DESPESA { get; set; }

        [StringLength(100)]
        public string DS_DESPESA { get; set; }

        public int? FL_COMPENSACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_COMPENSACAO { get; set; }

        public int? NR_PARCELA { get; set; }

        [StringLength(6)]
        public string CD_DESPESA { get; set; }

        public decimal? VL_DESPESA { get; set; }

        public int? FL_STATUS_PGTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PAGTO { get; set; }

        public int? NR_DOC_NF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENVIO_BANCO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PAGTO_PREST { get; set; }

        public int? NR_EMPRESA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_MOVIMENTO { get; set; }

        public decimal? NR_CGC_CARTORIO { get; set; }

        public int? NR_LOTE_INTERNO { get; set; }

        public decimal? NR_VALE { get; set; }

        [StringLength(500)]
        public string AN_JUSTIFICATIVA_MANUAL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_JUSTIFICATIVA { get; set; }

        public int? NR_BORDERO { get; set; }

        [StringLength(20)]
        public string AN_GRERJ { get; set; }

        [StringLength(35)]
        public string AN_PROCESSO { get; set; }

        [StringLength(80)]
        public string NM_COMARCA { get; set; }

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
