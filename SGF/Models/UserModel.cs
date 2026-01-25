using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<RevenueCategoryModel> RevenueCategory { get; set; }
        public List<ExpenseCategoryModel> ExpenseCategory { get; set; }

        public List<RevenuesModel> Revenues { get; set; }
        public List<ExpensesModel> Expenses { get; set; }

    }
}
