namespace SGF
{
    partial class MainSreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSreen));
            labelMenu = new Label();
            labelHeader = new Label();
            btnAddRevenue = new Button();
            btnAddExpense = new Button();
            btnRegisterRevenue = new Button();
            btnRegisterExpense = new Button();
            btnReport = new Button();
            btnGraphics = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            labelUser = new Label();
            labelCurrentDate = new Label();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Roboto", 20F, FontStyle.Bold);
            labelMenu.ForeColor = SystemColors.ControlLight;
            labelMenu.Location = new Point(101, 12);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(87, 33);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "Menu";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Font = new Font("Roboto", 20F, FontStyle.Bold);
            labelHeader.Location = new Point(465, 12);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(402, 33);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Sistema de Gestão Financeira";
            // 
            // btnAddRevenue
            // 
            btnAddRevenue.BackColor = Color.White;
            btnAddRevenue.Cursor = Cursors.Hand;
            btnAddRevenue.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnAddRevenue.Image = Properties.Resources.add_receita_75x75;
            btnAddRevenue.ImageAlign = ContentAlignment.TopCenter;
            btnAddRevenue.Location = new Point(47, 133);
            btnAddRevenue.Name = "btnAddRevenue";
            btnAddRevenue.Padding = new Padding(0, 7, 0, 0);
            btnAddRevenue.Size = new Size(118, 120);
            btnAddRevenue.TabIndex = 2;
            btnAddRevenue.Text = "Adicionar\r\nReceita";
            btnAddRevenue.TextAlign = ContentAlignment.BottomCenter;
            btnAddRevenue.UseVisualStyleBackColor = false;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.White;
            btnAddExpense.Cursor = Cursors.Hand;
            btnAddExpense.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnAddExpense.Image = Properties.Resources.add_despesa_75x75;
            btnAddExpense.ImageAlign = ContentAlignment.TopCenter;
            btnAddExpense.Location = new Point(182, 133);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Padding = new Padding(0, 7, 0, 0);
            btnAddExpense.Size = new Size(118, 120);
            btnAddExpense.TabIndex = 3;
            btnAddExpense.Text = "Adicionar\r\nDespesa";
            btnAddExpense.TextAlign = ContentAlignment.BottomCenter;
            btnAddExpense.UseVisualStyleBackColor = false;
            // 
            // btnRegisterRevenue
            // 
            btnRegisterRevenue.BackColor = Color.White;
            btnRegisterRevenue.Cursor = Cursors.Hand;
            btnRegisterRevenue.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnRegisterRevenue.Image = Properties.Resources.cadastro_receita_75x75;
            btnRegisterRevenue.ImageAlign = ContentAlignment.TopCenter;
            btnRegisterRevenue.Location = new Point(47, 271);
            btnRegisterRevenue.Name = "btnRegisterRevenue";
            btnRegisterRevenue.Padding = new Padding(0, 7, 0, 0);
            btnRegisterRevenue.Size = new Size(118, 120);
            btnRegisterRevenue.TabIndex = 4;
            btnRegisterRevenue.Text = "Cadastrar Receita";
            btnRegisterRevenue.TextAlign = ContentAlignment.BottomCenter;
            btnRegisterRevenue.UseVisualStyleBackColor = false;
            // 
            // btnRegisterExpense
            // 
            btnRegisterExpense.BackColor = Color.White;
            btnRegisterExpense.Cursor = Cursors.Hand;
            btnRegisterExpense.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnRegisterExpense.Image = Properties.Resources.cadastro_despesa_75x75;
            btnRegisterExpense.ImageAlign = ContentAlignment.TopCenter;
            btnRegisterExpense.Location = new Point(182, 271);
            btnRegisterExpense.Name = "btnRegisterExpense";
            btnRegisterExpense.Padding = new Padding(0, 7, 0, 0);
            btnRegisterExpense.Size = new Size(118, 120);
            btnRegisterExpense.TabIndex = 5;
            btnRegisterExpense.Text = "Cadastrar Despesa";
            btnRegisterExpense.TextAlign = ContentAlignment.BottomCenter;
            btnRegisterExpense.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.White;
            btnReport.Cursor = Cursors.Hand;
            btnReport.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.emitir_relatorio_75x75;
            btnReport.ImageAlign = ContentAlignment.TopCenter;
            btnReport.Location = new Point(47, 410);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(0, 7, 0, 0);
            btnReport.Size = new Size(118, 120);
            btnReport.TabIndex = 6;
            btnReport.Text = "Emitir \r\nRelatório";
            btnReport.TextAlign = ContentAlignment.BottomCenter;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnGraphics
            // 
            btnGraphics.BackColor = Color.White;
            btnGraphics.Cursor = Cursors.Hand;
            btnGraphics.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnGraphics.Image = Properties.Resources.graficos_75x75;
            btnGraphics.ImageAlign = ContentAlignment.TopCenter;
            btnGraphics.Location = new Point(182, 410);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Padding = new Padding(0, 7, 0, 0);
            btnGraphics.Size = new Size(118, 120);
            btnGraphics.TabIndex = 7;
            btnGraphics.Text = "Gráficos";
            btnGraphics.TextAlign = ContentAlignment.BottomCenter;
            btnGraphics.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.White;
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnHelp.Image = Properties.Resources.ajuda_75x75;
            btnHelp.ImageAlign = ContentAlignment.TopCenter;
            btnHelp.Location = new Point(1005, 502);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(0, 7, 0, 0);
            btnHelp.Size = new Size(90, 88);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "Ajuda";
            btnHelp.TextAlign = ContentAlignment.BottomCenter;
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Roboto", 9F, FontStyle.Bold);
            btnExit.Image = Properties.Resources.sair_50x50;
            btnExit.ImageAlign = ContentAlignment.TopCenter;
            btnExit.Location = new Point(1113, 502);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(0, 7, 0, 0);
            btnExit.Size = new Size(90, 88);
            btnExit.TabIndex = 9;
            btnExit.Text = "Sair";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelUser.Location = new Point(53, 559);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(75, 19);
            labelUser.TabIndex = 10;
            labelUser.Text = "Usuário:";
            // 
            // labelCurrentDate
            // 
            labelCurrentDate.AutoSize = true;
            labelCurrentDate.BackColor = Color.Transparent;
            labelCurrentDate.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelCurrentDate.ForeColor = SystemColors.Control;
            labelCurrentDate.Location = new Point(983, 66);
            labelCurrentDate.Name = "labelCurrentDate";
            labelCurrentDate.Size = new Size(94, 19);
            labelCurrentDate.TabIndex = 11;
            labelCurrentDate.Text = "Data Atual";
            // 
            // MainSreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_mainform;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 602);
            Controls.Add(labelCurrentDate);
            Controls.Add(labelUser);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(btnGraphics);
            Controls.Add(btnReport);
            Controls.Add(btnRegisterExpense);
            Controls.Add(btnRegisterRevenue);
            Controls.Add(btnAddExpense);
            Controls.Add(btnAddRevenue);
            Controls.Add(labelHeader);
            Controls.Add(labelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainSreen";
            Text = "MainSreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label labelHeader;
        private Button btnAddRevenue;
        private Button btnAddExpense;
        private Button btnRegisterRevenue;
        private Button btnRegisterExpense;
        private Button btnReport;
        private Button btnGraphics;
        private Button btnHelp;
        private Button btnExit;
        private Label labelUser;
        private Label labelCurrentDate;
    }
}