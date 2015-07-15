namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CUSTAS
    {
        [Key]
        public int ID_CUSTAS { get; set; }

        public int? CD_CLIENTE { get; set; }

        public int? NR_OPERACAO { get; set; }

        public int ID_PROCESSO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_CNJ { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_THEMIS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(15)]
        public string NR_GUIA { get; set; }

        public decimal? VLR_GUIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PAGTO { get; set; }
    }
}
