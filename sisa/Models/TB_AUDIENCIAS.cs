namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_AUDIENCIAS
    {
        [Key]
        public int ID_AUDIENCIA { get; set; }

        public int ID_PROCESSO { get; set; }

        public int? CD_CLIENTE { get; set; }

        public int? NR_OPERACAO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_CNJ { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_THEMIS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATA_AUDIENCIA { get; set; }

        public string TEXTO_AUDIENCIA { get; set; }
    }
}
