namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PARTES_ENVOLVIDAS
    {
        [Key]
        public int ID_PARTES_ENVOLVIDAS { get; set; }

        public int ID_PROCESSO { get; set; }

        public int? CD_CLIENTE { get; set; }

        public int? NR_OPERACAO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_CNJ { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_THEMIS { get; set; }

        [StringLength(255)]
        public string AN_REQUERENTE { get; set; }

        [StringLength(255)]
        public string AN_ADVOGADO_REQUERENTE { get; set; }

        [StringLength(255)]
        public string AN_REQUERIDO { get; set; }

        [StringLength(255)]
        public string AN_ADVOGADO_REQUERIDO { get; set; }

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
