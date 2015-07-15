namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PESSOA
    {
        [Key]
        [Column(Order = 0)]
        public int ID_PESSOA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_CLIENTE { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_PESSOA { get; set; }

        [Required]
        [StringLength(1)]
        public string IN_F_J { get; set; }

        [Required]
        [StringLength(20)]
        public string AN_CNPJ_CPF { get; set; }

        [StringLength(50)]
        public string AN_OCUPACAO { get; set; }

        [StringLength(50)]
        public string AN_CARGO { get; set; }

        [StringLength(20)]
        public string AN_RG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_EMISSAO_RG { get; set; }

        [StringLength(25)]
        public string AN_ORGAO_EMISSAO_RG { get; set; }

        [StringLength(2)]
        public string CD_UF_RG { get; set; }

        [StringLength(1)]
        public string AN_SEXO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_NASCIMENTO { get; set; }

        [StringLength(100)]
        public string AN_NATURALIDADE { get; set; }

        [StringLength(50)]
        public string AN_NACIONALIDADE { get; set; }

        [StringLength(50)]
        public string AN_ESTADO_CIVIL { get; set; }

        [StringLength(100)]
        public string AN_NOME_CONJUGE { get; set; }

        [StringLength(100)]
        public string AN_NOME_PAI { get; set; }

        [StringLength(100)]
        public string AN_NOME_MAE { get; set; }

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
