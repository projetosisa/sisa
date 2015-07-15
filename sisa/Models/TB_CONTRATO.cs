namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CONTRATO
    {
        [Key]
        public int ID_CONTRATO { get; set; }

        public int CD_CLIENTE { get; set; }

        [StringLength(50)]
        public string NM_BANCO { get; set; }

        public int? NR_OPERACAO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(25)]
        public string CD_USUARIO_RESP { get; set; }

        [StringLength(1)]
        public string IN_J_A { get; set; }

        [StringLength(100)]
        public string AN_INFORMATIVO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_CONTRATO { get; set; }

        public int? NR_PARCELAS { get; set; }

        [StringLength(40)]
        public string IN_TP_CONTRATO { get; set; }

        public int? CD_PRODUTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENVIO_CONTRATO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PRIM_NOTIFICACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_NOTIFICACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_SERASA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_SOLIC_DOC { get; set; }

        public int? FL_CONF_DIVIDA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_CONF_DIVIDA { get; set; }

        public decimal? VL_TOT_CONTRATO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PRIM_VENCTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ULT_VENCTO { get; set; }

        public decimal? VL_SALDO_DEVEDOR { get; set; }

        public decimal? VL_TAXA_FINANCIAMENTO { get; set; }

        public decimal? VL_INDICE_MOEDA { get; set; }

        [StringLength(15)]
        public string IN_FAIXA { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(1000)]
        public string TX_OBSERVACAO_JUIZO { get; set; }

        public int? FL_ALEGA_ACAO { get; set; }

        [StringLength(50)]
        public string NM_ARQUIVO { get; set; }

        public int? CD_ADVOGADO { get; set; }

        public int? CD_BANRISUL { get; set; }

        public int? FL_EXCLUIDO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_EXCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_EXC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }

        public int? NR_PARCELAS_PAGAS { get; set; }
    }
}
