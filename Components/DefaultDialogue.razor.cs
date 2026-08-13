using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace TyphoonTaskingTool.Components
{
    public partial class DefaultDialogue
    {
        protected override void OnInitialized()
        {
            Console.WriteLine("Dialog initial");
        }
        public void Dispose()
        {
            Console.WriteLine("DialogDisposed");
        }
        [Parameter] public string? title { get; set; }
        [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = default!;
        private void CloseDialog()
        {
            MudDialog.Close(DialogResult.Ok(true));
        }
    }
}