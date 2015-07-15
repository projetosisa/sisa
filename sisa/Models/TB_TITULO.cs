namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TITULO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_CLIENTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NM_BANCO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NR_OPERACAO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CD_CONTRATO { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NR_PARCELA { get; set; }

        public int? NR_DIAS_ATRASO { get; set; }

        [StringLength(8)]
        public string CD_BOLETO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_VCTO { get; set; }

        public decimal? VL_TITULO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_EMISSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PRIM_NOTIFICACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_RECEBIMENTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_CREDITO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_REPASSE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_BAIXA { get; set; }

        public int? FL_BAIXA_MANUAL { get; set; }

        [StringLength(100)]
        public string AN_ARQUIVO_ENVIO { get; set; }

        public int? NR_DIAS_PAGTO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_BANCO_PAGTO { get; set; }

        [StringLength(50)]
        public string CD_PROGRAMA_EXC { get; set; }

        [StringLength(150)]
        public string AN_MOTIVO_EXC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_EXCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_EXC { get; set; }
    }
}
