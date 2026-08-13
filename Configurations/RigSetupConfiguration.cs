using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Configurations
{
    public class RigSetupConfiguration : IEntityTypeConfiguration<RigSetup>
    {
        public void Configure(EntityTypeBuilder<RigSetup> entity)
        {
            entity.HasKey(e => e.rigRequestId);

            entity.OwnsOne(e => e.rigSetup_Patching, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("rigSetup_Patching");
                owned.Property(p => p.trafficLightId).HasColumnName("rigSetup_Patching_TrafficLightId");
            });

            entity.OwnsOne(e => e.rigSetup_Avionic_Std, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("rigSetup_Avionic_Std");
                owned.Property(p => p.trafficLightId).HasColumnName("rigSetup_Avionic_Std_TrafficLightId");
            });

            entity.OwnsOne(e => e.rigSetup_Radar_Software, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("rigSetup_Radar_Software");
                owned.Property(p => p.trafficLightId).HasColumnName("rigSetup_Radar_Software_TrafficLightId");
            });

            entity.OwnsOne(e => e.rigSetup_Geo_Location, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("rigSetup_Geo_Location");
                owned.Property(p => p.trafficLightId).HasColumnName("rigSetup_Geo_Location_TrafficLightId");
            });
        }
    }
}
