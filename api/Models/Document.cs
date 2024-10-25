namespace api.Models
{
    public class Document : BaseEntity
    {
        public byte[]? Attachment { get; set; } = [];
        public string? FileName { get; set; }
    }
}