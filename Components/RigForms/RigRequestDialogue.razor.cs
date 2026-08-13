using Microsoft.AspNetCore.Components;
using MudBlazor;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.Models;
using TyphoonTaskingTool.Models.RigRequestModels;

namespace TyphoonTaskingTool.Components.RigForms
{
    public partial class RigRequestDialogue
    {
        [CascadingParameter]
        private IMudDialogInstance MudDialog { get; set; } = default!;

        private TmscDbContext _context = default!;
        private List<LookupTrafficLight> trafficLights = new();

        private RigControllerModel Model = new()
        {
            rigRequest = new RigRequest(),
            rigSetup = new RigSetup(),
            criticalLRIs = new CriticalLRIs(),
            dataRecording = new DataRecording(),
            additionalSystems = new AdditionalSystems(),
            missionPlanning = new MissionPlanning(),
        };

        protected override async Task OnInitializedAsync()
        {
            //trafficLights = await _context.trafficLights
            //    .Orderby(t => t.Id)
            //    .ToListAsync();
        }

        private async Task onSubmit()
            {
                Console.WriteLine("Submitting Rig Request...");
            // _context.RigRequests.Add(Model);
            // await _context.SaveChangesAsync();
            MudDialog.Close(DialogResult.Ok(Model));
            }
        private void Cancel()
        {
            MudDialog.Cancel();
        }
    }
}