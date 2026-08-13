using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Configurations
{
    public class MissionPlanningConfiguration : IEntityTypeConfiguration<MissionPlanning>
    {
        public void Configure(EntityTypeBuilder<MissionPlanning> entity)
        {
            entity.HasKey(e => e.rigRequestId);
            entity.OwnsOne(e => e.missionPlanning_MissionType, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("missionPlanning_MissionType");
                owned.Property(p => p.trafficLightId).HasColumnName("missionPlanning_MissionType_TrafficLightId");
            });
            entity.OwnsOne(e => e.missionPlanning_Maps, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("missionPlanning_Maps");
                owned.Property(p => p.trafficLightId).HasColumnName("missionPlanning_Maps_TrafficLightId");
            });
            entity.OwnsOne(e => e.missionPlanning_L16_Ntwk, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("missionPlanning_L16_Ntwk");
                owned.Property(p => p.trafficLightId).HasColumnName("missionPlanning_L16_Ntwk_TrafficLightId");
            });
            entity.OwnsOne(e => e.missionPlanning_L16_IDS, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("missionPlanning_L16_IDS");
                owned.Property(p => p.trafficLightId).HasColumnName("missionPlanning_L16_IDS_TrafficLightId");
            });
            entity.OwnsOne(e => e.missionPlanning_Ss_Mission_File, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("missionPlanning_Ss_Mission_File");
                owned.Property(p => p.trafficLightId).HasColumnName("missionPlanning_Ss_Mission_File_TrafficLightId");
            });
            entity.OwnsOne(e => e.MissionPlanning_Geo_Location, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("MissionPlanning_Geo_Location");
                owned.Property(p => p.trafficLightId).HasColumnName("MissionPlanning_Geo_Location_TrafficLightId");
            });
        }
    }
}
