using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Configurations
{
    public class CriticalLrisConfiguration : IEntityTypeConfiguration<CriticalLRIs>
    {
        public void Configure(EntityTypeBuilder<CriticalLRIs> entity)
        {
            entity.HasKey(e => e.rigRequestId);
            entity.OwnsOne(e => e.criticalLRI_Mids, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("criticalLRI_Mids");
                owned.Property(p => p.trafficLightId).HasColumnName("criticalLRI_Mids_TrafficLightId");
            });
            entity.OwnsOne(e => e.criticalLRI_Radar, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("criticalLRI_Radar");
                owned.Property(p => p.trafficLightId).HasColumnName("criticalLRI_Radar_TrafficLightId");
            });
            entity.OwnsOne(e => e.criticalLRI_Gps, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("criticalLRI_Gps");
                owned.Property(p => p.trafficLightId).HasColumnName("criticalLRI_Gps_TrafficLightId");
            });
            entity.OwnsOne(e => e.criticalLRI_Other, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("criticalLRI_Other");
                owned.Property(p => p.trafficLightId).HasColumnName("criticalLRI_Other_TrafficLightId");
            });
        }
    }
}
