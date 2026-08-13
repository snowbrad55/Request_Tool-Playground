using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class RequestUpdateConfiguration : IEntityTypeConfiguration<RequestUpdate>
    {
        public void Configure(EntityTypeBuilder<RequestUpdate> entity)
        {
            entity.HasKey(e => e.UpdateId);

            entity.Property(e => e.UpdateId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("Update_Id");
            entity.Property(e => e.RequestTaskId).HasColumnName("Request_TaskId");
            entity.Property(e => e.StatusId).HasColumnName("Status_Id");
            entity.Property(e => e.TeamId).HasColumnName("Team_Id");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .HasColumnName("Update_By");
            entity.Property(e => e.UpdateDescription)
                .HasColumnName("Update_Description");
            entity.Property(e => e.UpdateTimeStamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("Update_TimeStamp");
            entity.Property(e => e.AssignmentUserId)
                .HasMaxLength(450)
                .HasColumnName("Assignment_UserId");

            entity.HasOne(d => d.RequestTask).WithMany(p => p.RequestUpdates)
                .HasForeignKey(d => d.RequestTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UpdateRequest");

            entity.HasOne(d => d.Status).WithMany(p => p.RequestUpdates)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_UpdateStatus");

            entity.HasOne(d => d.Team).WithMany(p => p.RequestUpdates)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_UpdateTeam");

            entity.HasOne<ApplicationUser>().WithMany()
                .HasForeignKey(d => d.AssignmentUserId)
                .HasConstraintName("FK_UpdateAssignedUser");
        }
    }
}
