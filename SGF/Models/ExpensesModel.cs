namespace SGF.Models
{
    public  class ExpensesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date {  get; set; }

        public int ExpenseCategoryId { get; set; }

        public ExpenseCategoryModel ExpenseCategory { get; set; }
    }
}
