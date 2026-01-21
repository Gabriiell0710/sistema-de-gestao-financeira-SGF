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
    public class UserService : IUserService
    {

        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task AddUser(UserModel user)
        {
            await _repository.AddUser(user);
        }

        public async Task<UserModel> GetUserByLogin(string login, string password)
        {
           return await _repository.GetUserByLogin(login, password);
        }

        public async Task<bool> LoginExists(string login)
        {
            return await _repository.LoginExists(login);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
