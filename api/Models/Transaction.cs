namespace api.Models
{
    public class Transaction: BaseEntity
    {
        public ICollection<Document> Documents { get; set; } = [];
    }
}
