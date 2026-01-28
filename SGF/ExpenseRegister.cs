using SGF.DTO;
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
    public partial class ExpenseRegister : Form
    {
        private readonly IExpenseCategoryService _service;
        private UserModel _loggedUser;
        public ExpenseRegister(IExpenseCategoryService service, UserSession userSession)
        {
            _service = service;
            _loggedUser = userSession.User;

            InitializeComponent();
            Load += ExpenseCategory_Load;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;
        }

        private async void ExpenseCategory_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        private async void GridLoad()
        {
            dgvExpense.DataSource = null;
            dgvExpense.DataSource = await _service.ListByUser(_loggedUser.Id);
            dgvExpense.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvExpense.Columns["Id"].Visible = false;
            dgvExpense.Columns["UserId"].Visible = false;
            dgvExpense.Columns["User"].Visible = false;
            dgvExpense.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExpense.Columns["Name"].HeaderText = "Despesas".ToUpper();
            dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ExpenseCategoryDto expenseDto = new ExpenseCategoryDto
            {
                Name = txtRegisterExpense.Text.Trim(),
                UserId = _loggedUser.Id,
            };

            await _service.ExpenseCategoryValidation(expenseDto);
            txtRegisterExpense.Text = null;
            GridLoad();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow == null) return;

            var expense = (ExpenseCategoryModel)dgvExpense.CurrentRow.DataBoundItem;
            txtRegisterExpense.Text = expense.Name;
            _service.IdExpenseSelected(expense.Id);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow == null) return;

            var expense = (ExpenseCategoryModel)dgvExpense.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Deseja Excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _service.Delete(expense.Id);
                GridLoad();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
