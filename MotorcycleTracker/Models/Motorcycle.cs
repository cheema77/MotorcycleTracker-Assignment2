namespace MotorcycleTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Motorcycle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motorcycle()
        {
            MotorcycleDetails = new HashSet<MotorcycleDetail>();
        }

        [Key]
        public int MotorId { get; set; }

        [Required]
        [StringLength(50)]
        public string MotorName { get; set; }

        public int MakeYear { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotorcycleDetail> MotorcycleDetails { get; set; }
    }
}
