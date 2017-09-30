namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            ListLocations = new HashSet<ListLocation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSchedule { get; set; }

        [StringLength(50)]
        public string nameSchedule { get; set; }

        public DateTime? timeStartEvent { get; set; }

        public DateTime? timeFinishEvent { get; set; }

        public string description { get; set; }

        public double? cost { get; set; }

        public int? idTypeSchedule { get; set; }

        public int? idAccount { get; set; }

        public int? state { get; set; }

        public int? idListLocation { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListLocation> ListLocations { get; set; }

        public virtual TypeSchedule TypeSchedule { get; set; }
    }
}
