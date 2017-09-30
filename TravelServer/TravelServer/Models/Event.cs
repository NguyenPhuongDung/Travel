namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEvent { get; set; }

        public int? idLocation { get; set; }

        [StringLength(50)]
        public string nameEvent { get; set; }

        public DateTime? timeStartEvent { get; set; }

        public DateTime? timeFinishEvent { get; set; }

        public string description { get; set; }

        public int? idAccount { get; set; }

        public int? state { get; set; }

        public virtual Location Location { get; set; }
    }
}
