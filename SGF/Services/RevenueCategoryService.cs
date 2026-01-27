using SGF.DTO;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Models;
using System.Threading.Tasks;

namespace SGF.Services
{
    public class RevenueCategoryService : IRevenueCategoryService
    {
        private readonly IRevenueCategoryRepository _repository;
        private int _idSelected = 0; 

        public RevenueCategoryService(IRevenueCategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task Add(RevenueCategoryModel revenueCategory)
        {
            await _repository.Add(revenueCategory);
        }

        public async Task<RevenueCategoryModel> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<List<RevenueCategoryModel>> ListByUser(int userId)
        {
            return await _repository.ListByUser(userId);
        }

        public async Task Update(RevenueCategoryDto revenueDto)
        {
            /*var revenue = await _repository.GetById(revenueDto.Id);
            revenue.Name = revenueDto.Name;
            await _repository.Update(revenue);*/
        }

        public async Task Delete(int id)
        {
            var revenue = await _repository.GetById(id);
            await _repository.Delete(revenue);
        }

        public async Task RevenueCategoryValidation(RevenueCategoryDto dto)
        {
            if(string.IsNullOrEmpty(dto.Name))
            {
                MessageBox.Show("O nome não pode estar vazio");
            }

            if (_idSelected == 0)
            {

                var revenue = new RevenueCategoryModel
                {
                    Name = dto.Name,
                    UserId = dto.UserId,
                };

                await _repository.Add(revenue);
            }
            else
            {
                var revenue = await _repository.GetById(_idSelected);

                revenue.Name = dto.Name;

                await _repository.Update(revenue);
            }

            dto.Name = "";
            dto.Id = 0;
        }
        public void IdRevenueSelected(int id)
        {
            _idSelected = id;
        }

        public void Dispose() => _repository.Dispose();
        

    }
}
