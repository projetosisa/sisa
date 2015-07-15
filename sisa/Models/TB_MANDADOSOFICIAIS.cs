namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MANDADOSOFICIAIS
    {
        [Key]
        public int ID_MANDADO { get; set; }

        public int ID_PROCESSO { get; set; }

        public int? CD_CLIENTE { get; set; }

        public int? NR_OPERACAO { get; set; }

        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_CNJ { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_THEMIS { get; set; }

        [StringLength(15)]
        public string NR_MANDADO { get; set; }

        [StringLength(255)]
        public string TIPO_MANDADO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESTINATARIO_MANDADO { get; set; }

        [StringLength(100)]
        public string OFICIAL_MANDADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_REC_MANDADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_DEV_MANDADO { get; set; }

        [StringLength(100)]
        public string RESULTADO_MANDADO { get; set; }

        [StringLength(50)]
        public string VLR_CONDUCAO_MANDADO { get; set; }
    }
}
