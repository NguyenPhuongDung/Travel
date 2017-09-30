namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListLocation")]
    public partial class ListLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idListLocation { get; set; }

        public int? idLocation { get; set; }

        public int? idSchedule { get; set; }

        public virtual Location Location { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
