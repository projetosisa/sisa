//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_PERMISSOES
    {
        public int Permissao_ID { get; set; }
        public Nullable<int> Permissao_Usuario { get; set; }
        public Nullable<int> Permissao_Menu { get; set; }
        public Nullable<byte> Permissao_Editar { get; set; }
        public Nullable<byte> Permissao_Visualizar { get; set; }
        public Nullable<byte> Permissao_Adicionar { get; set; }
        public Nullable<byte> Permissao_Excluir { get; set; }
    }
}
