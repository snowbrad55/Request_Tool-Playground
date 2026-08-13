using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Configurations
{
    public class AdditionalSystemsConfiguration : IEntityTypeConfiguration<AdditionalSystems>
    {
        public void Configure(EntityTypeBuilder<AdditionalSystems> entity)
        {
                entity.HasKey(e => e.rigRequestId);
                entity.OwnsOne(e => e.additionalSystem_Mids_Tiger, owned =>
                {
                    owned.Property(p => p.Description).HasColumnName("additionalSystem_Mids_Tiger");
                    owned.Property(p => p.trafficLightId).HasColumnName("additionalSystem_Mids_Tiger_TrafficLightId");
                });
                entity.OwnsOne(e => e.additionalSystem_Pasis, owned =>
                {
                    owned.Property(p => p.Description).HasColumnName("additionalSystem_Pasis");
                    owned.Property(p => p.trafficLightId).HasColumnName("additionalSystem_Pasis_TrafficLightId");
                });
                entity.OwnsOne(e => e.additionalSystem_Meteor_Em, owned =>
                {
                    owned.Property(p => p.Description).HasColumnName("additionalSystem_Meteor_Em");
                    owned.Property(p => p.trafficLightId).HasColumnName("additionalSystem_Meteor_Em_TrafficLightId");
                });
                entity.OwnsOne(e => e.additionalSystem_Asraam_Em, owned =>
                {
                    owned.Property(p => p.Description).HasColumnName("additionalSystem_Asraam_Em");
                    owned.Property(p => p.trafficLightId).HasColumnName("additionalSystem_Asraam_Em_TrafficLightId");
                });
                entity.OwnsOne(e => e.additionalSystem_SS_Em, owned =>
                {
                    owned.Property(p => p.Description).HasColumnName("additionalSystem_SS_Em");
                    owned.Property(p => p.trafficLightId).HasColumnName("additionalSystem_SS_Em_TrafficLightId");
                });
                entity.OwnsOne(e => e.additionalSystem_B2_Em, owned =>
                {
                    owned.Property(p => p.Description).HasColumnName("additionalSystem_B2_Em");
                    owned.Property(p => p.trafficLightId).HasColumnName("additionalSystem_B2_Em_TrafficLightId");
                });
        }
    }
}
