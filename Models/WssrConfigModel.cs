using TyphoonTaskingTool.Components;

namespace TyphoonTaskingTool.Models
{
    public class WssrConfigModel
    {
        public RigRequestSetupField Rig_Patching { get; set; } = new();
        public RigRequestSetupField Rig_Avionics { get; set; } = new();
        public RigRequestSetupField Rig_RadarSoftware { get; set; } = new();
        public RigRequestSetupField Rig_GeoLocation { get; set; } = new();

        public RigRequestSetupField LRI_Mids { get; set; } = new();
        public RigRequestSetupField LRI_Radar { get; set; } = new();
        public RigRequestSetupField LRI_Gps { get; set; } = new();
        public RigRequestSetupField LRI_Other { get; set; } = new();

        public RigRequestSetupField Sys_MidsTiger { get; set; } = new();
        public RigRequestSetupField Sys_Pasis { get; set; } = new();
        public RigRequestSetupField Sys_Meteor { get; set; } = new();
        public RigRequestSetupField Sys_Asraam { get; set; } = new();
        public RigRequestSetupField Sys_SS { get; set; } = new();
        public RigRequestSetupField Sys_B2 { get; set; } = new();
        public RigRequestSetupField Sys_LDP { get; set; } = new();

        public RigRequestSetupField Rec_1 { get; set; } = new();
        public RigRequestSetupField Rec_2 { get; set; } = new();
        public RigRequestSetupField Rec_3 { get; set; } = new();
        public RigRequestSetupField Rec_4 { get; set; } = new();
        public RigRequestSetupField Rec_5 { get; set; } = new();
        public RigRequestSetupField Rec_6 { get; set; } = new();
        public RigRequestSetupField Rec_MHDD { get; set; } = new();
        public RigRequestSetupField Rec_Additional { get; set; } = new();
    }

}
