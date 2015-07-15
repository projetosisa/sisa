namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DADOS_REFERENCIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CD_CLIENTE { get; set; }

        [StringLength(15)]
        public string AN_CONTATO_TEL_RES { get; set; }

        [StringLength(50)]
        public string AN_NOME_CONJUGE { get; set; }

        [StringLength(30)]
        public string AN_NOME_PRIM_REFERENCIA { get; set; }

        [StringLength(15)]
        public string AN_TP_PARENTESCO_PRIM_PES { get; set; }

        [StringLength(30)]
        public string AN_NOME_SEG_REFERENCIA { get; set; }

        [StringLength(15)]
        public string AN_TP_PARENTESCO_SEG_PES { get; set; }

        public int? FL_PESQUISA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_PESQUISA { get; set; }

        public int? FL_LOCALIZADOR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_LOCALIZADOR { get; set; }

        [StringLength(50)]
        public string AN_NOME_LOCALIZADOR { get; set; }

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
