using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpUnitConfiguration : IEntityTypeConfiguration<LookupUnit>
    {
        public void Configure(EntityTypeBuilder<LookupUnit> entity)
        {
            entity.HasKey(e => e.UnitId);

            entity.ToTable("LOOKUP_Unit");

            entity.Property(e => e.UnitId).HasColumnName("Unit_Id");
            entity.Property(e => e.UnitNameLong)
                .HasMaxLength(150)
                .HasColumnName("Unit_NameLong");
            entity.Property(e => e.UnitNameShort)
                .HasMaxLength(50)
                .HasColumnName("Unit_NameShort");

            entity.HasData(
                new LookupUnit
                {
                    UnitId = 5001,
                    UnitNameLong = "Number 3 (Fighter) Squadron",
                    UnitNameShort = "3(F) Sqn",
                },
                new LookupUnit
                {
                    UnitId = 5003,
                    UnitNameLong = "Number 11 (Fighter) Squadron",
                    UnitNameShort = "XI (F) Sqn",
                },
                new LookupUnit
                {
                    UnitId = 5006,
                    UnitNameLong = "Number 12 Squadron",
                    UnitNameShort = "12 Sqn",
                },
                new LookupUnit
                {
                    UnitId = 5009,
                    UnitNameLong = "Number 29 Squadron",
                    UnitNameShort = "29 Sqn",
                },
                new LookupUnit
                {
                    UnitId = 5012,
                    UnitNameLong = "Number 41 (Test and Evaluation) Squadron",
                    UnitNameShort = "41 (TES) Sqn",
                },
                new LookupUnit
                {
                    UnitId = 5015,
                    UnitNameLong = "Typhoon National Support Centre",
                    UnitNameShort = "Ty NSC",
                },
                new LookupUnit
                {
                    UnitId = 5018,
                    UnitNameLong = "Typhoon Mission Support Centre",
                    UnitNameShort = "Ty MSC",
                },
                new LookupUnit
                {
                    UnitId = 5021,
                    UnitNameLong = "Typhoon CAMO",
                    UnitNameShort = "Ty CAMO",
                },
                new LookupUnit
                {
                    UnitId = 5024,
                    UnitNameLong = "Air & Space Warfare Centre",
                    UnitNameShort = "ASWC",
                },
                new LookupUnit
                {
                    UnitId = 5027,
                    UnitNameLong = "Typhoon Force Headquarters",
                    UnitNameShort = "Ty FHQ",
                },
                new LookupUnit
                {
                    UnitId = 5030,
                    UnitNameLong = "Any Other External Organisation",
                    UnitNameShort = "Others",
                }
                );
        }
    }
}
