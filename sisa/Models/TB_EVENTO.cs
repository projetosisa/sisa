namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_EVENTO
    {
        [Key]
        public int ID_EVENTO { get; set; }

        public int CD_CLIENTE { get; set; }

        public int NR_OPERACAO { get; set; }

        [Required]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [Required]
        [StringLength(50)]
        public string NM_BANCO { get; set; }

        public int NR_PARCELA { get; set; }

        [Required]
        [StringLength(35)]
        public string CD_USUARIO_RESP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DT_EVENTO { get; set; }

        [Required]
        [StringLength(8)]
        public string HR_EVENTO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_OPER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_EVENTO_REAL { get; set; }

        [StringLength(8)]
        public string HR_INI { get; set; }

        [StringLength(8)]
        public string HR_FIM { get; set; }

        [StringLength(10)]
        public string IN_SIT_CONTATO { get; set; }

        [StringLength(6)]
        public string CD_TIPO_EVENTO { get; set; }

        [StringLength(255)]
        public string AN_DS_EVENTO_ASSUNTO { get; set; }

        [StringLength(1000)]
        public string AN_OBS_EVENTO_ASSUNTO { get; set; }

        public int? NR_PRIORIDADE { get; set; }

        [StringLength(8)]
        public string HR_TEMPO_LIGACAO { get; set; }

        [StringLength(8)]
        public string HR_HORA_MARCADA { get; set; }

        public int? FL_EXPORTADO_EVENTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENVIO_BANCO { get; set; }

        [StringLength(50)]
        public string AN_ARQUIVO_ENVIO { get; set; }

        [StringLength(5)]
        public string NR_DDD { get; set; }

        [StringLength(25)]
        public string NR_TELEFONE { get; set; }

        [StringLength(1)]
        public string IN_LIGACAO_EFETUADA { get; set; }

        [StringLength(50)]
        public string AN_STATUS { get; set; }

        [StringLength(50)]
        public string AN_SITUACAO_CONTRATO { get; set; }

        [StringLength(50)]
        public string CD_PROGRAMA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USARIO_ALT { get; set; }
    }
}
