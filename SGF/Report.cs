using QuestPDF.Fluent;
using SGF.DTO;
using SGF.Interfaces.IRepository;
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
    public partial class Report : Form
    {
        private readonly IExtractReportRepository _repository;
        private UserModel _loggedUser;

        public Report( IExtractReportRepository repository, UserSession user)
        {
            _repository = repository;
            _loggedUser = user.User;

            InitializeComponent();

            btnGenerate.Click += BtnGenerate_Click;
            btnPdfExport.Click += BtnPdfExport_Click;
            btnBack.Click += BtnBack_Click;

        }


        private async void BtnGenerate_Click(object sender, EventArgs e)
        {
            var list = await _repository.GetExtract(
                _loggedUser.Id,
                dtStart.Value.Date,
                dtEnd.Value.Date
                );
            dgvReport.DataSource = list;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GridUpdate(list);
        }

        private async void GridUpdate(List<ExtractReportDto> list)
        {

            dgvReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvReport.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReport.Columns["Type"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReport.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReport.Columns["Category"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReport.Columns["Value"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReport.Columns["Date"].HeaderText = "Data".ToUpper();
            dgvReport.Columns["Type"].HeaderText = "Tipo".ToUpper();
            dgvReport.Columns["Description"].HeaderText = "Descrição".ToUpper();
            dgvReport.Columns["Category"].HeaderText = "Categoria".ToUpper();
            dgvReport.Columns["Value"].HeaderText = "Valor".ToUpper();

            var totalRevenue = list
                .Where(x => x.Type == "Receita")
                .Sum(x => x.Value);

            var totalExpense = list
                .Where(x => x.Type == "Despesa")
                .Sum(x => Math.Abs(x.Value));

            var balance = totalRevenue - totalExpense;

            lbRevenue.Text = $"Receita: {totalRevenue}";
            lbExpense.Text = $"Despesa: {totalExpense}";
            lbBalance.Text = $"Saldo: {balance}";
        }
        
        private async void BtnPdfExport_Click(Object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Gere o relatório antes de exportar.");
                return;
            }

            using var save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "ExtratoFinanceiro.pdf";

            if (save.ShowDialog() != DialogResult.OK)
                return;

            var data = (List<ExtractReportDto>)dgvReport.DataSource;

            var document = new PdfExtractDocument(
                data,
                _loggedUser,
                dtStart.Value.Date,
                dtEnd.Value.Date
                );

            document.GeneratePdf(save.FileName);

            MessageBox.Show("PDF gerado com sucesso.");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
