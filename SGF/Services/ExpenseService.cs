using SGF.DTO;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Models;

namespace SGF.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;
        private int _idSelected = 0;

        public ExpenseService(IExpenseRepository repository)
        {
            _repository = repository;
        }



        public async Task Add(ExpenseModel expense)
        {
            await _repository.Add(expense);
        }


        public async Task<ExpenseModel> GetById(int id)
        {
            return await _repository.GetById(id);
        }


        public async Task<List<ExpenseModel>> ListByUser(int userId)
        {
            return await _repository.ListByUser(userId);
        }


        public Task Update(ExpenseDto dto)
        {
            throw new NotImplementedException();
        }


        public async Task ExpenseValidation(ExpenseDto dto)
        {
            if (string.IsNullOrEmpty(dto.Description))
            {
                MessageBox.Show("Preencha a descrição!");
            }
            if (dto.ExpenseCategoryId == null)
            {
                MessageBox.Show("Selecione uma categoria.");
            }
            if (dto.Value == null)
            {
                MessageBox.Show("Adicione um valor!");
            }


            if (_idSelected == 0)
            {
                var expense = new ExpenseModel()
                {
                    Description = dto.Description,
                    Value = dto.Value,
                    Date = dto.Date,
                    ExpenseCategoryId = dto.ExpenseCategoryId,

                };
                await _repository.Add(expense);
            }
            else
            {
                var expense = await _repository.GetById(_idSelected);
                expense.Description = dto.Description;
                expense.Value = dto.Value;
                expense.Date = dto.Date;
                expense.ExpenseCategoryId = dto.ExpenseCategoryId;

                await _repository.Update(expense);
            }
            ClearForm(dto);
            _idSelected = 0;
        }


        public async Task Delete(int id)
        {
            var expense = await _repository.GetById(id);
            await _repository.Delete(expense);
        }


        public void IdExpenseSelected(int id)
        {
            _idSelected = id;
        }


        public async void ClearForm(ExpenseDto dto)
        {
            dto.Description = "";
            dto.Value = 0;
            dto.Date = DateTime.Now;
            dto.ExpenseCategoryId = 0;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
