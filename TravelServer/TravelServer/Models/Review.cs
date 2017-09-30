namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public partial class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idReview { get; set; }

        public int? idTypeReview { get; set; }

        public DateTime? timeReview { get; set; }

        public string contentReview { get; set; }

        public int? rating { get; set; }

        public int? idAccount { get; set; }

        public virtual Account Account { get; set; }

        public virtual TypeReview TypeReview { get; set; }
    }
}
