namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UF
    {
        [Key]
        [StringLength(2)]
        public string AN_ESTADO { get; set; }

        [StringLength(50)]
        public string NM_ESTADO { get; set; }
    }
}
