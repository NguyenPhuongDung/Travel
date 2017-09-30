namespace TravelServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idImage { get; set; }

        public string linkImage { get; set; }

        public int? idTypeImage { get; set; }

        public virtual TypeImage TypeImage { get; set; }
    }
}
