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


            LoadRevenues();
            LoadExpenses();
            LoadCompare();
        }

        private async void LoadRevenues()
        {
            var data = await _repository.GetRevenues(_loggedUser.Id);

            chartRevenues.Series.Clear();
            chartRevenues.ChartAreas.Clear();
            chartRevenues.ChartAreas.Add(new ChartArea());

            var series = chartRevenues.Series.Add("Receitas");

            series.ChartType = SeriesChartType.Column;

            foreach(var item in data)
            {
                series.Points.AddXY(item.Month, item.Value);
            }
        }

        private async void LoadExpenses()
        {
            var data = await _repository.GetExpenses(_loggedUser.Id);

            chartExpense.Series.Clear();
            chartExpense.ChartAreas.Clear();
            chartExpense.ChartAreas.Add(new ChartArea());

            var series = chartExpense.Series.Add("Despesas");

            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Month, item.Value);
            }
        }

        private async void LoadCompare()
        {
            var (revenues, expenses) = await _repository.GetCompare(_loggedUser.Id);

            chartComparative.Series.Clear();
            chartComparative.ChartAreas.Clear();
            chartComparative.ChartAreas.Add(new ChartArea());

            var s1 = chartComparative.Series.Add("Receitas");
            var s2 = chartComparative.Series.Add("Despesas");

            s1.ChartType = SeriesChartType.Column;
            s2.ChartType = SeriesChartType.Column;

            foreach (var item in revenues)
                s1.Points.AddXY(item.Month, item.Value);

            foreach (var item in expenses)
                s2.Points.AddXY(item.Month, item.Value);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
