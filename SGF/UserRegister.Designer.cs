namespace SGF
{
    partial class UserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            labelTitle = new Label();
            imgRegister = new PictureBox();
            labelName = new Label();
            txtName = new TextBox();
            labelLogin = new Label();
            labelPass = new Label();
            labelPassConfirm = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            txtPassConfirm = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)imgRegister).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Roboto", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(55, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(360, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sistema de Gestão Financeira";
            // 
            // imgRegister
            // 
            imgRegister.BackgroundImage = Properties.Resources.login_bg;
            imgRegister.Location = new Point(-3, 57);
            imgRegister.Name = "imgRegister";
            imgRegister.Size = new Size(449, 160);
            imgRegister.TabIndex = 1;
            imgRegister.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelName.Location = new Point(149, 247);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 19);
            labelName.TabIndex = 2;
            labelName.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(221, 245);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nome";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 3;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelLogin.Location = new Point(74, 294);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(144, 19);
            labelLogin.TabIndex = 4;
            labelLogin.Text = "Nome de usuário";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.BackColor = Color.Transparent;
            labelPass.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelPass.Location = new Point(149, 340);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(59, 19);
            labelPass.TabIndex = 5;
            labelPass.Text = "Senha";
            // 
            // labelPassConfirm
            // 
            labelPassConfirm.AutoSize = true;
            labelPassConfirm.BackColor = Color.Transparent;
            labelPassConfirm.Font = new Font("Roboto", 12F, FontStyle.Bold);
            labelPassConfirm.Location = new Point(68, 378);
            labelPassConfirm.Name = "labelPassConfirm";
            labelPassConfirm.Size = new Size(142, 19);
            labelPassConfirm.TabIndex = 6;
            labelPassConfirm.Text = "Confirmar Senha";
            // 
            // txtLogin
            // 
            txtLogin.Cursor = Cursors.IBeam;
            txtLogin.Location = new Point(221, 292);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Usuário";
            txtLogin.Size = new Size(150, 23);
            txtLogin.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(221, 338);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Senha";
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.Cursor = Cursors.IBeam;
            txtPassConfirm.Location = new Point(221, 378);
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.PlaceholderText = "Confirmar Senha";
            txtPassConfirm.Size = new Size(150, 23);
            txtPassConfirm.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Roboto", 17F);
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(78, 455);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 50);
            btnSave.TabIndex = 10;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Roboto", 14F);
            btnCancel.ForeColor = SystemColors.ControlLight;
            btnCancel.Location = new Point(261, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 50);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 234, 254);
            ClientSize = new Size(433, 576);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(labelPassConfirm);
            Controls.Add(labelPass);
            Controls.Add(labelLogin);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(imgRegister);
            Controls.Add(labelTitle);
            Cursor = Cursors.Default;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)imgRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private PictureBox imgRegister;
        private Label labelName;
        private TextBox txtName;
        private Label labelLogin;
        private Label labelPass;
        private Label labelPassConfirm;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtPassConfirm;
        private Button btnSave;
        private Button btnCancel;
    }
}