using SGF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF.Interfaces.IRepository
{
    public interface IUserRepository : IDisposable
    {
        Task AddUser(UserModel user);
        Task<UserModel> GetUserByLogin (string login, string password);
        Task<UserModel> LoginExists(string login);

    }
}
