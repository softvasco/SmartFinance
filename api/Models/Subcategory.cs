namespace api.Models
{
    public class Subcategory : BaseEntity
    {
        // Foreign key to Category
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}