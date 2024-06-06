namespace The_Ride_You_Rent1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rental")]
    public partial class Rental
    {
        public int Rentalid { get; set; }

        public int CarID { get; set; }

        [Required]
        [StringLength(4)]
        public string InspectorNumber { get; set; }

        public int DriverID { get; set; }

        public int RentalFee { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public virtual Car Car { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Inspector Inspector { get; set; }
    }
}
