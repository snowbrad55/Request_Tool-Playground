using TyphoonTaskingTool.Components;

namespace TyphoonTaskingTool.Models.RigRequestModels
{
    public class CriticalLRIs
    {
        public Guid rigRequestId { get; set; }
        public RigRequest request { get; set; } = default!;
        public RigRequestSetupField criticalLRI_Mids { get; set; } = new();
        public RigRequestSetupField criticalLRI_Radar { get; set; } = new();
        public RigRequestSetupField criticalLRI_Gps { get; set; } = new();
        public RigRequestSetupField criticalLRI_Other { get; set; } = new();
    }
}
