namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DIC_DADOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CD_MODULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string CD_TABELA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string CD_CAMPO { get; set; }

        [StringLength(45)]
        public string IN_TP_DADO { get; set; }

        [StringLength(45)]
        public string IN_TP_OBJETO { get; set; }

        [StringLength(255)]
        public string DS_CAMPO { get; set; }

        [StringLength(2000)]
        public string AN_HELP { get; set; }

        public int? FL_OBRIGATORIO { get; set; }
    }
}
