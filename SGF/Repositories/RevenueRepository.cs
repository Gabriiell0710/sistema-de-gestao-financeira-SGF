using Microsoft.EntityFrameworkCore;
using SGF.Data;
using SGF.Interfaces.IRepository;
using SGF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF.Repositories
{
    public class RevenueRepository : IRevenueRepository
    {
        private readonly AppDbContext _context;

        public RevenueRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(RevenueModel revenue)
        {
           await _context.Revenues.AddAsync(revenue);
            await _context.SaveChangesAsync();
        }


        public async Task<RevenueModel> GetById(int id)
        {
            return await _context.Revenues
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public async Task<List<RevenueModel>> ListByUser(int userId)
        {
            return await _context.Revenues
                .Where(x => x.RevenueCategory.UserId == userId).ToListAsync();
        }


        public async Task Update(RevenueModel revenue)
        {
             _context.Revenues.Update(revenue);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(RevenueModel revenue)
        {
             _context.Revenues.Remove(revenue);
            await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
