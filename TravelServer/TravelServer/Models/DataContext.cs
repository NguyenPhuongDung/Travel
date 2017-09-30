namespace TravelServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Authorize> Authorizes { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ListLocation> ListLocations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeImage> TypeImages { get; set; }
        public virtual DbSet<TypeLocation> TypeLocations { get; set; }
        public virtual DbSet<TypeReview> TypeReviews { get; set; }
        public virtual DbSet<TypeSchedule> TypeSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>()
                .Property(e => e.nameType)
                .IsFixedLength();

            modelBuilder.Entity<Map>()
                .HasMany(e => e.Locations)
                .WithRequired(e => e.Map)
                .WillCascadeOnDelete(false);
        }
    }
}
