namespace api.Models
{
    public class Category : BaseEntity
    {
        public ICollection<Subcategory> Subcategories { get; set; }
    }
}
