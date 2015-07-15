namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_COD_DESPESA
    {
        [Key]
        public int ID_DESPESA { get; set; }

        [Required]
        [StringLength(5)]
        public string CD_DESPESA { get; set; }

        [StringLength(200)]
        public string DS_TIPO_DESPESA { get; set; }

        public int? FL_DESPESA_REEMBOLSAVEL { get; set; }

        public decimal? VL_DESPESA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }
    }
}
