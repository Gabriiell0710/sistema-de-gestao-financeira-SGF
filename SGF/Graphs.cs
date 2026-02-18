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
using System.Windows.Forms.DataVisualization.Charting;

namespace SGF
{
    public partial class Graphs : Form
    {
        private readonly IGraphsRepository _repository;
        private UserModel _loggedUser;

        public Graphs(IGraphsRepository repository, UserSession user)
        {
            _repository = repository;
            _loggedUser = user.User;

            InitializeComponent();

            Load += Graphs_Load;
            btnBack.Click += btnBack_Click;
        }


        private async void Graphs_Load(object sender, EventArgs e)
        {

            await LoadGraphs();
            LoadRevenues();
            LoadExpenses();
            LoadCompare();
        }

        private async void LoadRevenues()
        {
            var year = dtpFilter.Value.Year;
            var month = dtpFilter.Value.Month;
            var data = await _repository.GetRevenues(_loggedUser.Id, year, month);

            chartRevenues.Series.Clear();
            chartRevenues.ChartAreas.Clear();
            chartRevenues.Legends.Clear();

            chartRevenues.Legends.Add(new Legend());
            chartRevenues.ChartAreas.Add(new ChartArea("Area1"));
            chartRevenues.BackColor = Color.WhiteSmoke;
            chartRevenues.ChartAreas["Area1"].BackColor = Color.White;
            chartRevenues.ChartAreas["Area1"].AxisX.MajorGrid.Enabled = false;
            chartRevenues.ChartAreas["Area1"].AxisY.MajorGrid.LineColor = Color.LightGray;

            var series = chartRevenues.Series.Add("Receitas");

            series.ChartType = SeriesChartType.Column;
            series.Color = Color.SeaGreen;
            series.IsVisibleInLegend = true;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Month, item.Value);
            }
        }


        private async void LoadExpenses()
        {
            var year = dtpFilter.Value.Year;
            var month = dtpFilter.Value.Month;

            var data = await _repository.GetExpenses(_loggedUser.Id, year, month);

            chartExpense.Series.Clear();
            chartExpense.Legends.Clear();
            chartExpense.ChartAreas.Clear();

            chartExpense.Legends.Add(new Legend());
            chartExpense.ChartAreas.Add(new ChartArea("Area1"));
            chartExpense.BackColor = Color.WhiteSmoke;
            chartExpense.ChartAreas["Area1"].BackColor = Color.White;
            chartExpense.ChartAreas["Area1"].AxisX.MajorGrid.Enabled = false;
            chartExpense.ChartAreas["Area1"].AxisY.MajorGrid.LineColor = Color.LightGray;

            var series = chartExpense.Series.Add("Despesas");

            series.ChartType = SeriesChartType.Column;
            series.IsVisibleInLegend = true;
            series.Color = Color.IndianRed;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Month, item.Value);
            }
        }

        private async void LoadCompare()
        {
            var year = dtpFilter.Value.Year;
            var month = dtpFilter.Value.Month;

            var (revenues, expenses) = await _repository.GetCompare(_loggedUser.Id, year, month);

            chartComparative.Series.Clear();
            chartComparative.ChartAreas.Clear();
            chartComparative.Legends.Clear();

            chartComparative.Legends.Add(new Legend("MainLegend"));
            chartComparative.ChartAreas.Add(new ChartArea("Area1"));
            chartComparative.BackColor = Color.WhiteSmoke;
            chartComparative.ChartAreas["Area1"].BackColor = Color.White;
            chartComparative.ChartAreas["Area1"].AxisX.MajorGrid.Enabled = false;
            chartComparative.ChartAreas["Area1"].AxisY.MajorGrid.LineColor = Color.LightGray;


            var s1 = chartComparative.Series.Add("Receitas");
            s1.ChartType = SeriesChartType.Column;
            s1.Legend = "MainLegend";
            s1.IsVisibleInLegend = true;
            s1.Color = Color.SeaGreen;
            foreach (var item in revenues)
                s1.Points.AddXY(item.Month, item.Value);


            var s2 = chartComparative.Series.Add("Despesas");
            s2.ChartType = SeriesChartType.Column;
            s2.Legend = "MainLegend";
            s2.IsVisibleInLegend = true;
            s2.Color = Color.IndianRed;
            foreach (var item in expenses)
                s2.Points.AddXY(item.Month, item.Value);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            await LoadGraphs();
           // MessageBox.Show("Atualizou!");
        }

        private async Task LoadGraphs()
        {
            int year = dtpFilter.Value.Year;
            int month = dtpFilter.Value.Month;

            var revenues = await _repository.GetRevenues(_loggedUser.Id, year, month);
            var expenses = await _repository.GetExpenses(_loggedUser.Id, year, month);

            LoadRevenues();
            LoadExpenses();
            LoadCompare();
        }

       
    }
}
