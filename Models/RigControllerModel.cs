using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Models
{
    public class RigControllerModel
    {
        public RigRequest rigRequest { get; set; } = new();
        public RigSetup rigSetup { get; set; } = new();
        public CriticalLRIs criticalLRIs { get; set; } = new();
        public DataRecording dataRecording { get; set; } = new();
        public MissionPlanning missionPlanning { get; set; } = new();
        public AdditionalSystems additionalSystems { get; set; } = new();
    }
}
