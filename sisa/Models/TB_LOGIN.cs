namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_LOGIN
    {
        [Key]
        public int Login_ID { get; set; }

        public int? Login_Usuario { get; set; }

        [StringLength(50)]
        public string Login_PC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Login_Data { get; set; }

        [Required]
        [StringLength(50)]
        public string Login_IP { get; set; }

        [StringLength(50)]
        public string Login_MAC { get; set; }

        public TimeSpan? Login_Hora { get; set; }
    }
}
