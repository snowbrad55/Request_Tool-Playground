namespace TyphoonTaskingTool.DTOs
{
    public class RigRequestDTO
    {
        public Guid rigRequestId { get; set; }
        public DateTime rigRequestCreated { get; set; }
        public string? rigRequestTitle { get; set; }
        public DateTime rigRequestStartDate { get; set; }
        public DateTime? rigRequestEndDate { get; set; }
        public string? rigRequestDescription { get; set; }
        public string? rigRequestAddtionalRig { get; set; }
        public string? rigRequestAdditionalMD { get; set; }
        public int? statusId { get; set; }
        public bool? rigRequestArchive { get; set; }
        public string? rigRequestName { get; set; }
        public int? rigRequestRankId { get; set; }
    }
}
