namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_AVALISTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_CLIENTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NR_OPERACAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string NM_BANCO { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SQ_AVALISTA { get; set; }

        [Required]
        [StringLength(150)]
        public string NM_AVALISTA { get; set; }

        [Required]
        [StringLength(1)]
        public string IN_F_J_AVALISTA { get; set; }

        [StringLength(100)]
        public string AN_ENDERECO { get; set; }

        [StringLength(100)]
        public string AN_CIDADE { get; set; }

        [StringLength(50)]
        public string AN_BAIRRO { get; set; }

        [StringLength(9)]
        public string AN_CEP { get; set; }

        [StringLength(2)]
        public string CD_UF { get; set; }

        [StringLength(18)]
        public string AN_TELEFONE { get; set; }

        [StringLength(18)]
        public string AN_CELULAR { get; set; }

        [StringLength(255)]
        public string AN_REF_AVALISTA1 { get; set; }

        [StringLength(255)]
        public string AN_REF_AVALISTA2 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }
    }
}
