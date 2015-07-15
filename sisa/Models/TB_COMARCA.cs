namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_COMARCA
    {
        [Key]
        public int ID_COMARCA { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_COMARCA { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_VARA { get; set; }

        [StringLength(100)]
        public string AN_CIDADE { get; set; }

        [StringLength(2)]
        public string AN_ESTADO { get; set; }

        [StringLength(90)]
        public string AN_FILIAL { get; set; }

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
