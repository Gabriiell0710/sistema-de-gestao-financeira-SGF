namespace SGF.Models
{
    public class RevenuesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public int RevenueCategoryId { get; set; }
       
        public RevenueCategoryModel RevenueCategory { get; set; }
     
    }
}
