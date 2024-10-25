namespace api.Models
{
    public class Tag : BaseEntity
    {
        public string Code { get; set; } = string.Empty;


        // N:N relationship with Subcategories
        public ICollection<Subcategory> Subcategories { get; set; }
    }
}
