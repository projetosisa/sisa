namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_BANCO
    {
        [Key]
        public int ID_BANCO { get; set; }

        [Required]
        [StringLength(5)]
        public string CD_BANCO { get; set; }

        [Required]
        [StringLength(255)]
        public string DS_BANCO { get; set; }

        [StringLength(255)]
        public string AN_ENDERECO { get; set; }

        [StringLength(50)]
        public string AN_CIDADE { get; set; }

        [StringLength(2)]
        public string CD_UF { get; set; }

        [StringLength(20)]
        public string AN_CNPJ { get; set; }

        [StringLength(45)]
        public string AN_INS_EST { get; set; }

        [StringLength(6)]
        public string CD_AGENCIA { get; set; }

        [StringLength(8)]
        public string CD_CEDENTE { get; set; }

        public double? FT_IND_BANCO { get; set; }

        public double? FT_IND_JURIDICO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FT_IND_DESCONTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FT_IND_JUROS { get; set; }

        public decimal? VL_ENCARGOS { get; set; }

        public decimal? VL_ESCRITORIO { get; set; }

        public decimal? VL_NOTIFICACAO { get; set; }

        public decimal? VL_HONORARIOS { get; set; }

        public int? QT_DIAS_NOTIFICACAO { get; set; }

        public int? NR_RECIBO { get; set; }

        public int? NR_BOLETO { get; set; }

        public int? NR_BORDERO { get; set; }

        public int? NR_NOTIFICACAO { get; set; }

        public int? NR_LOTE { get; set; }

        public int? QT_DIAS_AJUIZAMENTO { get; set; }

        public int? QT_DIAS_CARTORIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_META { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_LOCALIZADOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VL_MULTA { get; set; }

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
