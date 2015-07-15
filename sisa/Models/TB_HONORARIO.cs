namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_HONORARIO
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
        public int SQ_HONORARIOS { get; set; }

        public decimal? VL_HONORARIOS { get; set; }

        public int? NR_DOC_NF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENVIO_BANCO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_MOVIMENTO { get; set; }

        public int? FL_REEMBOLSAVEL { get; set; }

        [StringLength(100)]
        public string NM_CLIENTE { get; set; }

        [StringLength(255)]
        public string TX_OBS { get; set; }

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
