using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpPriorityConfiguration : IEntityTypeConfiguration<LookupPriority>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LookupPriority> entity)
        {
            entity.HasKey(e => e.PriorityId);
            entity.ToTable("LOOKUP_Priority");
            entity.Property(e => e.PriorityId).HasColumnName("Priority_Id");
            entity.Property(e => e.PriorityLevel).HasColumnName("Priority_Level");
            entity.Property(e => e.PriorityName)
                .HasMaxLength(50)
                .HasColumnName("Priority_Name");
            entity.Property(e => e.PriorityDescription)
                .HasMaxLength(150)
                .HasColumnName("Priority_Description");
            entity.Property(e => e.PriorityLevelDescription)
                .HasMaxLength(100)
                .HasColumnName("Priority_Level_Description");

            entity.HasData(
                new LookupPriority
                {
                    PriorityId = 1,
                    PriorityLevel = 1,
                    PriorityName = "Critical",
                    PriorityDescription = "Task triaged as being High/High impact with High/Medium urgency",
                    PriorityLevelDescription = "24 hour response time, 48 hour resolution time"
                },
                new LookupPriority
                {
                    PriorityId = 2,
                    PriorityLevel = 2,
                    PriorityName = "High",
                    PriorityDescription = "Task triaged as being High/Medium impact with Medium/High urgency",
                    PriorityLevelDescription = "48 hour response time, 5 day resolution time"
                },
                new LookupPriority
                {
                    PriorityId = 3,
                    PriorityLevel = 3,
                    PriorityName = "Medium",
                    PriorityDescription = "Task triaged as being Low/Medium impact with High/Medium urgency",
                    PriorityLevelDescription = "5 day response time, 10 day resolution time"
                },
                new LookupPriority
                {
                    PriorityId = 4,
                    PriorityLevel = 4,
                    PriorityName = "Low",
                    PriorityDescription = "Task triaged as being Low impact with Medium urgency",
                    PriorityLevelDescription = "10 day response time, 20 day resolution time"
                },
                new LookupPriority
                {
                    PriorityId = 5,
                    PriorityLevel = 5,
                    PriorityName = "Enhancement",
                    PriorityDescription = "Routine enhancement request.",
                    PriorityLevelDescription = "Enhancement requests will be reviewed and prioritized based on business needs."
                }
            );
        }
    }
}
