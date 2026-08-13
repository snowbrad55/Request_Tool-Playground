using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpRankConfiguration : IEntityTypeConfiguration<LookupRank>
    {
        public void Configure(EntityTypeBuilder<LookupRank> entity)
        {
            entity.HasKey(e => e.RankId);

            entity.ToTable("LOOKUP_Rank");

            entity.Property(e => e.RankId).HasColumnName("Rank_Id");
            entity.Property(e => e.RankNameLong)
                .HasMaxLength(50)
                .HasColumnName("Rank_NameLong");
            entity.Property(e => e.RankNameShort)
                .HasMaxLength(50)
                .HasColumnName("Rank_NameShort");
            entity.Property(e => e.RankNatoequiv)
                .HasMaxLength(50)
                .HasColumnName("Rank_NATOEquiv");

            entity.HasData(
                new LookupRank
                {
                    RankId = 1,
                    RankNameLong = "Air Recruit",
                    RankNameShort = "AR",
                    RankNatoequiv = "OR-1"
                },
                new LookupRank
                {
                    RankId = 4,
                    RankNameLong = "Air Specialist 2",
                    RankNameShort = "AS2",
                    RankNatoequiv = "OR-2"
                },
                new LookupRank
                {
                    RankId = 7,
                    RankNameLong = "Air Specialist 1",
                    RankNameShort = "AS1",
                    RankNatoequiv = "OR-2"
                },
                new LookupRank
                {
                    RankId = 10,
                    RankNameLong = "Air Specialist 1 (Technician)",
                    RankNameShort = "AS1(T)",
                    RankNatoequiv = "OR-2"
                },
                new LookupRank
                {
                    RankId = 13,
                    RankNameLong = "Lance Corporal",
                    RankNameShort = "LCpl",
                    RankNatoequiv = "OR-3"
                },
                new LookupRank
                {
                    RankId = 16,
                    RankNameLong = "Corporal",
                    RankNameShort = "Cpl",
                    RankNatoequiv = "OR-4"
                },
                new LookupRank
                {
                    RankId = 19,
                    RankNameLong = "Sergeant",
                    RankNameShort = "Sgt",
                    RankNatoequiv = "OR-6"
                },
                new LookupRank
                {
                    RankId = 22,
                    RankNameLong = "Chief Technician",
                    RankNameShort = "CT",
                    RankNatoequiv = "OR-7"
                },
                new LookupRank
                {
                    RankId = 25,
                    RankNameLong = "Flight Sergeant",
                    RankNameShort = "FS",
                    RankNatoequiv = "OR-7"
                },
                new LookupRank
                {
                    RankId = 28,
                    RankNameLong = "Warrant Officer / Master Aircrew",
                    RankNameShort = "WO/MAcr",
                    RankNatoequiv = "OR-9"
                },
                new LookupRank
                {
                    RankId = 41,
                    RankNameLong = "Pilot Officer",
                    RankNameShort = "PO",
                    RankNatoequiv = "OF-1"
                },
                new LookupRank
                {
                    RankId = 44,
                    RankNameLong = "Flying Officer",
                    RankNameShort = "FO",
                    RankNatoequiv = "OF-1"
                },
                new LookupRank
                {
                    RankId = 47,
                    RankNameLong = "Flight Lieutenant",
                    RankNameShort = "Flt Lt",
                    RankNatoequiv = "OF-2"
                },
                new LookupRank
                {
                    RankId = 50,
                    RankNameLong = "Squadron Leader",
                    RankNameShort = "Sqn Ldr",
                    RankNatoequiv = "OF-3"
                },
                new LookupRank
                {
                    RankId = 53,
                    RankNameLong = "Wing Commander",
                    RankNameShort = "Wg Cdr",
                    RankNatoequiv = "OF-4"
                },
                new LookupRank
                {
                    RankId = 56,
                    RankNameLong = "Group Captain",
                    RankNameShort = "Gp Capt",
                    RankNatoequiv = "OF-5"
                },
                new LookupRank
                {
                    RankId = 59,
                    RankNameLong = "Air Commodore",
                    RankNameShort = "Air Cmdre",
                    RankNatoequiv = "OF-6"
                },
                new LookupRank
                {
                    RankId = 62,
                    RankNameLong = "Air Vice Marshall",
                    RankNameShort = "AVM",
                    RankNatoequiv = "OF-7"
                },
                new LookupRank
                {
                    RankId = 65,
                    RankNameLong = "Air Marshall",
                    RankNameShort = "AM",
                    RankNatoequiv = "OF-8"
                },
                new LookupRank
                {
                    RankId = 68,
                    RankNameLong = "Air Chief Marshall",
                    RankNameShort = "ACM",
                    RankNatoequiv = "OF-9"
                },
                new LookupRank
                {
                    RankId = 71,
                    RankNameLong = "Marshall of the Royal Air Force",
                    RankNameShort = "MRAF",
                    RankNatoequiv = "OF-10"
                }
            );            
        }
    }
}
