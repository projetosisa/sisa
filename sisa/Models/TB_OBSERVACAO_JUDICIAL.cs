namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_OBSERVACAO_JUDICIAL
    {
        public int CD_CLIENTE { get; set; }

        public int NR_OPERACAO { get; set; }

        [Required]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SQ_LANCTO { get; set; }

        [Required]
        [StringLength(45)]
        public string AN_PROCESSO { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_OBSERVACAO { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime DT_OBS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string HR_OBSERVACAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_OBS { get; set; }

        [StringLength(1000)]
        public string AN_OBSERVACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }

        public int? ID_PROCESSO { get; set; }
    }
}
