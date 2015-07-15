namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_AND_PROCESSO
    {
        [Key]
        public int ID_ANDAMENTO { get; set; }

        public int? ID_PROCESSO { get; set; }

        public int? ID_TIPO { get; set; }

        public int? CD_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NM_BANCO { get; set; }

        [StringLength(45)]
        public string AN_PROCESSO { get; set; }

        [StringLength(5)]
        public string CD_ANDAMENTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DT_ANDAMENTO { get; set; }

        [StringLength(26)]
        public string AN_CNJ { get; set; }

        [StringLength(255)]
        public string DS_ANDAMENTO { get; set; }

        public int? FL_FIM_ACAO { get; set; }

        public int? NR_C_FIN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }
    }
}
