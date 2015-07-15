namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_EMAIL
    {
        [Key]
        public int ID_EMAIL { get; set; }

        public int CD_CLIENTE { get; set; }

        public int? SQ_EMAIL { get; set; }

        [StringLength(255)]
        public string AN_EMAIL { get; set; }

        [StringLength(250)]
        public string AN_RESPONSAVEL { get; set; }

        [StringLength(15)]
        public string AN_ORIGEM { get; set; }

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
