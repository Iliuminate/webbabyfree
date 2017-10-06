namespace WebMyFreeBabyShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemBabyEntity")]
    public partial class ItemBabyEntity
    {
        public long id { get; set; }

        [Required]
        [StringLength(100)]
        public string itemName { get; set; }

        [StringLength(500)]
        public string itemDescription { get; set; }

        [StringLength(25)]
        public string itemSerial { get; set; }

        public DateTime dateAdd { get; set; }

        public int? qualify { get; set; }

        [StringLength(100)]
        public string itemImage { get; set; }

        public int? category { get; set; }

        public int? subcategory { get; set; }

        public virtual CategoryEntity CategoryEntity { get; set; }

        public virtual Subcategory Subcategory1 { get; set; }
    }
}
