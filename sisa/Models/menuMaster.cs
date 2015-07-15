namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("menuMaster")]
    public partial class menuMaster
    {
        [Key]
        public int Menu_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Menu_Nome { get; set; }

        public int? Menu_Parent { get; set; }

        [StringLength(50)]
        public string Menu_Enable { get; set; }

        [StringLength(100)]
        public string Menu_Form { get; set; }

        [StringLength(50)]
        public string Menu_Texto { get; set; }

        [StringLength(50)]
        public string Menu_Tipo { get; set; }

        [StringLength(50)]
        public string Menu_Icone { get; set; }

        [StringLength(50)]
        public string Menu_Modulo { get; set; }
    }
}
