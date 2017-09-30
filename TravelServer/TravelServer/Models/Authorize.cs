namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authorize")]
    public partial class Authorize
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAuthorize { get; set; }

        public int? idAccountType { get; set; }

        public string nameFunction { get; set; }

        public virtual AccountType AccountType { get; set; }
    }
}
