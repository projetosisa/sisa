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
    
    public partial class TB_CONTRATO
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
    }
}
