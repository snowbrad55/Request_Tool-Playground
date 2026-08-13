using Microsoft.AspNetCore.Components;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Components
{
    public partial class RigRequestFieldEditor
    {
        [Parameter] public string label { get; set; } = default!;
        [Parameter] public RigRequestSetupField Field { get; set; } = default!;
        [Parameter] public List<LookupTrafficLight> trafficLights { get; set; } = new();

    }
}