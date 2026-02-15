using Microsoft.Extensions.DependencyInjection;
using SGF.Interfaces.IRepository;
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

            btnRegisterRevenue.Click += BtnRegisterRevenue_Click;
            btnRegisterExpense.Click += BtnRegisterExpense_Click;
            btnAddRevenue.Click += BtnAddRevenue_Click;
            btnAddExpense.Click += BtnAddExpense_Click;
            btnReport.Click += BtnReport_Click;
            btnGraphics.Click += BtnGraphs_Click;
        }

        private void BtnRegisterRevenue_Click(object sender, EventArgs e)
        {
            var revenueService = _provider.GetRequiredService<IRevenueCategoryService>();

            RevenueRegister revenueRegisterForm = new RevenueRegister(revenueService, _user);

            this.Hide();
            revenueRegisterForm.ShowDialog();
            this.Show();

        }

        private void BtnRegisterExpense_Click(object sender, EventArgs e)
        {
            var expenseService = _provider.GetRequiredService<IExpenseCategoryService>();

            ExpenseRegister expenseRegisterForm = new ExpenseRegister(expenseService, _user);

            this.Hide();
            expenseRegisterForm.ShowDialog();
            this.Show();
        }

        private void BtnAddRevenue_Click(object sender, EventArgs e)
        {
            var revenueService = _provider.GetRequiredService<RevenueAdd>();
           
            this.Hide();
            revenueService.ShowDialog();
            this.Show();

        }

        private void BtnAddExpense_Click(Object sender, EventArgs e)
        {
            var expenseService = _provider.GetRequiredService<ExpenseAdd>();

            this.Hide();
            expenseService.ShowDialog();
            this.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            var reportService = _provider.GetRequiredService<Report>();

            this.Hide();
            reportService.ShowDialog();
            this.Show();
        }

        private void BtnGraphs_Click(object sender, EventArgs e)
        {
            var graphsService = _provider.GetRequiredService<Graphs>();

            this.Hide();
            graphsService.ShowDialog();
            this.Show();
        }

    }
}
