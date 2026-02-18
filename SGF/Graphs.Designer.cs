namespace SGF
{
    partial class Graphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
            labelMenu = new Label();
            labelHeader = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chartRevenues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage2 = new TabPage();
            chartExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage3 = new TabPage();
            chartComparative = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dtpFilter = new DateTimePicker();
            btnBack = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenues).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpense).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartComparative).BeginInit();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Roboto", 20F, FontStyle.Bold);
            labelMenu.ForeColor = SystemColors.Control;
            labelMenu.Location = new Point(26, 21);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(252, 33);
            labelMenu.TabIndex = 2;
            labelMenu.Text = "Cadastro Despesa";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Font = new Font("Roboto", 20F, FontStyle.Bold);
            labelHeader.ForeColor = SystemColors.ControlText;
            labelHeader.Location = new Point(436, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(402, 33);
            labelHeader.TabIndex = 3;
            labelHeader.Text = "Sistema de Gestão Financeira";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1243, 545);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chartRevenues);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1235, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Receita";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartRevenues
            // 
            chartRevenues.Dock = DockStyle.Fill;
            chartRevenues.Location = new Point(3, 3);
            chartRevenues.Name = "chartRevenues";
            series1.Color = Color.Green;
            series1.Name = "Series1";
            chartRevenues.Series.Add(series1);
            chartRevenues.Size = new Size(1229, 511);
            chartRevenues.TabIndex = 0;
            chartRevenues.Text = "chart1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chartExpense);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1235, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Despesa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartExpense
            // 
            chartExpense.Dock = DockStyle.Fill;
            chartExpense.Location = new Point(3, 3);
            chartExpense.Name = "chartExpense";
            series2.Name = "Series1";
            chartExpense.Series.Add(series2);
            chartExpense.Size = new Size(1229, 511);
            chartExpense.TabIndex = 1;
            chartExpense.Text = "chart1";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chartComparative);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1235, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Comparativo";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartComparative
            // 
            chartComparative.Dock = DockStyle.Fill;
            chartComparative.Location = new Point(3, 3);
            chartComparative.Name = "chartComparative";
            series3.Name = "Series1";
            chartComparative.Series.Add(series3);
            chartComparative.Size = new Size(1229, 511);
            chartComparative.TabIndex = 2;
            chartComparative.Text = "chart1";
            // 
            // dtpFilter
            // 
            dtpFilter.CalendarFont = new Font("Roboto", 10F);
            dtpFilter.CalendarMonthBackground = SystemColors.MenuHighlight;
            dtpFilter.CustomFormat = "MM/yyyy";
            dtpFilter.Font = new Font("Roboto", 10F);
            dtpFilter.Format = DateTimePickerFormat.Custom;
            dtpFilter.Location = new Point(1110, 32);
            dtpFilter.Name = "dtpFilter";
            dtpFilter.ShowUpDown = true;
            dtpFilter.Size = new Size(79, 24);
            dtpFilter.TabIndex = 12;
            dtpFilter.ValueChanged += this.dtpFilter_ValueChanged;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnBack.Image = Properties.Resources.voltar_50x50;
            btnBack.Location = new Point(1163, 523);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(66, 67);
            btnBack.TabIndex = 11;
            btnBack.Text = "     ";
            btnBack.TextAlign = ContentAlignment.BottomCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GrayText;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1029, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 13;
            label1.Text = "Período";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_padrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(label1);
            Controls.Add(dtpFilter);
            Controls.Add(btnBack);
            Controls.Add(tabControl1);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Graphs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gráficos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRevenues).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartExpense).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartComparative).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label labelHeader;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComparative;
        private Button btnBack;
        private DateTimePicker dtpFilter;
        private Label label1;
    }
}