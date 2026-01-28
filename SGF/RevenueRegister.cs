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
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;
            
        }
        
        private async void RevenueCategori_Load(object sender, EventArgs e)
        {
            GridLoad();
        }
        
        private async void GridLoad()
        {
            dgvRevenue.DataSource = null;
            dgvRevenue.DataSource = await _service.ListByUser(_loggedUser.Id);
            dgvRevenue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

            dgvRevenue.Columns["Id"].Visible = false;
            dgvRevenue.Columns["UserId"].Visible = false;
            dgvRevenue.Columns["User"].Visible = false;
            dgvRevenue.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            dgvRevenue.Columns["Name"].HeaderText = "Receitas".ToUpper();
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
            txtRegisterRevenue.Text = null;
             GridLoad();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvRevenue.CurrentRow == null) return;

            var revenue = (RevenueCategoryModel) dgvRevenue.CurrentRow.DataBoundItem;
            txtRegisterRevenue.Text = revenue.Name;
              _service.IdRevenueSelected(revenue.Id);

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRevenue.CurrentRow == null) return;

            var revenue = (RevenueCategoryModel)dgvRevenue.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Deseja Excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _service.Delete(revenue.Id);
                GridLoad();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
