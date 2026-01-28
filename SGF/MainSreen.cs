using Microsoft.Extensions.DependencyInjection;
using SGF.Interfaces.IService;
using SGF.Models;
using SGF.Utils;
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
    public partial class MainSreen : Form
    {
        private UserSession _user;
        private readonly IServiceProvider _provider;
        public MainSreen(UserSession user, IServiceProvider provider)
        {
            _user = user;
            _provider = provider;

            InitializeComponent();

            labelUser.Text = $"Usuário: {_user.User.Name}";

            btnRegisterRevenue.Click += btnRegisterRevenue_Click;
        }

        public void btnRegisterRevenue_Click(object sender, EventArgs e)
        {
            var revenueService = _provider.GetRequiredService<IRevenueCategoryService>();

            RevenueRegister revenueRegisterForm = new RevenueRegister(revenueService, _user);

            this.Hide();
            revenueRegisterForm.ShowDialog();
            this.Show();

        }


    }
}
