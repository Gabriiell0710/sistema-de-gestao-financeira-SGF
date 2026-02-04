namespace SGF.DTO
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public int ExpenseCategoryId { get; set; }
    }
}
