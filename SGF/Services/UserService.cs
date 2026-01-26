using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using SGF.DTO;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Models;
using SGF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SGF.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _repository;
        private readonly IServiceProvider _provider;
        private UserSession _userSession;

        public UserService(IUserRepository repository, IServiceProvider provider, UserSession userSession)
        {
            _repository = repository;
            _provider = provider;
            _userSession = userSession;
        }

        public async Task AddUser(UserModel user)
        {
            await _repository.AddUser(user);
        }

        public async Task<UserModel> GetUserByLogin(string login, string password)
        {
            return await _repository.GetUserByLogin(login, password);
        }

        public bool LoginExists(string login)
        {
            return  _repository.LoginExists(login);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool UserValidation(UserDto userDto)
        {
            if (string.IsNullOrEmpty(userDto.Name) ||
                string.IsNullOrEmpty(userDto.Login) ||
                string.IsNullOrEmpty(userDto.Password) ||
                string.IsNullOrEmpty(userDto.PassConfirm))
            {
                MessageBox.Show("Preencha todos os campos!");
                return false;
            }

            if (userDto.Password != userDto.PassConfirm)
            {
                MessageBox.Show("As senhas devem ser iguais!");
                return false;
            }

            var userRegistered = _repository.LoginExists(userDto.Login);

            if (userRegistered)
            {
                MessageBox.Show("O nome de usuário já existe!");
                return false;
            }

            UserModel newUser = new UserModel()
            {
                Name = userDto.Name,
                Login = userDto.Login,
                Password = userDto.Password,
            };

            _repository.AddUser(newUser);

            MessageBox.Show("Usuário criado com sucesso!");

            var session = _provider.GetRequiredService<UserSession>();
            session.Login(newUser);

            CloseForm("Login");
            MainSreen mainScreen = new MainSreen(_userSession, _provider);
            mainScreen.Show();
            

            return true;
        }

        private void CloseForm(string form)
        {
            Form frm = Application.OpenForms.Cast<Form>()
                .Where(x => x.Name == form)
                .FirstOrDefault();

            if (frm != null)
            {
                frm.Hide();
            }
        }

        public async Task UserLoginValidation(UserLoginDto userLoginDto)
        {
            if (string.IsNullOrEmpty(userLoginDto.Login) || string.IsNullOrEmpty(userLoginDto.Password))
            {
                MessageBox.Show("Preencha o usuário e a senha!");
                return;
            }

            UserModel loggedUser = await _repository.GetUserByLogin(userLoginDto.Login, userLoginDto.Password);

            if (loggedUser == null)
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                return;
            }

            var session = _provider.GetRequiredService<UserSession>();
            session.Login(loggedUser);

            MessageBox.Show($"Bem-Vindo, {loggedUser.Name}");
            CloseForm("Login");
            MainSreen mainScreen = new MainSreen(_userSession, _provider);
            mainScreen.Show();
        }
    }
}   
