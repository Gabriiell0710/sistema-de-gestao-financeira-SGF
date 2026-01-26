namespace SGF
{
    partial class RevenueRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueRegister));
            labelMenu = new Label();
            labelHeader = new Label();
            label1 = new Label();
            txtRegisterRevenue = new TextBox();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            dgvRevenue = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
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
            labelMenu.Size = new Size(238, 33);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "Cadastro Receita";
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
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Sistema de Gestão Financeira";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(134, 166);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 2;
            label1.Text = "Cadastrar Receita";
            // 
            // txtRegisterRevenue
            // 
            txtRegisterRevenue.Location = new Point(167, 210);
            txtRegisterRevenue.Name = "txtRegisterRevenue";
            txtRegisterRevenue.Size = new Size(150, 23);
            txtRegisterRevenue.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(194, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.cadastro_receita_black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(134, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 191);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dgvRevenue
            // 
            dgvRevenue.BackgroundColor = SystemColors.Control;
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Location = new Point(834, 149);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.Size = new Size(286, 351);
            dgvRevenue.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(834, 518);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 50);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Roboto", 15F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1020, 518);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnBack.Image = Properties.Resources.voltar_50x50;
            btnBack.Location = new Point(1163, 523);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(66, 67);
            btnBack.TabIndex = 9;
            btnBack.Text = "Voltar";
            btnBack.TextAlign = ContentAlignment.BottomCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // RegisterRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_padrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvRevenue);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(txtRegisterRevenue);
            Controls.Add(label1);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterRevenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Receita";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label labelHeader;
        private Label label1;
        private TextBox txtRegisterRevenue;
        private Button btnSave;
        private PictureBox pictureBox1;
        private DataGridView dgvRevenue;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBack;
    }
}