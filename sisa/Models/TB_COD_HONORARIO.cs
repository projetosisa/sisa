namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_COD_HONORARIO
    {
        [Key]
        public int ID_HONORARIO { get; set; }

        [Required]
        [StringLength(5)]
        public string CD_HONORARIO { get; set; }

        [StringLength(200)]
        public string DS_TIPO_HONORARIO { get; set; }

        public decimal? VL_HONORARIO { get; set; }

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
