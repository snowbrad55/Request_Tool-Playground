namespace TyphoonTaskingTool.DTOs
{
    public class RequestUpdatesDTO
    {
        public Guid UpdateId { get; set; }

        public Guid RequestTaskId { get; set; }

        public DateTime? UpdateTimeStamp { get; set; }

        public string? UpdateDescription { get; set; }

        public string? UpdateBy { get; set; }
        public int? PriorityId { get; set; }
        public string? AssignedUserId { get; set; }
        public string? AssignedUserName { get; set; }
        public string? StatusName { get; set; }
        public string? TeamNameShort { get; set; }

    }
}
