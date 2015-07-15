namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_NOTIFICACAO
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
        public int SQ_NOTIFICACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_GERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENVIO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_RETORNO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_RESPOSTA { get; set; }

        [StringLength(35)]
        public string AN_TIPO_NOTIFICACAO { get; set; }

        public decimal? VL_NOTIFICACAO { get; set; }

        public int? NR_NOTIFICACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PAGTO_NOTIFICACAO { get; set; }

        public int? NR_PARCELA { get; set; }

        [StringLength(25)]
        public string AN_RESULTADO { get; set; }

        public int? NR_RETORNO { get; set; }

        [StringLength(1)]
        public string AN_RENOTIFICACAO { get; set; }

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
