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
    
    public partial class TB_FERIADO
    {
        public int ID_FERIADO { get; set; }
        public System.DateTime DT_FERIADO { get; set; }
        public string AN_DESCRICAO { get; set; }
        public Nullable<System.DateTime> DT_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DT_INCLUSAO { get; set; }
        public string CD_USUARIO_INC { get; set; }
        public string CD_USUARIO_ALT { get; set; }
    }
}
