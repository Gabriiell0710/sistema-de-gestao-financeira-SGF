using SGF.DTO;
using SGF.Interfaces.IService;
using SGF.Models;
using SGF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            btnCancel.Click += btnCancel_Click;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            UserDto userDto = new UserDto()
            {
                Name = txtName.Text.Trim(),
                Login = txtLogin.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                PassConfirm = txtPassConfirm.Text.Trim()
            };

                var newUser = _userService.UserValidation(userDto);

            if(newUser) this.Close();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtPassConfirm.Text = "";

            this.Close();
        }
    }


}
