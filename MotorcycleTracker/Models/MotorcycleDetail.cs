namespace MotorcycleTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MotorcycleDetail
    {
        [Key]
        public int DetailsId { get; set; }

        public int MotorId { get; set; }

        [Required]
        [StringLength(20)]
        public string MotorBrand { get; set; }

        [Required]
        [StringLength(20)]
        public string MotorModel { get; set; }

        [Required]
        [StringLength(20)]
        public string Country { get; set; }

        public virtual Motorcycle Motorcycle { get; set; }
    }
}
