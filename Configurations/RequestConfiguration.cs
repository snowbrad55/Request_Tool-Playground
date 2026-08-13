using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> entity)
        {
            entity.HasKey(e => e.RequestTaskId);

            entity.Property(e => e.RequestTaskId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("Request_TaskId");
            entity.Property(e => e.RankId).HasColumnName("Rank_Id");
            entity.Property(e => e.RequestArchive).HasColumnName("Request_Archive");
            entity.Property(e => e.RequestContactPhone)
                .HasMaxLength(15)
                .HasColumnName("Request_ContactPhone");
            entity.Property(e => e.RequestCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("Request_Created");
            entity.Property(e => e.RequestEmailAdd)
                .HasMaxLength(150)
                .HasColumnName("Request_EmailAdd");
            entity.Property(e => e.RequestFirstName)
                .HasMaxLength(50)
                .HasColumnName("Request_FirstName");
            entity.Property(e => e.RequestLastName)
                .HasMaxLength(50)
                .HasColumnName("Request_LastName");
            entity.Property(e => e.RequestShortId)
                .HasMaxLength(10)
                .HasColumnName("Request_ShortId");
            entity.Property(e => e.RequestTaskDescription)
                .HasColumnName("Request_TaskDescription");
            entity.Property(e => e.RequestTitle)
                .HasMaxLength(150)
                .HasColumnName("Request_Title");
            entity.Property(e => e.StatusId).HasColumnName("Status_Id");
            entity.Property(e => e.TeamId).HasColumnName("Team_Id");
            entity.Property(e => e.UnitId).HasColumnName("Unit_Id");

            entity.HasOne(d => d.Rank).WithMany(p => p.Requests)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Request_Rank");

            entity.HasOne(d => d.Status).WithMany(p => p.Requests)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_Request_Status");

            entity.HasOne(d => d.Team).WithMany(p => p.Requests)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_Request_Team");

            entity.HasOne(d => d.Unit).WithMany(p => p.Requests)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_Request_Unit");
        }
    }
}
