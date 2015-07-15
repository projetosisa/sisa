namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DOMINIO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_DOMINIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(45)]
        public string AN_TP_DOMINIO { get; set; }

        [Required]
        [StringLength(100)]
        public string AN_VALUE { get; set; }

        [Required]
        [StringLength(200)]
        public string AN_DECRICAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(50)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(50)]
        public string CD_USUARIO_ALT { get; set; }

        public int? VERID { get; set; }
    }
}
