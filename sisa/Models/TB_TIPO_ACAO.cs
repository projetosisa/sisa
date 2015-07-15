namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TIPO_ACAO
    {
        [Key]
        public int ID_TIPO_ACAO { get; set; }

        [StringLength(150)]
        public string AN_TIPO_ACAO { get; set; }

        [StringLength(1)]
        public string AN_TIPO { get; set; }
    }
}
