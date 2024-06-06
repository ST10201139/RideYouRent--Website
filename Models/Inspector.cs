namespace The_Ride_You_Rent1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inspector")]
    public partial class Inspector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspector()
        {
            Rentals = new HashSet<Rental>();
            Return_ = new HashSet<Return_>();
        }

        [Key]
        [StringLength(4)]
        public string InspectorNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string InspectorName { get; set; }

        [Required]
        [StringLength(50)]
        public string InspectorEmail { get; set; }

        [Required]
        [StringLength(10)]
        public string InspectorMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Return_> Return_ { get; set; }
    }
}
