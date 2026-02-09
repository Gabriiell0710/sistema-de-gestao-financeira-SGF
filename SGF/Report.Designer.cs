namespace SGF
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            labelMenu = new Label();
            labelHeader = new Label();
            dgvReport = new DataGridView();
            labelTitle = new Label();
            labelStart = new Label();
            labelEnd = new Label();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            btnGenerate = new Button();
            lbRevenue = new Label();
            lbExpense = new Label();
            lbBalance = new Label();
            btnPdfExport = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
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
            labelMenu.Size = new Size(217, 33);
            labelMenu.TabIndex = 2;
            labelMenu.Text = "Emitir Relatório";
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
            // dgvReport
            // 
            dgvReport.BackgroundColor = SystemColors.Control;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(684, 145);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(438, 268);
            dgvReport.TabIndex = 8;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Roboto", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(206, 167);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(234, 29);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Selecionar Período";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.BackColor = Color.Transparent;
            labelStart.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelStart.ForeColor = SystemColors.Control;
            labelStart.Location = new Point(206, 218);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(101, 19);
            labelStart.TabIndex = 10;
            labelStart.Text = "Data Inicial";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.BackColor = Color.Transparent;
            labelEnd.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelEnd.ForeColor = SystemColors.Control;
            labelEnd.Location = new Point(215, 259);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(92, 19);
            labelEnd.TabIndex = 11;
            labelEnd.Text = "Data Final";
            // 
            // dtStart
            // 
            dtStart.Location = new Point(313, 217);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(127, 23);
            dtStart.TabIndex = 12;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(313, 257);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(127, 23);
            dtEnd.TabIndex = 13;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.DarkGreen;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnGenerate.ForeColor = SystemColors.Control;
            btnGenerate.Location = new Point(249, 309);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(176, 50);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = "Gerar Relatório";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // lbRevenue
            // 
            lbRevenue.Font = new Font("Roboto", 12F);
            lbRevenue.ForeColor = Color.DarkGreen;
            lbRevenue.Location = new Point(683, 415);
            lbRevenue.Name = "lbRevenue";
            lbRevenue.Size = new Size(154, 24);
            lbRevenue.TabIndex = 15;
            lbRevenue.Text = "Receita";
            lbRevenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbExpense
            // 
            lbExpense.Font = new Font("Roboto", 12F);
            lbExpense.ForeColor = Color.DarkRed;
            lbExpense.Location = new Point(841, 415);
            lbExpense.Name = "lbExpense";
            lbExpense.Size = new Size(145, 24);
            lbExpense.TabIndex = 16;
            lbExpense.Text = "Despesa";
            lbExpense.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbBalance
            // 
            lbBalance.Font = new Font("Roboto", 12F);
            lbBalance.ForeColor = Color.DarkGoldenrod;
            lbBalance.Location = new Point(990, 415);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(131, 24);
            lbBalance.TabIndex = 17;
            lbBalance.Text = "Saldo";
            lbBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPdfExport
            // 
            btnPdfExport.BackColor = Color.DarkRed;
            btnPdfExport.Cursor = Cursors.Hand;
            btnPdfExport.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnPdfExport.ForeColor = SystemColors.Control;
            btnPdfExport.Location = new Point(813, 485);
            btnPdfExport.Name = "btnPdfExport";
            btnPdfExport.Size = new Size(197, 50);
            btnPdfExport.TabIndex = 18;
            btnPdfExport.Text = "Exportar em PDF";
            btnPdfExport.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnBack.Image = Properties.Resources.voltar_50x50;
            btnBack.Location = new Point(1163, 523);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(66, 67);
            btnBack.TabIndex = 19;
            btnBack.Text = "Voltar";
            btnBack.TextAlign = ContentAlignment.BottomCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_padrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(btnBack);
            Controls.Add(btnPdfExport);
            Controls.Add(lbBalance);
            Controls.Add(lbExpense);
            Controls.Add(lbRevenue);
            Controls.Add(btnGenerate);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(labelTitle);
            Controls.Add(dgvReport);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emitir Relatório";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label labelHeader;
        private DataGridView dgvReport;
        private Label labelTitle;
        private Label labelStart;
        private Label labelEnd;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Button btnGenerate;
        private Label lbRevenue;
        private Label lbExpense;
        private Label lbBalance;
        private Button btnPdfExport;
        private Button btnBack;
    }
}