using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models.DashBoard;

namespace TyphoonTaskingTool.Configurations
{
    //public class LookupCatalogueConfiguration : IEntityTypeConfiguration<LookupCatalogue>
    //{
    //    //public void Configure(EntityTypeBuilder<LookupCatalogue> entity)
    //    //{
    //    //    entity.HasKey(e => e.CatalogueId);
    //    //    entity.ToTable("LOOKUP_Catalogue");
    //    //    entity.Property(e => e.Title)
    //    //        .IsRequired()
    //    //        .HasMaxLength(100);
    //    //    entity.Property(e => e.ImagePath)
    //    //        .HasMaxLength(500);
    //    //    entity.Property(e => e.Description)
    //    //        .HasDefaultValueSql("GETDATE()");
    //    //    entity.Property(e => e.Warning)
    //    //        .HasDefaultValueSql("GETDATE()");
    //    //    entity.HasIndex(e => e.DialogKey)
    //    //        .IsUnique();)

    //    //    entity.HasData(
    //    //        new LookupCatalogue
    //    //        {
    //    //            CatalogueId = 1,
    //    //            Title = "Catalogue 1",
    //    //            ImagePath = "/images/catalogue1.png",
    //    //            Description = "Description for Catalogue 1",
    //    //            Warning = "Warning for Catalogue 1",
    //    //            DialogKey = "DIALOG_KEY_1"

    //    //        },)
    //    //}

    //}
}
