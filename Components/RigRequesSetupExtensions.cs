using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TyphoonTaskingTool.Components
{
    public static class RigRequestSetupExtensions
    {
        public static void OwnsSetupField<T>(
            this OwnedNavigationBuilder<T, RigRequestSetupField> builder, string prefix)
            where T : class
        {
            builder.Property(f => f.Description)
                .HasColumnName($"{prefix}_Description");
            builder.Property(f => f.trafficLightId)
                .HasColumnName($"{prefix}_TrafficLightId");
        }
    }
}
