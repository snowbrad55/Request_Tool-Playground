using TyphoonTaskingTool.Components;

namespace TyphoonTaskingTool.Models.RigRequestModels
{
    public class MissionPlanning
    {
        public Guid rigRequestId { get; set; }
        public RigRequest request { get; set; } = default!;
        public RigRequestSetupField missionPlanning_MissionType { get; set; } = new();
        public RigRequestSetupField missionPlanning_Maps { get; set; } = new();
        public RigRequestSetupField missionPlanning_L16_Ntwk { get; set; } = new();
        public RigRequestSetupField missionPlanning_L16_IDS { get; set; } = new();
        public RigRequestSetupField missionPlanning_Ss_Mission_File { get; set; } = new();
        public RigRequestSetupField MissionPlanning_Geo_Location { get; set; } = new();
    }
}
