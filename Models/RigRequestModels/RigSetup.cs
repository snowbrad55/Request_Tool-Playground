using TyphoonTaskingTool.Components;

namespace TyphoonTaskingTool.Models.RigRequestModels
{
    public class RigSetup
    {
        public Guid rigRequestId { get; set; }
        public RigRequest request { get; set; } = default!;
        public RigRequestSetupField rigSetup_Patching { get; set; } = new();
        public RigRequestSetupField rigSetup_Avionic_Std { get; set; } = new();
        public RigRequestSetupField rigSetup_Radar_Software { get; set; } = new();
        public RigRequestSetupField rigSetup_Geo_Location { get; set; } = new();
    }
}
