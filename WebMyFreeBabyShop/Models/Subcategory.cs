namespace WebMyFreeBabyShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subcategory")]
    public partial class Subcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subcategory()
        {
            ItemBabyEntity = new HashSet<ItemBabyEntity>();
        }

        [Key]
        public int idSubcategory { get; set; }

        [Column("subcategory")]
        [StringLength(10)]
        public string subcategory1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemBabyEntity> ItemBabyEntity { get; set; }
    }
}
