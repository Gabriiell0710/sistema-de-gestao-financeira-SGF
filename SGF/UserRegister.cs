using SGF.Interfaces.IService;
using SGF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF
{
    public partial class UserRegister : Form
    {
        private readonly IUserService _userService;

        public UserRegister(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;

            btnSave.Click += btnSave_Click;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string passConfirm = txtPassConfirm.Text.Trim();


            //Verification
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(passConfirm))
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            if (password != passConfirm)
            {
                MessageBox.Show("As senhas devem ser iguais!");
            }

            if (await _userService.LoginExists(login))
            {
                MessageBox.Show("O nome de usuário já existe!");
            }

            //Add New User
            UserModel newUser = new UserModel
            {
                Name = name,
                Login = login,
                Password = password
            };

            _userService.AddUser(newUser);

            MessageBox.Show("Usuário criado com sucesso!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
