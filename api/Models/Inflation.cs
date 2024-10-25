namespace api.Models
{
    public class Inflation : BaseEntity
    {
        public int Year { get; set; }
        public decimal Percent { get; set; }
    }
}
