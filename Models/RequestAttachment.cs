namespace TyphoonTaskingTool.Models
{
    public partial class RequestAttachment
    {
        public Guid AttachementId { get; set; }
        public Guid RequestTaskId { get; set; }
        public string? FileName { get; set; }
        public string? ContentType { get; set; }
        public byte[]? FileContent { get; set; }
        public DateTime UploadTimestamp { get; set; }
        public virtual Request RequestTask { get; set; } = null!;
    }
}
