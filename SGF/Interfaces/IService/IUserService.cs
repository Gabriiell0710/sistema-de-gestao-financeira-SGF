using SGF.DTO;
using SGF.Models;

namespace SGF.Interfaces.IService
{
    public interface IUserService : IDisposable
    {
        Task AddUser(UserModel user);
        Task<UserModel> GetUserByLogin (string login, string password);
        bool LoginExists(string login);
        bool UserValidation(UserDto userDto);
        Task UserLoginValidation(UserLoginDto userLoginDto);
    }
}
