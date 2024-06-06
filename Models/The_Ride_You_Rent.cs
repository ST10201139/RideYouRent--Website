using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace The_Ride_You_Rent1.Models
{
    public partial class The_Ride_You_Rent : DbContext
    {
        public The_Ride_You_Rent()
            : base("name=The_Ride_You_Rent")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Car_Body_Type> Car_Body_Type { get; set; }
        public virtual DbSet<Car_Make> Car_Make { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Inspector> Inspectors { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Return_> Return_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.CarNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.CarModel)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Return_)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car_Body_Type>()
                .Property(e => e.BodyType)
                .IsUnicode(false);

            modelBuilder.Entity<Car_Body_Type>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.Car_Body_Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car_Make>()
                .Property(e => e.CarMake)
                .IsUnicode(false);

            modelBuilder.Entity<Car_Make>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.Car_Make)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Return_)
                .WithRequired(e => e.Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.InspectorNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.InspectorName)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.InspectorEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .Property(e => e.InspectorMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Inspector>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Inspector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspector>()
                .HasMany(e => e.Return_)
                .WithRequired(e => e.Inspector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rental>()
                .Property(e => e.InspectorNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Return_>()
                .Property(e => e.InspectorNumber)
                .IsUnicode(false);
        }
    }
}
