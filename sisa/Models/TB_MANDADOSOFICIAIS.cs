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
    
    public partial class TB_MANDADOSOFICIAIS
    {
        public int ID_MANDADO { get; set; }
        public int ID_PROCESSO { get; set; }
        public int CD_CLIENTE { get; set; }
        public int ID_CONTRATO { get; set; }
        public string NR_MANDADO { get; set; }
        public string TIPO_MANDADO { get; set; }
        public string DESTINATARIO_MANDADO { get; set; }
        public string OFICIAL_MANDADO { get; set; }
        public Nullable<System.DateTime> DATA_REC_MANDADO { get; set; }
        public Nullable<System.DateTime> DATA_DEV_MANDADO { get; set; }
        public string RESULTADO_MANDADO { get; set; }
        public string VLR_CONDUCAO_MANDADO { get; set; }
    }
}
