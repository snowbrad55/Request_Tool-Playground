using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Configurations
{
    public class RequestAttachmentConfiguration : IEntityTypeConfiguration<RequestAttachment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RequestAttachment> entity)
        {
            entity.HasKey(e => e.AttachementId);
            entity.Property(e => e.AttachementId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("Attachement_Id");
            entity.Property(e => e.RequestTaskId)
                .HasColumnName("Request_TaskId");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("File_Name");
            entity.Property(e => e.ContentType)
                .HasColumnType("text")
                .HasColumnName("Content_Type");
            entity.Property(e => e.FileContent)
                .HasColumnName("File_Content");
            entity.Property(e => e.UploadTimestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("Upload_Timestamp");
            entity.HasOne(d => d.RequestTask)
                .WithMany(p => p.RequestAttachments)
                .HasForeignKey(d => d.RequestTaskId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RequestAttachment_Request");
        }
    }
}
