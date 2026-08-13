using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpStatusConfiguration : IEntityTypeConfiguration<LookupStatus>
    {
        public void Configure(EntityTypeBuilder<LookupStatus> entity)
        {
            entity.HasKey(e => e.StatusId);
            entity.ToTable("LOOKUP_Status");
            entity.Property(e => e.StatusId).HasColumnName("Status_Id");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(150)
                .HasColumnName("Status_Description");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .HasColumnName("Status_Name");

            entity.HasData(
                new LookupStatus
                {
                    StatusId = 1,
                    StatusName = "Submitted",
                    StatusDescription = "The task has been submitted ."
                },
                new LookupStatus
                {
                    StatusId = 2,
                    StatusName = "Active",
                    StatusDescription = "The task is active and ongoing."
                },
                new LookupStatus
                {
                    StatusId = 3,
                    StatusName = "Completed",
                    StatusDescription = "The task has been completed successfully."
                },
                new LookupStatus
                {
                    StatusId = 4,
                    StatusName = "On Hold",
                    StatusDescription = "The task is temporarily paused and awaiting further action."
                },
                new LookupStatus
                {
                    StatusId = 5,
                    StatusName = "Cancelled",
                    StatusDescription = "The task has been cancelled and will not be completed."
                },
                new LookupStatus
                {
                    StatusId = 6,
                    StatusName = "In Progress",
                    StatusDescription = "The task is currently in progress and being worked on."
                }
            );
        }
    }
}
