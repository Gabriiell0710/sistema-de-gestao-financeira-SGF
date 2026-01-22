using Microsoft.Extensions.DependencyInjection;
using SGF.DTO;
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
 
            UserLoginDto userLoginDto = new UserLoginDto()
            {
                Login = textLogin.Text.Trim(),
                Password = textPassword.Text.Trim(),
            };

            _userService.UserLoginValidation(userLoginDto);
          
        }   

        public async void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister userRegisterForm = _provider.GetRequiredService<UserRegister>();
            userRegisterForm.ShowDialog();
        }


    }
}
