using Microsoft.EntityFrameworkCore;
using SGF.Data;
using SGF.DTO;
using SGF.Interfaces.IRepository;
using SGF.Models;

namespace SGF.Repositories
{
    public class RevenueCategoryRepository : IRevenueCategoryRepository
    {
        private readonly AppDbContext _context;

        public RevenueCategoryRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Add(RevenueCategoryModel revenueCategory)
        {
            _context.RevenueCategories.AddAsync(revenueCategory);
            _context.SaveChangesAsync();
        }


        public async Task<RevenueCategoryModel> GetById(int id)
        {
            return await _context.RevenueCategories
                 .Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public async Task<List<RevenueCategoryModel>> ListByUser(int userId)
        {
            var list = await _context.RevenueCategories
                .Where(x => x.UserId == userId).ToListAsync();
            return list;

        }


        public async Task Update(RevenueCategoryModel revenue)
        {
               _context.RevenueCategories.Update(revenue);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(RevenueCategoryModel revenue)
        {
            _context.RevenueCategories.Remove(revenue);
            await _context.SaveChangesAsync();
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
