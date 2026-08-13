using TyphoonTaskingTool.Components;

namespace TyphoonTaskingTool.Models.RigRequestModels
{
    public class DataRecording
    {
        public Guid rigRequestId { get; set; }
        public RigRequest request { get; set; } = default!;
        public RigRequestSetupField recording_1 { get; set; } = new();
        public RigRequestSetupField recording_2 { get; set; } = new();
        public RigRequestSetupField recording_3 { get; set; } = new();
        public RigRequestSetupField recording_4 { get; set; } = new();
        public RigRequestSetupField recording_5 { get; set; } = new();
        public RigRequestSetupField recording_6 { get; set; } = new();
        public RigRequestSetupField mhdd { get; set; } = new();
        public RigRequestSetupField additionalRecording { get; set; } = new();
    }
}
