namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_USUARIO
    {
        [Key]
        public int ID_USUARIO { get; set; }

        public int? GRUPO_USUARIO { get; set; }

        [StringLength(50)]
        public string CD_USUARIO { get; set; }

        [StringLength(20)]
        public string AN_SENHA { get; set; }

        [StringLength(15)]
        public string IN_NIVEL { get; set; }

        [StringLength(100)]
        public string NM_NOME { get; set; }

        [StringLength(60)]
        public string AN_EMAIL { get; set; }

        public int? CD_HORARIO { get; set; }

        public int? FL_LOCALIZADOR { get; set; }

        public int? FL_PESQUISA { get; set; }

        public int? FL_GESTOR { get; set; }

        public int? FL_ADVOGADO { get; set; }

        public int? FL_ACIONADOR { get; set; }

        public int? FL_FINANCEIRO { get; set; }

        public int? FL_ADMINISTRADOR { get; set; }

        public int? FL_LIBERA_HONORARIOS { get; set; }

        public int? FL_IMPRIME_RECIBO { get; set; }

        public int? FL_ATIVO { get; set; }

        public int? FL_TROCA_SENHA { get; set; }

        public int? FL_INCLUI_ALTERA_PARCELA { get; set; }

        public int? FL_ALTERA_DADOS_ACORDO { get; set; }

        public int? FL_EXCLUI_CLIENTE { get; set; }

        public int? FL_IMPRIME_BOLETO { get; set; }

        public int? FL_BASE_ELETRONICA { get; set; }

        public int? FL_EMITE_MINUTAS { get; set; }

        public int? FL_EXCLUI_DADOS_PROCESSO { get; set; }

        public int? FL_AUTORIZA_DESCONTO { get; set; }

        public int? FL_LIBERA_CUSTAS { get; set; }

        public int? FL_LIBERA_ESTORNO_PAGAMENTO { get; set; }

        public int? QT_EVENTOS_DIA { get; set; }

        [StringLength(8)]
        public string TEMPO_EVENTOS_DIA { get; set; }

        public int? QT_BOLETOS_DIA { get; set; }

        public decimal? VL_META { get; set; }

        public int? NR_FILIAL { get; set; }

        [StringLength(50)]
        public string AN_GESTOR { get; set; }

        [StringLength(100)]
        public string NM_CEDENTE { get; set; }

        [StringLength(100)]
        public string AN_CIDADE { get; set; }

        [StringLength(100)]
        public string AN_ENDERECO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERA_SENHA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(50)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(50)]
        public string CD_USUARIO_ALT { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_ALFA { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_DAYCOVAL { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_FICSA { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_OMNI { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_RENNER { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_SULFINANCEIRA { get; set; }

        [StringLength(1)]
        public string FL_ACESSA_OUTROBANCOS { get; set; }

        public decimal? VL_META_ALFA { get; set; }

        public decimal? VL_META_DAYCOVAL { get; set; }

        public decimal? VL_META_FICSA { get; set; }

        public decimal? VL_META_RENNER { get; set; }

        public decimal? VL_META_OMNI { get; set; }

        public decimal? VL_META_SULFINANCEIRA { get; set; }

        public decimal? VL_META_OUTROSBANCOS { get; set; }

        public int? NR_RECIBO { get; set; }

        public int? NR_BOLETO { get; set; }

        [StringLength(20)]
        public string NR_CNPJ_CARTORIO { get; set; }

        public int? FL_EXCLUI_PARCELA { get; set; }

        [StringLength(50)]
        public string AN_TIPO_SELECAO { get; set; }
    }
}
