namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PERMISSOES
    {
        [Key]
        public int Permissao_ID { get; set; }

        public int? Permissao_Usuario { get; set; }

        public int? Permissao_Menu { get; set; }

        public byte? Permissao_Editar { get; set; }

        public byte? Permissao_Visualizar { get; set; }

        public byte? Permissao_Adicionar { get; set; }

        public byte? Permissao_Excluir { get; set; }
    }
}
