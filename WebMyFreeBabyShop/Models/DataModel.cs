namespace WebMyFreeBabyShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModelBaby")
        {
        }

        public virtual DbSet<CategoryEntity> CategoryEntity { get; set; }
        public virtual DbSet<ItemBabyEntity> ItemBabyEntity { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>()
                .Property(e => e.categoryName)
                .IsFixedLength();

            modelBuilder.Entity<ItemBabyEntity>()
                .Property(e => e.itemName)
                .IsFixedLength();

            modelBuilder.Entity<ItemBabyEntity>()
                .Property(e => e.itemDescription)
                .IsFixedLength();

            modelBuilder.Entity<ItemBabyEntity>()
                .Property(e => e.itemSerial)
                .IsFixedLength();

            modelBuilder.Entity<ItemBabyEntity>()
                .Property(e => e.itemImage)
                .IsFixedLength();

            modelBuilder.Entity<ItemBabyEntity>()
                .HasOptional(e => e.ItemBabyEntity1)
                .WithRequired(e => e.ItemBabyEntity2);

            modelBuilder.Entity<Subcategory>()
                .Property(e => e.subcategory1)
                .IsFixedLength();

            modelBuilder.Entity<Subcategory>()
                .HasMany(e => e.ItemBabyEntity)
                .WithOptional(e => e.Subcategory1)
                .HasForeignKey(e => e.subcategory);
        }
    }
}
