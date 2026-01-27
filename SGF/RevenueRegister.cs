using SGF.DTO;
using SGF.Interfaces.IService;
using SGF.Models;
using SGF.Services;
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
    public partial class RevenueRegister : Form
    {
        private readonly IRevenueCategoryService _service;
        private UserModel _loggedUser;
        public RevenueRegister(IRevenueCategoryService service, UserSession userSession)
        {
            _service = service;
            _loggedUser = userSession.User;
            InitializeComponent();

            Load += RevenueCategori_Load;
            btnSave.Click += btnSave_Click;
            
        }
        
        private async void RevenueCategori_Load(object sender, EventArgs e)
        {
            GridLoad();
        }
        
        private async void GridLoad()
        {
            dgvRevenue.DataSource = null;
            dgvRevenue.DataSource = await _service.ListByUser(_loggedUser.Id);

            dgvRevenue.Columns["Id"].Visible = false;
            dgvRevenue.Columns["UserId"].Visible = false;
            dgvRevenue.Columns["User"].Visible = false;
            dgvRevenue.Columns["Name"].HeaderText = "Receitas";
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            RevenueCategoryDto revenueCatDto = new RevenueCategoryDto()
            {
                Name = txtRegisterRevenue.Text.Trim(),
                UserId = _loggedUser.Id,
            };

            await _service.RevenueCategoryValidation(revenueCatDto);

             GridLoad();
        }
    }
}
