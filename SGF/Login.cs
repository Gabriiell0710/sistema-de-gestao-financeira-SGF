using Microsoft.Extensions.DependencyInjection;
using SGF.Interfaces.IService;
using SGF.Models;
using SGF.Services;

namespace SGF
{
    public partial class Login : Form 
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _provider;
       
        public Login(IUserService userService, IServiceProvider provider)
        {
            InitializeComponent();

            _userService = userService;
            _provider = provider;
            btnEntrer.Click += btnEnter_Click;
            btnRegister.Click += btnRegister_Click;
        }

        public async void btnEnter_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text.Trim();
            string password = textPassword.Text.Trim();

            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha o usuário e a senha!");
                return;
            }
            // Verification if user exists
            Task<UserModel> loggedUser = _userService.GetUserByLogin(login, password);

            UserModel userModel =  await loggedUser;
            
            if(userModel == null)
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                return;
            }

            //Login OK
            MessageBox.Show($"Bem-Vindo, {userModel.Name}");

            this.Hide();
            // Code for open main form //
        
        }   

        public async void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister userRegisterForm = _provider.GetRequiredService<UserRegister>();
            userRegisterForm.ShowDialog();
        }


    }
}
