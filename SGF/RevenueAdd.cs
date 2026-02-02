using SGF.DTO;
using SGF.Interfaces.IService;
using SGF.Models;
using SGF.Utils;

namespace SGF
{
    public partial class RevenueAdd : Form
    {
        private readonly IRevenueService _service;
        private readonly IRevenueCategoryService _catService;
        private UserModel _loggedUser;
        public RevenueAdd(IRevenueService service, IRevenueCategoryService catService, UserSession userSession)
        {
            _service = service;
            _catService = catService;
            _loggedUser = userSession.User;

            InitializeComponent();

            Load += RevenueAdd_Load;

            btnSalvar.Click += BtnSave_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnBack.Click += BtnBack_Click;
        }

        private async void RevenueAdd_Load(object sender, EventArgs e)
        {
            GridLoad();

            boxRevenueCategory.DataSource =
                _catService.ListByUser(_loggedUser.Id);
            boxRevenueCategory.DisplayMember = "Name";
            boxRevenueCategory.ValueMember = "Id";
        }

        private async void GridLoad()
        {
            dgvRevenues.DataSource = null;
            dgvRevenues.DataSource = _catService.ListByUser(_loggedUser.Id);
            dgvRevenues.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvRevenues.Columns["Id"].Visible = false;
            //dgvRevenues.Columns["RevenueCategoryId"].Visible = false;
            //dgvRevenues.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           // dgvRevenues.Columns["Description"].HeaderText = "Receitas".ToUpper();
            dgvRevenues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            RevenueDto revenueDto = new RevenueDto
            {
                Description = txtDescription.Text.Trim(),
                Value = numValue.Value,
                Date = dtDate.Value,
                RevenueCategoryId = (int)boxRevenueCategory.SelectedValue
            };

            await _service.RevenueValidation(revenueDto);
            GridLoad();
        }
    
        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRevenues.CurrentRow == null) return;

            var revenue = (RevenueModel)dgvRevenues.CurrentRow.DataBoundItem;
            txtDescription.Text = revenue.Description;
            numValue.Value = revenue.Value;
            dtDate.Value = revenue.Date;
            boxRevenueCategory.ValueMember = revenue.RevenueCategoryId.ToString();
             _service.IdRevenueSelected(revenue.Id);
        }
    
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRevenues.CurrentRow == null) return;

            var revenue = (RevenueModel)dgvRevenues.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Deseja Excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _service.Delete(revenue.Id);
                GridLoad();
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
