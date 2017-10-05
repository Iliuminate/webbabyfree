namespace WebMyFreeBabyShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryEntity")]
    public partial class CategoryEntity
    {
        [Key]
        public int idCategory { get; set; }

        [StringLength(25)]
        public string categoryName { get; set; }
    }
}
