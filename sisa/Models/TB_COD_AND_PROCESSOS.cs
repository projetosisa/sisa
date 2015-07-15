namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_COD_AND_PROCESSOS
    {
        [Key]
        public int ID_TIPO { get; set; }

        [Required]
        [StringLength(5)]
        public string CD_ANDAMENTO { get; set; }

        [StringLength(200)]
        public string DS_TIPO_ANDAMENTO { get; set; }

        public int? FL_FIM_ACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_FRIA { get; set; }
    }
}
