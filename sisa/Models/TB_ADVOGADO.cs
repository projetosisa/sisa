namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ADVOGADO
    {
        [Key]
        public int CD_ADVOGADO { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_ADVOGADO { get; set; }

        [StringLength(20)]
        public string CD_OAB { get; set; }

        [StringLength(15)]
        public string AN_TELEFONE { get; set; }

        [StringLength(70)]
        public string AN_EMAIL { get; set; }

        [StringLength(100)]
        public string NM_ESCRITORIO { get; set; }

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
