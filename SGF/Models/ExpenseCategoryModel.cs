namespace SGF.Models
{
    public class ExpenseCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int ExpenseId { get; set; }

        public UserModel User { get; set; }
        public List<ExpensesModel> Expenses { get; set; }

    }
}
