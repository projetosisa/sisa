namespace sisa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_HORARIOS
    {
        [Key]
        public int ID_HORARIO { get; set; }

        public int CODIGO { get; set; }

        [Required]
        [StringLength(5)]
        public string HORARIO_INICIAL { get; set; }

        [Required]
        [StringLength(5)]
        public string HORARIO_FINAL { get; set; }

        [Required]
        [StringLength(5)]
        public string HORARIO_INTERVALO_INICIAL { get; set; }

        [Required]
        [StringLength(5)]
        public string HORARIO_INTERVALO_FINAL { get; set; }

        [StringLength(5)]
        public string HORAS_DIA { get; set; }
    }
}
