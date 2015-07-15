namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TELA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(45)]
        public string CD_TELA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(45)]
        public string CD_SISTEMA { get; set; }

        [Required]
        [StringLength(45)]
        public string NM_TELA { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_TELA { get; set; }

        [Required]
        [StringLength(100)]
        public string AN_URL { get; set; }

        public int NR_ORDER { get; set; }

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
