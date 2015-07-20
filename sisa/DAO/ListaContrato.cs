using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisa.DAO
{
    using System;
    using System.Collections.Generic;
    public class ListaContrato : List<ListaContrato>
    {
        public int ID_CONTRATO { get; set; }
        public int CD_CLIENTE { get; set; }
        public int CD_BANCO { get; set; }
        public string BANCO { get; set; }
        public string TP_CONTRATO { get; set; }
        public Nullable<decimal> VL_TOT_CONTRATO { get; set; }
        
    }
}