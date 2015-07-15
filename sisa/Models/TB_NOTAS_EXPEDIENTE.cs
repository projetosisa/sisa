namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_NOTAS_EXPEDIENTE
    {
        [Key]
        public int ID_NOTA { get; set; }

        public int? ID_PROCESSO { get; set; }

        public int? CD_CLIENTE { get; set; }

        public int? NR_OPERACAO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_CNJ { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_THEMIS { get; set; }

        [StringLength(15)]
        public string NR_NOTA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATA_NOTA { get; set; }

        public string TEXTO_NOTA { get; set; }
    }
}
