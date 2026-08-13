using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpTeamConfiguration : IEntityTypeConfiguration<LookupTeam>
    {
        public void Configure(EntityTypeBuilder<LookupTeam> entity)
        {
            entity.HasKey(e => e.TeamId);
            entity.ToTable("LOOKUP_Team");
            entity.Property(e => e.TeamId).HasColumnName("Team_Id");
            entity.Property(e => e.TeamNameLong)
                .HasMaxLength(150)
                .HasColumnName("Team_NameLong");
            entity.Property(e => e.TeamNameShort)
                .HasMaxLength(50)
                .HasColumnName("Team_NameShort");

            entity.HasData(
                new LookupTeam
                {
                    TeamId = 1001,
                    TeamNameLong = "Information Exploitation and Technology Support",
                    TeamNameShort = "IxTS"
                },
                new LookupTeam
                {
                    TeamId = 1005,
                    TeamNameLong = "Data Management",
                    TeamNameShort = "DM"
                },
                new LookupTeam
                {
                    TeamId = 1009,
                    TeamNameLong = "Typhoon Mission Data Team",
                    TeamNameShort = "TMDT"
                },
                new LookupTeam
                {
                    TeamId = 1013,
                    TeamNameLong = "Industry Specialists",
                    TeamNameShort = "Ind Spec"
                },
                new LookupTeam
                {
                    TeamId = 1017,
                    TeamNameLong = "Mission Data Analysis Team",
                    TeamNameShort = "MDAT"
                },
                new LookupTeam
                {
                    TeamId = 1021,
                    TeamNameLong = "Attack and Identification",
                    TeamNameShort = "A and I"
                },
                new LookupTeam
                {
                    TeamId = 1026,
                    TeamNameLong = "Management",
                    TeamNameShort = "Mgmnt"
                }
            );
        }
    }
}
