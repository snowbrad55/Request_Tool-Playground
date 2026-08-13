using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Configurations
{
    public class DataRecordingConfiguration : IEntityTypeConfiguration<DataRecording>
    {
        public void Configure(EntityTypeBuilder<DataRecording> entity)
        {
            entity.HasKey(e => e.rigRequestId);
            entity.OwnsOne(e => e.recording_1, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("recording_1");
                owned.Property(p => p.trafficLightId).HasColumnName("recording_1_TrafficLightId");
            });
            entity.OwnsOne(e => e.recording_2, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("recording_2");
                owned.Property(p => p.trafficLightId).HasColumnName("recording_2_TrafficLightId");
            });
            entity.OwnsOne(e => e.recording_3, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("recording_3");
                owned.Property(p => p.trafficLightId).HasColumnName("recording_3_TrafficLightId");
            });
            entity.OwnsOne(e => e.recording_4, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("recording_4");
                owned.Property(p => p.trafficLightId).HasColumnName("recording_4_TrafficLightId");
            });
            entity.OwnsOne(e => e.recording_5, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("recording_5");
                owned.Property(p => p.trafficLightId).HasColumnName("recording_5_TrafficLightId");
            });
            entity.OwnsOne(e => e.recording_6, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("recording_6");
                owned.Property(p => p.trafficLightId).HasColumnName("recording_6_TrafficLightId");
            });
            entity.OwnsOne(e => e.mhdd, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("mhdd");
                owned.Property(p => p.trafficLightId).HasColumnName("mhdd_TrafficLightId");
            });
            entity.OwnsOne(e => e.additionalRecording, owned =>
            {
                owned.Property(p => p.Description).HasColumnName("additionalRecording");
                owned.Property(p => p.trafficLightId).HasColumnName("additionalRecording_TrafficLightId");
            });
        }
    }
}
