namespace SGF.Models
{
    public class RevenueModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public int RevenueCategoryId { get; set; }
       

        public RevenueCategoryModel RevenueCategory { get; set; }

     
    }
}
