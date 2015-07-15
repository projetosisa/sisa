namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DEPOSITOS_JUDICIAIS
    {
        [Key]
        public int ID_DEPOSITO { get; set; }

        public int? ID_PROCESSO { get; set; }

        public int? CD_CLIENTE { get; set; }

        public int? NR_OPERACAO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_CNJ { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_THEMIS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(15)]
        public string NR_GUIA { get; set; }

        public decimal? VLR_GUIA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATA_DEPOSITO { get; set; }

        [StringLength(150)]
        public string DEPOSITANTE { get; set; }
    }
}
