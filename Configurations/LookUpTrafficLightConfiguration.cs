using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class LookUpTrafficLightConfiguration : IEntityTypeConfiguration<LookupTrafficLight>
    {
        public void Configure(EntityTypeBuilder<LookupTrafficLight> entity)
        {
            entity.HasKey(e => e.trafficLightId);
            
            entity.ToTable("LOOKUP_TrafficLight");

            entity.Property(e => e.trafficLightId)
                .HasColumnName("TrafficLightID");
            entity.Property(e => e.trafficLightName)
                .HasColumnName("TrafficLightName");
            entity.Property(e => e.trafficLightDescription)
                .HasColumnName("TrafficLightDescription");

            entity.HasData(
                new LookupTrafficLight
                {
                    trafficLightId = 1,
                    trafficLightName = "BLANK",
                    trafficLightDescription = "Not Required"
                },
                new LookupTrafficLight
                {
                    trafficLightId = 2,
                    trafficLightName = "YELLOW",
                    trafficLightDescription = "Desirable"
                },
                new LookupTrafficLight
                {
                    trafficLightId = 3,
                    trafficLightName = "AMBER",
                    trafficLightDescription = "Highly Desirable"
                },
                new LookupTrafficLight
                {
                    trafficLightId = 4,
                    trafficLightName = "RED",
                    trafficLightDescription = "Essential"
                }
            );
        }
    }
}
