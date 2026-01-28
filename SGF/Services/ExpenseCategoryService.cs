using SGF.DTO;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Models;

namespace SGF.Services
{
    public class ExpenseCategoryService : IExpenseCategoryService
    {
        private readonly IExpenseCategoryRepository _repository;
        private int _idSelected = 0;

        public ExpenseCategoryService(IExpenseCategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(ExpenseCategoryModel expenseCategory)
        {
            await _repository.Add(expenseCategory);
        }


        public async Task<ExpenseCategoryModel> GetById(int id)
        {
            return await _repository.GetById(id);
        }


        public Task<List<ExpenseCategoryModel>> ListByUser(int userId)
        {
            return _repository.ListByUser(userId);
        }


        public async Task Update(ExpenseCategoryDto expenseDto)
        {
            // This method is empty //
        }


        public async Task ExpenseCategoryValidation(ExpenseCategoryDto expenseDto)
        {
            if (string.IsNullOrEmpty(expenseDto.Name))
            {
                MessageBox.Show("O nome não pode estar vazio");
            }

            if(_idSelected == 0)
            {
                var expense = new ExpenseCategoryModel
                {
                    Name = expenseDto.Name,
                    UserId = expenseDto.UserId,
                };
                await _repository.Add(expense);
            }
            else
            {
                var expense = await _repository.GetById(_idSelected);

                expense.Name = expenseDto.Name;

                await _repository.Update(expense);
            }

            expenseDto.Name = "";
            _idSelected = 0;
        }


        public void IdExpenseSelected(int id)
        {
            _idSelected = id;
        }


        public async Task Delete(int id)
        {
            var expense = await _repository.GetById(id);
            await _repository.Delete(expense);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }





    }
}
