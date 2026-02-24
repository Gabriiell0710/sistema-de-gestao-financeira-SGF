namespace SGF
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            imgUser = new PictureBox();
            pictureBox2 = new PictureBox();
            textLogin = new TextBox();
            textPassword = new TextBox();
            btnEntrer = new Button();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.login_bg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-7, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 271);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 29);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Gestão Financeira";
            // 
            // imgUser
            // 
            imgUser.BackColor = Color.Transparent;
            imgUser.BackgroundImage = Properties.Resources.usuario;
            imgUser.BackgroundImageLayout = ImageLayout.Stretch;
            imgUser.Location = new Point(107, 349);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(40, 35);
            imgUser.TabIndex = 2;
            imgUser.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.senha;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(107, 398);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 35);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textLogin
            // 
            textLogin.BackColor = SystemColors.Window;
            textLogin.Cursor = Cursors.IBeam;
            textLogin.Location = new Point(171, 361);
            textLogin.Name = "textLogin";
            textLogin.PlaceholderText = "Usuário";
            textLogin.Size = new Size(150, 23);
            textLogin.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.BackColor = SystemColors.Window;
            textPassword.Cursor = Cursors.IBeam;
            textPassword.Location = new Point(171, 402);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Senha";
            textPassword.Size = new Size(150, 23);
            textPassword.TabIndex = 5;
            textPassword.UseSystemPasswordChar = true;
            // 
            // btnEntrer
            // 
            btnEntrer.BackColor = Color.DarkGreen;
            btnEntrer.Cursor = Cursors.Hand;
            btnEntrer.Font = new Font("Roboto", 16F, FontStyle.Bold);
            btnEntrer.ForeColor = SystemColors.ControlLight;
            btnEntrer.Location = new Point(93, 474);
            btnEntrer.Name = "btnEntrer";
            btnEntrer.Size = new Size(100, 50);
            btnEntrer.TabIndex = 6;
            btnEntrer.Text = "Entrar";
            btnEntrer.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkOrange;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Roboto", 12F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ControlLight;
            btnRegister.Location = new Point(241, 474);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 50);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 234, 254);
            ClientSize = new Size(433, 576);
            Controls.Add(btnRegister);
            Controls.Add(btnEntrer);
            Controls.Add(textPassword);
            Controls.Add(textLogin);
            Controls.Add(pictureBox2);
            Controls.Add(imgUser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox imgUser;
        private PictureBox pictureBox2;
        private TextBox textLogin;
        private TextBox textPassword;
        private Button btnEntrer;
        private Button btnRegister;
    }
}
