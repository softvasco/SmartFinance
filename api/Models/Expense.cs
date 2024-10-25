namespace api.Models
{
    public class Expense : BaseEntity
    {
        public int SubcategoryID { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}