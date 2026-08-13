using TyphoonTaskingTool.Components;

namespace TyphoonTaskingTool.Models.RigRequestModels
{
    public class AdditionalSystems
    {
        public Guid rigRequestId { get; set; }
        public RigRequest request { get; set; } = default!;
        public RigRequestSetupField additionalSystem_Mids_Tiger { get; set; } = new();
        public RigRequestSetupField additionalSystem_Pasis { get; set; } = new();
        public RigRequestSetupField additionalSystem_Meteor_Em { get; set; } = new();
        public RigRequestSetupField additionalSystem_Asraam_Em { get; set; } = new();
        public RigRequestSetupField additionalSystem_SS_Em { get; set; } = new();
        public RigRequestSetupField additionalSystem_B2_Em { get; set; } = new();
    }
}
