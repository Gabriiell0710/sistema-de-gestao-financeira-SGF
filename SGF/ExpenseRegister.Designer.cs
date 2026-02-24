namespace SGF
{
    partial class ExpenseRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseRegister));
            labelMenu = new Label();
            labelHeader = new Label();
            labelExpense = new Label();
            txtRegisterExpense = new TextBox();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            dgvExpense = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
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
            labelMenu.TabIndex = 1;
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
            labelHeader.TabIndex = 2;
            labelHeader.Text = "Sistema de Gestão Financeira";
            // 
            // labelExpense
            // 
            labelExpense.AutoSize = true;
            labelExpense.BackColor = Color.Transparent;
            labelExpense.Font = new Font("Roboto", 18F, FontStyle.Bold);
            labelExpense.ForeColor = SystemColors.ControlText;
            labelExpense.Location = new Point(134, 166);
            labelExpense.Name = "labelExpense";
            labelExpense.Size = new Size(233, 29);
            labelExpense.TabIndex = 3;
            labelExpense.Text = "Cadastrar Despesa";
            // 
            // txtRegisterExpense
            // 
            txtRegisterExpense.Location = new Point(167, 210);
            txtRegisterExpense.Name = "txtRegisterExpense";
            txtRegisterExpense.Size = new Size(150, 23);
            txtRegisterExpense.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(194, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.cadastro_despesa_black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(134, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 191);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dgvExpense
            // 
            dgvExpense.BackgroundColor = SystemColors.Control;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Location = new Point(834, 149);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.Size = new Size(286, 351);
            dgvExpense.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(834, 518);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 50);
            btnEdit.TabIndex = 8;
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
            btnDelete.TabIndex = 9;
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
            btnBack.TabIndex = 10;
            btnBack.Text = "     Voltar";
            btnBack.TextAlign = ContentAlignment.BottomCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ExpenseRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_padrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvExpense);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(txtRegisterExpense);
            Controls.Add(labelExpense);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ExpenseRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Despesa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label labelHeader;
        private Label labelExpense;
        private TextBox txtRegisterExpense;
        private Button btnSave;
        private PictureBox pictureBox1;
        private DataGridView dgvExpense;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBack;
    }
}