namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CONTATO
    {
        [Key]
        public int ID_CONTATO { get; set; }

        public int CD_CLIENTE { get; set; }

        public int? SQ_CONTATO { get; set; }

        [StringLength(2)]
        public string IN_TP_CONTATO { get; set; }

        [StringLength(4)]
        public string AN_DDD { get; set; }

        [StringLength(25)]
        public string AN_TELEFONE { get; set; }

        [StringLength(5)]
        public string AN_RAMAL { get; set; }

        [StringLength(150)]
        public string AN_RESPONSAVEL { get; set; }

        [StringLength(255)]
        public string AN_EMAIL { get; set; }

        public int? FL_ATIVO { get; set; }

        [StringLength(10)]
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
