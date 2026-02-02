using SGF.DTO;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF.Services
{
    public class RevenueService : IRevenueService
    {
        private readonly IRevenueRepository _repository;
        private int _idSelected = 0;

        public RevenueService(IRevenueRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(RevenueModel revenue)
        {
           await _repository.Add(revenue);
        }


        public async Task<RevenueModel> GetById(int id)
        {
            return await _repository.GetById(id);
        }


        public async Task<List<RevenueModel>> ListByUser(int userId)
        {
            return await _repository.ListByUser(userId);
        }


        public async Task Update(RevenueDto dto)
        {
            var revenue = await _repository.GetById(dto.Id);
            revenue.Description = dto.Description;
            revenue.Value = dto.Value;
            revenue.Date = dto.Date;
            await _repository.Update(revenue);
        }


        public async Task Delete(int id)
        {
            var revenue = await _repository.GetById(id);
            await _repository.Delete(revenue);
        }


        public async Task RevenueValidation(RevenueDto dto)
        {
            if(string.IsNullOrEmpty(dto.Description))
            {
                MessageBox.Show("Preencha a descrição!");
            }
            if(dto.RevenueCategoryId == null)
            {
                MessageBox.Show("Selecione uma categoria.");
            }
            if(dto.Value == null)
            {
                MessageBox.Show("Adicione um valor!");
            }


            if(_idSelected == 0)
            {
                var revenue = new RevenueModel()
                {
                    Description = dto.Description,
                    Value = dto.Value,
                    Date = dto.Date,
                    RevenueCategoryId = dto.RevenueCategoryId,

                };
                await _repository.Add(revenue);
            }
            else
            {
                var revenue = await _repository.GetById(_idSelected);
                revenue.Description = dto.Description;
                revenue.Value = dto.Value;
                revenue.Date = dto.Date;
                revenue.RevenueCategoryId = dto.RevenueCategoryId;

                await _repository.Update(revenue);
            }
            ClearForm(dto);
            _idSelected = 0;
        }


        public void IdRevenueSelected(int id)
        {
            _idSelected = id;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async void ClearForm(RevenueDto dto)
        {
            dto.Description = "";
            dto.Value = 0;
            dto.Date = DateTime.Now;
            dto.RevenueCategoryId = 0;
        }


    }
}
