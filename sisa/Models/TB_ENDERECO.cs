namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ENDERECO
    {
        [Key]
        public int ID_ENDERECO { get; set; }

        public int CD_CLIENTE { get; set; }

        public int? SQ_ENDERECO { get; set; }

        [StringLength(2)]
        public string IN_ENDERECO { get; set; }

        [StringLength(50)]
        public string AN_ORIGEM { get; set; }

        public int? FL_ATIVO { get; set; }

        [StringLength(70)]
        public string AN_ENDERECO { get; set; }

        public int? NR_ENDERECO { get; set; }

        [StringLength(50)]
        public string AN_COMPLEMENTO { get; set; }

        [StringLength(70)]
        public string AN_BAIRRO { get; set; }

        [StringLength(70)]
        public string AN_CIDADE { get; set; }

        [StringLength(2)]
        public string CD_UF { get; set; }

        [StringLength(9)]
        public string AN_CEP { get; set; }

        [StringLength(70)]
        public string AN_NOME_EMPRESA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INCLUSAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_ALTERACAO { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_INC { get; set; }

        [StringLength(35)]
        public string CD_USUARIO_ALT { get; set; }
    }
}
