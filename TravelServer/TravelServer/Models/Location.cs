namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            Events = new HashSet<Event>();
            ListLocations = new HashSet<ListLocation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLocation { get; set; }

        [StringLength(50)]
        public string nameLocation { get; set; }

        public string address { get; set; }

        [StringLength(11)]
        public string contact { get; set; }

        public string description { get; set; }

        public int? idTypeLocation { get; set; }

        public int idMap { get; set; }

        public int? idAccount { get; set; }

        public int? state { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListLocation> ListLocations { get; set; }

        public virtual Map Map { get; set; }

        public virtual TypeLocation TypeLocation { get; set; }
    }
}
