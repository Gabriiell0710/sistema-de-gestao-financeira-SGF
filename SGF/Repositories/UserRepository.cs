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
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChangesAsync();
        }

        public async Task<UserModel> GetUserByLogin(string login, string password)
        {
            return await _context.Users
                .Where(u => u.Login == login && u.Password == password).FirstOrDefaultAsync();
        }

        public string LoginExists(string login)
        {
             var result =  _context.Users
                .Where(u => u.Login == login).FirstOrDefault();

            if(result == null)
            {
                return "";
            }
            else
            {
                return result.Login.ToString();
            }
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
