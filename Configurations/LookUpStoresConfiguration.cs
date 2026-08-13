using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpStoresConfiguration :IEntityTypeConfiguration<LookupStores>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LookupStores> entity)
        {
            entity.HasKey(e => e.StoreId);
            entity.ToTable("LOOKUP_Stores");
            entity.Property(e => e.StoreId).HasColumnName("Store_Id");
            entity.Property(e => e.StoreName)
                .HasMaxLength(100)
                .HasColumnName("Store_Name");
            entity.Property(e => e.StoreDescription)
                .HasMaxLength(250)
                .HasColumnName("Store_Description");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(250)
                .HasColumnName("Image_Url");

            entity.HasData(
                new LookupStores
                {
                    StoreId = 101,
                    StoreName = "AMRAAM 120 B5",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/AMRAAM_120_B5.png"
                },
                new LookupStores
                {
                    StoreId = 102,
                    StoreName = "AMRAAM 120 D",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/AMRAAM_120-D.png"
                },
                new LookupStores
                {
                    StoreId = 103,
                    StoreName = "AMRAAM 120M C5",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/AMRAAM_120M-C5.png"
                },
                new LookupStores
                {
                    StoreId = 104,
                    StoreName = "AMRAAM 120M C5 AAVI",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/AMRAAM_120M-C5_AAVI.png"
                },
                new LookupStores
                {
                    StoreId = 105,
                    StoreName = "AMRAAM 120 OM",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/AMRAAM_OM.png"
                },
                new LookupStores
                {
                    StoreId = 106,
                    StoreName = "ASRAAM TOM",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/ASRAAM_TOM.png"
                },

                new LookupStores
                {
                    StoreId = 201,
                    StoreName = "BS STN 3 Empty",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/BS2_STN_3_Empty.png"
                },
                new LookupStores
                {
                    StoreId = 202,
                    StoreName = "BS STN 4 Empty",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/BS2_STN_4_Empty.png"
                },
                new LookupStores
                {
                    StoreId = 203,
                    StoreName = "BS 2 EDGM",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/BS2_EDGM.png"
                },
                new LookupStores
                {
                    StoreId = 204,
                    StoreName = "BS 2 OM",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/BS2_OM.png"
                },
                new LookupStores
                {
                    StoreId = 205,
                    StoreName = "BS 2 TOM",
                    StoreDescription = "Description for Store A",
                    ImageUrl = "images/A2A/BS2_TOM.png"
                });
        }
    }
}
