//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_CONTRATOS
    {
        public int ID_CONTRATO { get; set; }
        public int CD_CLIENTE { get; set; }
        public int ID_BANCO { get; set; }
        public Nullable<int> NR_OPERACAO { get; set; }
        public string CD_CONTRATO { get; set; }
        public string AN_INFORMATIVO { get; set; }
        public Nullable<System.DateTime> DT_CONTRATO { get; set; }
        public string IN_TP_CONTRATO { get; set; }
        public Nullable<int> CD_PRODUTO { get; set; }
        public string AN_TX_OBJETO { get; set; }
        public string AN_TX_BASE_JUDICIAL { get; set; }
        public Nullable<System.DateTime> DT_ENVIO_CONTRATO { get; set; }
        public Nullable<System.DateTime> DT_PRIM_NOTIFICACAO { get; set; }
        public Nullable<System.DateTime> DT_NOTIFICACAO { get; set; }
        public Nullable<System.DateTime> DT_SERASA { get; set; }
        public Nullable<System.DateTime> DT_SOLIC_DOC { get; set; }
        public Nullable<int> FL_CONF_DIVIDA { get; set; }
        public Nullable<System.DateTime> DT_CONF_DIVIDA { get; set; }
        public Nullable<decimal> VL_TOT_CONTRATO { get; set; }
        public Nullable<int> NR_PARCELAS { get; set; }
        public Nullable<decimal> VL_PARCELA { get; set; }
        public Nullable<System.DateTime> DT_PRIM_VENCTO { get; set; }
        public Nullable<System.DateTime> DT_ULT_VENCTO { get; set; }
        public Nullable<decimal> VL_SALDO_DEVEDOR { get; set; }
        public Nullable<decimal> VL_ACAO { get; set; }
        public Nullable<decimal> VL_VENCIDO { get; set; }
        public Nullable<decimal> VL_TAXA_FINANCIAMENTO { get; set; }
        public Nullable<decimal> VL_INDICE_MOEDA { get; set; }
        public Nullable<decimal> VL_RISCO { get; set; }
        public Nullable<decimal> VL_RISCO_TOTAL { get; set; }
        public Nullable<decimal> VL_CARTEIRA { get; set; }
        public string IN_FAIXA { get; set; }
        public string NR_ACORDO { get; set; }
        public Nullable<System.DateTime> DT_INDICACAO { get; set; }
        public string NR_PASTA { get; set; }
        public string TX_OBSERVACAO_JUIZO { get; set; }
        public Nullable<int> FL_ALEGA_ACAOCONTRA { get; set; }
        public Nullable<int> CD_ADVOGADO { get; set; }
        public Nullable<int> CD_BANRISUL { get; set; }
        public Nullable<int> FL_EXCLUIDO { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public Nullable<System.DateTime> DT_INCLUSAO { get; set; }
        public string NM_ARQUIVO { get; set; }
        public Nullable<System.DateTime> DT_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO { get; set; }
        public string CD_USUARIO_EXC { get; set; }
        public string CD_USUARIO_ALT { get; set; }
        public Nullable<int> NR_PARCELAS_PAGAS { get; set; }
        public string CD_BANCO { get; set; }
        public string DS_BANCO { get; set; }
        public string AN_ENDERECO { get; set; }
        public string AN_CIDADE { get; set; }
        public string CD_UF { get; set; }
        public string AN_CNPJ { get; set; }
        public string AN_INS_EST { get; set; }
        public string CD_AGENCIA { get; set; }
        public string CD_CEDENTE { get; set; }
        public Nullable<double> FT_IND_BANCO { get; set; }
        public Nullable<double> FT_IND_JURIDICO { get; set; }
        public Nullable<decimal> FT_IND_DESCONTO { get; set; }
        public Nullable<decimal> FT_IND_JUROS { get; set; }
        public Nullable<decimal> VL_ENCARGOS { get; set; }
        public Nullable<decimal> VL_ESCRITORIO { get; set; }
        public Nullable<decimal> VL_NOTIFICACAO { get; set; }
        public Nullable<decimal> VL_HONORARIOS { get; set; }
        public Nullable<int> QT_DIAS_NOTIFICACAO { get; set; }
        public Nullable<int> NR_RECIBO { get; set; }
        public Nullable<int> NR_BOLETO { get; set; }
        public Nullable<int> NR_BORDERO { get; set; }
        public Nullable<int> NR_NOTIFICACAO { get; set; }
        public Nullable<int> NR_LOTE { get; set; }
        public Nullable<int> QT_DIAS_AJUIZAMENTO { get; set; }
        public Nullable<int> QT_DIAS_CARTORIO { get; set; }
        public Nullable<decimal> VL_META { get; set; }
        public Nullable<decimal> VL_LOCALIZADOR { get; set; }
        public Nullable<decimal> VL_MULTA { get; set; }
        public string CD_USUARIO_INC { get; set; }
    }
}
