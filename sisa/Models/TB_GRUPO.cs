namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_GRUPO
    {
        [Key]
        [StringLength(45)]
        public string CD_GRUPO { get; set; }

        [Required]
        [StringLength(45)]
        public string NM_GRUPO { get; set; }

        [Required]
        [StringLength(200)]
        public string DS_GRUPO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(50)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(50)]
        public string CD_USUARIO_ALT { get; set; }

        public int VERID { get; set; }
    }
}
