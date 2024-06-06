namespace The_Ride_You_Rent1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Rentals = new HashSet<Rental>();
            Return_ = new HashSet<Return_>();
        }

        public int CarID { get; set; }

        [Required]
        [StringLength(6)]
        public string CarNumber { get; set; }

        public int MakeID { get; set; }

        [Required]
        [StringLength(50)]
        public string CarModel { get; set; }

        public int BodyID { get; set; }

        public int KilometresTravelled { get; set; }

        public int ServiceKilometres { get; set; }

        public bool Available { get; set; }

        public virtual Car_Body_Type Car_Body_Type { get; set; }

        public virtual Car_Make Car_Make { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Return_> Return_ { get; set; }
    }
}
