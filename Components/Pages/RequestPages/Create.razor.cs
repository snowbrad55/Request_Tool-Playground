using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Net.WebSockets;
using TyphoonTaskingTool.DTOs;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Components.Pages.RequestPages
{
    public partial class Create
    {

        private MudForm? _form;
        private bool _isValid;
        private string[] _errors = Array.Empty<string>();

        //Add attachments
        private IReadOnlyList<IBrowserFile>? _uploadFile;
        private bool _uploading = false;
        private double _uploadMin = 0;
        private double _uploadMax = 100;
        private double _uploadValue = 0;

        [SupplyParameterFromForm]
        private RequestsDTO Request { get; set; } = new();

        [CascadingParameter]
        IMudDialogInstance MudDialog { get; set; } = default!;

        private void CloseDialog() => MudDialog.Close(DialogResult.Ok(true));

        private async Task SubmitForm()
        {
            if (_form == null)
                return;

            await _form.ValidateAsync();
            var isValid = _form.IsValid;
            if (!isValid)
                return;

            using var context = DbFactory.CreateDbContext();
            var entity = new Models.Request
            {
                RequestShortId = Request.RequestShortId,
                RequestCreated = Request.RequestCreated,
                RankId = Request.RankId,
                RequestFirstName = Request.RequestFirstName,
                RequestLastName = Request.RequestLastName,
                RequestEmailAdd = Request.RequestEmailAdd,
                RequestContactPhone = Request.RequestContactPhone,
                UnitId = Request.UnitId,
                TeamId = Request.TeamId,
                RequestTitle = Request.RequestTitle,
                RequestTaskDescription = Request.RequestTaskDescription,
                StatusId = 1,
                RequestArchive = Request.RequestArchive
            };

            context.Requests.Add(entity);
            await context.SaveChangesAsync();
            NavigationManager.NavigateTo("/requests");
            Snackbar.Add("Request Created", Severity.Success);

        }

        private List<LookupRankDTO> _rankList = new();
        private List<LookupUnitDTO> _unitList = new();
        private List<LookupTeamDTO> _teamList = new();

        protected override async Task OnInitializedAsync()
        {
            var ranks = await LookupRankService.GetAllOrderedAsync();
            _rankList = ranks ?? new();

            var units = await LookupUnitService.GetAllOrderedAsync();
            _unitList = units ?? new();

            var teams = await LookupTeamService.GetAllOrderedAsync();
            _teamList = teams ?? new();
        }

        private async Task Upload()
        {
            if(_uploadFile == null || _uploadFile.Any())
            {
                return;
            }

            var file = _uploadFile.First();
            _uploading = true;
            using var ms = new MemoryStream();
            // 20 MB file size limit.
            var stream = file.OpenReadStream(maxAllowedSize: 20 * 1024 * 1024);

            var buffer = new byte[81920];
            int bytesRead;
            long totalBytesRead = 0;
            long totalLength = file.Size;

            while((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await ms.WriteAsync(buffer, 0, bytesRead);
                totalBytesRead += bytesRead;
                _uploadValue = (double)totalBytesRead / totalLength * 100;
                StateHasChanged();
            }

            using var context = DbFactory.CreateDbContext();

            var attachment = new RequestAttachment
            {
                AttachementId = Guid.NewGuid(),
                RequestTaskId = Request.RequestTaskId,
                FileName = file.Name,
                ContentType = file.ContentType,
                FileContent = ms.ToArray(),
                UploadTimestamp = DateTime.Now
            };

            context.RequestAttachements.Add(attachment);
            await context.SaveChangesAsync();

            _uploading = false;
            _uploadValue = 0;
        }
    }
}