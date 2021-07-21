namespace BigSchool2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("following")]
    public partial class following
    {
        [Key]
        [Column(Order = 0)]
        public string followerId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string followeeId { get; set; }
    }
}
