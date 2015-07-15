namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_COD_EVENTO
    {
        [Key]
        public int ID_EVENTO { get; set; }

        [Required]
        [StringLength(5)]
        public string CD_EVENTO { get; set; }

        [StringLength(200)]
        public string DS_TIPO_EVENTO { get; set; }

        public int? FL_EVENTO_BANCO { get; set; }

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
