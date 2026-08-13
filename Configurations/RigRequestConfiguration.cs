using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class RigRequestConfiguration : IEntityTypeConfiguration<RigRequest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RigRequest> entity)
        {
            entity.HasKey(e => e.rigRequestId);

            entity.Property(e => e.rigRequestId)                
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("Rig_Request_Id");
            entity.Property(e => e.rigRequestCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("Rig_Request_Created");
            entity.Property(e => e.rigRequestTitle)
                .HasMaxLength(150)
                .HasColumnName("Rig_Request_Title");
            entity.Property(e => e.rigRequestStartDate)
                .HasColumnType("timestamp with time zone");
            entity.Property(e => e.rigRequestEndDate)
                .HasColumnType("timestamp with time zone");
            entity.Property(e => e.rigRequestDescription)
                .HasMaxLength(500);
            entity.Property(e => e.rigRequestAddtionalRig);
            entity.Property(e => e.rigRequestAdditionalMD);
            entity.Property(e => e.statusId)
                .HasColumnName("Status_Id");
            entity.Property(e => e.rigRequestArchive);
            entity.Property(e => e.rigRequestName)
                .HasMaxLength(150)
                .HasColumnName("Rig_Request_Name");
            entity.Property(e => e.rigRequestRankId);
        }
    }
}
