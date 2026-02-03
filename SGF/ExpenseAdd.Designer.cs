namespace SGF
{
    partial class ExpenseAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseAdd));
            labelMenu = new Label();
            labelHeader = new Label();
            labelRevenueAdd = new Label();
            labelCategory = new Label();
            labelValue = new Label();
            labelDate = new Label();
            labelDescription = new Label();
            boxExpenseCategory = new ComboBox();
            numValue = new NumericUpDown();
            dtDate = new DateTimePicker();
            txtDescription = new TextBox();
            btnSalvar = new Button();
            dgvExpenses = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
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
            labelMenu.Size = new Size(233, 33);
            labelMenu.TabIndex = 1;
            labelMenu.Text = "Entrada Despesa";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Font = new Font("Roboto", 20F, FontStyle.Bold);
            labelHeader.Location = new Point(436, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(402, 33);
            labelHeader.TabIndex = 2;
            labelHeader.Text = "Sistema de Gestão Financeira";
            // 
            // labelRevenueAdd
            // 
            labelRevenueAdd.AutoSize = true;
            labelRevenueAdd.BackColor = Color.Transparent;
            labelRevenueAdd.Font = new Font("Roboto", 18F, FontStyle.Bold);
            labelRevenueAdd.Location = new Point(206, 167);
            labelRevenueAdd.Name = "labelRevenueAdd";
            labelRevenueAdd.Size = new Size(231, 29);
            labelRevenueAdd.TabIndex = 3;
            labelRevenueAdd.Text = "Adicionar Despesa";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelCategory.ForeColor = SystemColors.Control;
            labelCategory.Location = new Point(134, 229);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(86, 19);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Categoria";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.BackColor = Color.Transparent;
            labelValue.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelValue.ForeColor = SystemColors.Control;
            labelValue.Location = new Point(159, 275);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(51, 19);
            labelValue.TabIndex = 5;
            labelValue.Text = "Valor";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelDate.ForeColor = SystemColors.Control;
            labelDate.Location = new Point(159, 312);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(47, 19);
            labelDate.TabIndex = 6;
            labelDate.Text = "Data";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = Color.Transparent;
            labelDescription.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelDescription.ForeColor = SystemColors.Control;
            labelDescription.Location = new Point(118, 360);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(88, 19);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Descrição";
            // 
            // boxExpenseCategory
            // 
            boxExpenseCategory.Font = new Font("Roboto", 9F);
            boxExpenseCategory.FormattingEnabled = true;
            boxExpenseCategory.Location = new Point(226, 229);
            boxExpenseCategory.Name = "boxExpenseCategory";
            boxExpenseCategory.Size = new Size(121, 22);
            boxExpenseCategory.TabIndex = 8;
            // 
            // numValue
            // 
            numValue.Font = new Font("Roboto", 9F);
            numValue.Location = new Point(226, 271);
            numValue.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numValue.Name = "numValue";
            numValue.Size = new Size(120, 22);
            numValue.TabIndex = 9;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Roboto", 9F);
            dtDate.Location = new Point(226, 312);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 22);
            dtDate.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(226, 351);
            txtDescription.MaximumSize = new Size(500, 200);
            txtDescription.MinimumSize = new Size(200, 50);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 50);
            txtDescription.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(326, 432);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 50);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dgvExpenses
            // 
            dgvExpenses.BackgroundColor = SystemColors.Control;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(834, 149);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.Size = new Size(286, 351);
            dgvExpenses.TabIndex = 13;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Orange;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(834, 518);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 50);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1020, 518);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 50);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnBack.Image = Properties.Resources.voltar_50x50;
            btnBack.Location = new Point(1163, 523);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(66, 67);
            btnBack.TabIndex = 16;
            btnBack.Text = "Voltar";
            btnBack.TextAlign = ContentAlignment.BottomCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ExpenseAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_padrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvExpenses);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescription);
            Controls.Add(dtDate);
            Controls.Add(numValue);
            Controls.Add(boxExpenseCategory);
            Controls.Add(labelDescription);
            Controls.Add(labelDate);
            Controls.Add(labelValue);
            Controls.Add(labelCategory);
            Controls.Add(labelRevenueAdd);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Cursor = Cursors.PanWest;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ExpenseAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada Despesa";
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label labelHeader;
        private Label labelRevenueAdd;
        private Label labelCategory;
        private Label labelValue;
        private Label labelDate;
        private Label labelDescription;
        private ComboBox boxExpenseCategory;
        private NumericUpDown numValue;
        private DateTimePicker dtDate;
        private TextBox txtDescription;
        private Button btnSalvar;
        private DataGridView dgvExpenses;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBack;
    }
}