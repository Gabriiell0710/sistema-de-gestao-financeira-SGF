namespace SGF
{
    partial class RevenueAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueAdd));
            labelMenu = new Label();
            labelHeader = new Label();
            labelRevenueAdd = new Label();
            labelCategory = new Label();
            labelValue = new Label();
            labelDate = new Label();
            labelDescription = new Label();
            boxRevenueCategory = new ComboBox();
            numValue = new NumericUpDown();
            dtDate = new DateTimePicker();
            txtDescription = new TextBox();
            btnSalvar = new Button();
            dgvRevenues = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenues).BeginInit();
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
            labelMenu.Size = new Size(219, 33);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "Entrada Receita";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Font = new Font("Roboto", 20F, FontStyle.Bold);
            labelHeader.Location = new Point(436, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(402, 33);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Sistema de Gestão Financeira";
            // 
            // labelRevenueAdd
            // 
            labelRevenueAdd.AutoSize = true;
            labelRevenueAdd.BackColor = Color.Transparent;
            labelRevenueAdd.Font = new Font("Roboto", 18F, FontStyle.Bold);
            labelRevenueAdd.Location = new Point(206, 167);
            labelRevenueAdd.Name = "labelRevenueAdd";
            labelRevenueAdd.Size = new Size(220, 29);
            labelRevenueAdd.TabIndex = 2;
            labelRevenueAdd.Text = "Adicionar Receita";
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
            labelCategory.TabIndex = 3;
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
            labelValue.TabIndex = 4;
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
            labelDate.TabIndex = 5;
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
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Descrição";
            // 
            // boxRevenueCategory
            // 
            boxRevenueCategory.Font = new Font("Roboto", 9F);
            boxRevenueCategory.FormattingEnabled = true;
            boxRevenueCategory.Location = new Point(226, 229);
            boxRevenueCategory.Name = "boxRevenueCategory";
            boxRevenueCategory.Size = new Size(121, 22);
            boxRevenueCategory.TabIndex = 7;
            // 
            // numValue
            // 
            numValue.Font = new Font("Roboto", 9F);
            numValue.Location = new Point(226, 271);
            numValue.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numValue.Name = "numValue";
            numValue.Size = new Size(120, 22);
            numValue.TabIndex = 8;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Roboto", 9F);
            dtDate.Location = new Point(226, 312);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 22);
            dtDate.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(226, 351);
            txtDescription.MaximumSize = new Size(500, 200);
            txtDescription.MinimumSize = new Size(200, 50);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 50);
            txtDescription.TabIndex = 10;
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
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dgvRevenues
            // 
            dgvRevenues.BackgroundColor = SystemColors.Control;
            dgvRevenues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenues.Location = new Point(834, 149);
            dgvRevenues.Name = "dgvRevenues";
            dgvRevenues.Size = new Size(286, 351);
            dgvRevenues.TabIndex = 12;
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
            btnEdit.TabIndex = 13;
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
            btnDelete.TabIndex = 14;
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
            btnBack.TabIndex = 15;
            btnBack.Text = "Voltar";
            btnBack.TextAlign = ContentAlignment.BottomCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // RevenueAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_padrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvRevenues);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescription);
            Controls.Add(dtDate);
            Controls.Add(numValue);
            Controls.Add(boxRevenueCategory);
            Controls.Add(labelDescription);
            Controls.Add(labelDate);
            Controls.Add(labelValue);
            Controls.Add(labelCategory);
            Controls.Add(labelRevenueAdd);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RevenueAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RevenueAdd";
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenues).EndInit();
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
        private ComboBox boxRevenueCategory;
        private NumericUpDown numValue;
        private DateTimePicker dtDate;
        private TextBox txtDescription;
        private Button btnSalvar;
        private DataGridView dgvRevenues;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBack;
    }
}