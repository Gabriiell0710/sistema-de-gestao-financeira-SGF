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
    public partial class ExpenseAdd : Form
    {

        private readonly IExpenseService _service;
        private readonly IExpenseCategoryService _catService;
        private UserModel _loggedUser;
        public ExpenseAdd( IExpenseService service, IExpenseCategoryService catService, UserSession session)
        {
            _service = service;
            _catService = catService;
            _loggedUser = session.User;

            InitializeComponent();

            Load += ExpenseAdd_Load;

            btnSalvar.Click += BtnSave_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnBack.Click += BtnBack_Click;

        }

        private async void ExpenseAdd_Load(object sender, EventArgs e)
        {
            GridLoad();

            boxExpenseCategory.DataSource =
                await _catService.ListByUser(_loggedUser.Id);
            boxExpenseCategory.DisplayMember = "Name";
            boxExpenseCategory.ValueMember = "Id";
        }

        private async void GridLoad()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = await _service.ListByUser(_loggedUser.Id);
            dgvExpenses.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvExpenses.Columns["Id"].Visible = false;
            dgvExpenses.Columns["ExpenseCategoryId"].Visible = false;
            dgvExpenses.Columns["ExpenseCategory"].Visible = false;
            dgvExpenses.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExpenses.Columns["Description"].HeaderText = "Descrição".ToUpper(); 
            dgvExpenses.Columns["Value"].HeaderText = "Valor".ToUpper();
            dgvExpenses.Columns["Date"].HeaderText = "Data".ToUpper();
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void BtnSave_Click(object sender, EventArgs e)

        {
            ExpenseDto expenseDto = new ExpenseDto
            {
                Description = txtDescription.Text.Trim(),
                Value = numValue.Value,
                Date = dtDate.Value,
                ExpenseCategoryId = (int)boxExpenseCategory.SelectedValue
            };

            await _service.ExpenseValidation(expenseDto);
            GridLoad();
        }
    
        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow == null) return;

            var expense = (ExpenseModel)dgvExpenses.CurrentRow.DataBoundItem;
            txtDescription.Text = expense.Description;
            numValue.Value = expense.Value;
            dtDate.Value = expense.Date;
            boxExpenseCategory.SelectedValue = expense.ExpenseCategoryId;
            _service.IdExpenseSelected(expense.Id);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow == null) return;

            var expense = (ExpenseModel)dgvExpenses.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Deseja Excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _service.Delete(expense.Id);
                GridLoad();
            }
        }
    
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
