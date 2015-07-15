namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PROCESSO
    {
        [Key]
        public int ID_PROCESSO { get; set; }

        public int CD_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NM_BANCO { get; set; }

        public int? NR_OPERACAO { get; set; }

        [Required]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [Required]
        [StringLength(45)]
        public string AN_PROCESSO { get; set; }

        [Required]
        [StringLength(26)]
        public string AN_CNJ { get; set; }

        [Required]
        [StringLength(150)]
        public string IN_TP_ACAO { get; set; }

        [Required]
        [StringLength(6)]
        public string IN_TP_PROCESSO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DT_CADASTRO { get; set; }

        [Required]
        [StringLength(150)]
        public string NM_AUTOR { get; set; }

        [Required]
        [StringLength(150)]
        public string NM_REU { get; set; }

        public int? CD_ADVOGADO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_DISTRIBUICAO { get; set; }

        [Required]
        [StringLength(2)]
        public string AN_ESTADO { get; set; }

        [StringLength(100)]
        public string NM_COMARCA { get; set; }

        public decimal? VL_CUSTAS { get; set; }

        [StringLength(100)]
        public string CD_VARA { get; set; }

        public decimal? VL_ACAO { get; set; }

        [StringLength(10)]
        public string IN_CHANCE_PERDA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_COPIA_RECEB { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ORIGINAL_RECEB { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_MINUTA_PROTOCOL { get; set; }

        [StringLength(50)]
        public string IN_FASE_PROCESSUAL { get; set; }

        [StringLength(255)]
        public string IN_LIMINAR { get; set; }

        public int? QT_ALVARA_LEV { get; set; }

        public decimal? VL_ALVARA_LEV { get; set; }

        public decimal? VL_TOT_ALVARA_LEV { get; set; }

        public int? QT_DEPOSITO_DEP { get; set; }

        public decimal? VL_DEPOSITO_DEP { get; set; }

        [StringLength(50)]
        public string IN_TIPO_ACORDO { get; set; }

        public decimal? VL_TOTAL_ACORDO { get; set; }

        public decimal? VL_ENTRADA_ACORDO { get; set; }

        public int? QT_PARCELAS_ACORDO { get; set; }

        public decimal? VL_PARCELA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_VCTO { get; set; }

        [StringLength(200)]
        public string AN_SITUACAO_ACORDO { get; set; }

        [StringLength(100)]
        public string AN_PRESTACAO_CONTAS { get; set; }

        [StringLength(50)]
        public string AN_INSTANCIA { get; set; }

        [StringLength(50)]
        public string AN_AGRAVO { get; set; }

        public decimal? VL_PROVISIONAMENTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_AUDIENCIA { get; set; }

        [StringLength(100)]
        public string AN_RAZAO_ENCERRAMENTO { get; set; }

        [StringLength(100)]
        public string AN_VL_CONDENACAO { get; set; }

        [StringLength(50)]
        public string AN_IDENTIFICACAO_ALVARA { get; set; }

        [StringLength(500)]
        public string AN_SITUACAO_PROCESSUAL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ANDAMENTO { get; set; }

        [StringLength(50)]
        public string AN_TIPO_ENVIO { get; set; }

        public int? NR_CODIGO { get; set; }

        [StringLength(100)]
        public string AN_SENTENCA { get; set; }

        [StringLength(200)]
        public string AN_VL_DISCUTIDO_EXTRA { get; set; }

        [StringLength(100)]
        public string AN_OBSERVACAO { get; set; }

        [StringLength(1000)]
        public string AN_VL_ENTRADA_ACORDO_ESP { get; set; }

        [StringLength(100)]
        public string AN_FASE { get; set; }

        public decimal? VL_ALVARA_ACORDO { get; set; }

        [StringLength(50)]
        public string AN_SPC_SERASA { get; set; }

        [StringLength(3)]
        public string IN_RET_ACAO_COB { get; set; }

        [StringLength(3)]
        public string IN_PEND_LIQ_SENT { get; set; }

        [StringLength(100)]
        public string AN_PROVIDENCIAS { get; set; }

        [StringLength(100)]
        public string AN_DESCRICAO { get; set; }

        [StringLength(200)]
        public string AN_VL_ALVARA_EXTRA { get; set; }

        [StringLength(50)]
        public string AN_SITUACAO_PROCESSO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENCERRAMENTO { get; set; }

        [StringLength(45)]
        public string AN_SETOR_RESPONSAVEL { get; set; }

        [StringLength(50)]
        public string AN_JUSTICA { get; set; }

        [StringLength(50)]
        public string NR_PASTA { get; set; }

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
