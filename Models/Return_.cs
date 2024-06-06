namespace The_Ride_You_Rent1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Return_
    {
        public int Return_id { get; set; }

        public int CarID { get; set; }

        [Required]
        [StringLength(4)]
        public string InspectorNumber { get; set; }

        public int DriverID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        public int ElapsedDate { get; set; }

        public int Fine { get; set; }

        public virtual Car Car { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Inspector Inspector { get; set; }
    }
}
