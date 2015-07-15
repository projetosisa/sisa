namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_BOLETO
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
        public int NR_PARCELA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string CD_BOLETO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PREV_DEPOSITO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_VCTO { get; set; }

        public decimal? VL_TITULO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PAGTO { get; set; }

        public decimal? VL_ENCARGOS { get; set; }

        public decimal? VL_ESCRITORIO { get; set; }

        public decimal? VL_NOTIFICACAO { get; set; }

        public decimal? VL_HONORARIOS { get; set; }

        public decimal? VL_CPMF { get; set; }

        public decimal? VL_LOCALIZADOR { get; set; }

        public decimal? VL_CUSTAS { get; set; }

        public decimal? VL_DESP_EXTRA { get; set; }

        public decimal? VL_DESPESA { get; set; }

        public decimal? VL_TARIFA_BANCARIA { get; set; }

        public decimal? VL_MULTA { get; set; }

        public decimal? VL_PAGTO_S_HONO { get; set; }

        public decimal? VL_PAGTO_C_HONO { get; set; }

        public decimal? VL_DESCONTO { get; set; }

        public decimal? VL_TOTAL { get; set; }

        public decimal? FT_IND_DESCONTO { get; set; }

        public decimal? VL_POR_DIA { get; set; }

        public decimal? VL_JUROS { get; set; }

        public decimal? FT_IND_BANCO { get; set; }

        public decimal? FT_IND_JURIDICO { get; set; }

        public decimal? VL_COMISSIONAMENTO { get; set; }

        public decimal? VL_COMISS_PERM { get; set; }

        [StringLength(15)]
        public string VL_TOTAL_GERAL { get; set; }

        public int? NR_DIAS_ATRASO { get; set; }

        [StringLength(1000)]
        public string TX_OBSERVACAO { get; set; }

        [StringLength(1000)]
        public string TX_OBSERVACAO2 { get; set; }

        [StringLength(1000)]
        public string TX_OBSERVACAO3 { get; set; }

        [StringLength(50)]
        public string AN_TX_CONTRATO { get; set; }

        public int? NR_LOTE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENTRADA { get; set; }

        public int? FL_IMPRIMIR { get; set; }

        [StringLength(35)]
        public string CD_USUARIO { get; set; }

        [StringLength(10)]
        public string AN_CAMPO_1 { get; set; }

        [StringLength(1)]
        public string AN_DIGITO_1 { get; set; }

        [StringLength(11)]
        public string AN_CAMPO_2 { get; set; }

        [StringLength(1)]
        public string AN_DIGITO_2 { get; set; }

        [StringLength(11)]
        public string AN_CAMPO_3 { get; set; }

        [StringLength(1)]
        public string AN_DIGITO_3 { get; set; }

        [StringLength(1)]
        public string AN_DIGITO_GERAL { get; set; }

        [StringLength(50)]
        public string AN_CODIGO_BARRA { get; set; }

        [StringLength(15)]
        public string CD_AGENCIA { get; set; }

        [StringLength(15)]
        public string CD_CEDENTE { get; set; }

        [StringLength(100)]
        public string NM_CEDENTE { get; set; }

        [StringLength(55)]
        public string CD_REPR_NUMERICA { get; set; }

        [StringLength(1)]
        public string IN_TIPO_BLOQUETO { get; set; }

        [StringLength(3)]
        public string CD_ERRO { get; set; }

        [StringLength(100)]
        public string AN_DESCR_ERRO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_RETORNO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_BOLETO_PAGO { get; set; }

        [StringLength(2)]
        public string IN_TIPO_COMISS { get; set; }

        public int? NR_INCONSISTENCIA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_CONFIRMA_PAGTO { get; set; }

        public int? IN_FAX_TRANSMITIDO { get; set; }

        [StringLength(50)]
        public string NR_FAX { get; set; }

        [StringLength(20)]
        public string AN_DESCR_BOLETO { get; set; }

        [StringLength(1000)]
        public string AN_CONTRATOS_BOLETO { get; set; }

        [StringLength(1000)]
        public string AN_PARCELAS_BOLETO { get; set; }

        [StringLength(5)]
        public string AN_COD_AUTORIZACAO { get; set; }

        [StringLength(20)]
        public string CD_PROGRAMA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_EXCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_EXC { get; set; }
    }
}
