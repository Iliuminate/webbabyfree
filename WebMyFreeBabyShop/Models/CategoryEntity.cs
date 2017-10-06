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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoryEntity()
        {
            ItemBabyEntity = new HashSet<ItemBabyEntity>();
        }

        [Key]
        public int idCategory { get; set; }

        [StringLength(25)]
        public string categoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemBabyEntity> ItemBabyEntity { get; set; }
    }
}
