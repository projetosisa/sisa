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
    
    public partial class vw_busca_cliente_banco
    {
        public int CD_CLIENTE { get; set; }
        public Nullable<int> Contratos_Excluidos { get; set; }
        public Nullable<int> Contratos_Ativos { get; set; }
        public Nullable<int> Contratos_Total { get; set; }
        public string AN_CNPJ_CPF { get; set; }
        public string NM_PESSOA { get; set; }
        public string NM_BANCO { get; set; }
        public string CD_USUARIO_RESP { get; set; }
        public int Expr1 { get; set; }
    }
}
