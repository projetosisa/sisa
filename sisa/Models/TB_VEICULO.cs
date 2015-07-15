namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_VEICULO
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
        [StringLength(80)]
        public string AN_MARCA_VEIC { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(80)]
        public string AN_MODELO_VEIC { get; set; }

        public int? NR_COD_SEGURADORA { get; set; }

        [StringLength(30)]
        public string AN_MONTADORA_VEIC { get; set; }

        [StringLength(5)]
        public string AN_ANO_FAB_VEIC { get; set; }

        [StringLength(5)]
        public string AN_ANO_MODELO_VEIC { get; set; }

        [StringLength(50)]
        public string AN_COR_VEIC { get; set; }

        [StringLength(10)]
        public string AN_PLACA_VEIC { get; set; }

        [StringLength(2)]
        public string CD_UF_VEIC { get; set; }

        [StringLength(50)]
        public string AN_CHASSI_VEIC { get; set; }

        [StringLength(20)]
        public string CD_RENAVAN { get; set; }

        [StringLength(20)]
        public string CD_COMBUST_VEIC { get; set; }

        [StringLength(25)]
        public string AN_CERTIF_VEIC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ENT_VEIC_GARAGEM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_VCTO_VEIC_GARAGEM { get; set; }

        [StringLength(70)]
        public string AN_END_GARAGEM { get; set; }

        [StringLength(1000)]
        public string AN_OBS_GARAGEM { get; set; }

        [StringLength(50)]
        public string AN_DEPOSITARIO_GARAGEM { get; set; }

        [StringLength(50)]
        public string AN_GUINCHO { get; set; }

        [StringLength(20)]
        public string AN_FONE_GARAGEM { get; set; }

        [StringLength(50)]
        public string AN_LOCAL_DEPOSITO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_APREENSAO { get; set; }

        public int? FL_VEIC_REMOVIDO { get; set; }

        public decimal? VL_PAGO_REMOVIDO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_SAIDA_GARAGEM { get; set; }

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
