namespace Source.Views
{
    partial class Login
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnResgister = new Button();
            lblForget = new Label();
            btnLoginWGoogle = new Button();
            label6 = new Label();
            btnLogin = new Button();
            txtPassWord = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            txtUsername = new TextBox();
            panel7 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(162, 185, 237);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 479);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.hinh_nen_ngau_6;
            pictureBox1.Location = new Point(3, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 36);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnResgister);
            panel2.Controls.Add(lblForget);
            panel2.Controls.Add(btnLoginWGoogle);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassWord);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(194, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 479);
            panel2.TabIndex = 5;
            // 
            // btnResgister
            // 
            btnResgister.Anchor = AnchorStyles.Top;
            btnResgister.BackColor = Color.FromArgb(114, 88, 219);
            btnResgister.ForeColor = Color.White;
            btnResgister.Location = new Point(144, 369);
            btnResgister.Name = "btnResgister";
            btnResgister.Size = new Size(297, 44);
            btnResgister.TabIndex = 50;
            btnResgister.Text = "Resgister";
            btnResgister.UseVisualStyleBackColor = false;
            btnResgister.Click += btnResgister_Click;
            // 
            // lblForget
            // 
            lblForget.AutoSize = true;
            lblForget.Location = new Point(324, 237);
            lblForget.Name = "lblForget";
            lblForget.Size = new Size(117, 20);
            lblForget.TabIndex = 49;
            lblForget.Text = "Forget Password";
            lblForget.Click += lblForget_Click;
            // 
            // btnLoginWGoogle
            // 
            btnLoginWGoogle.Anchor = AnchorStyles.Top;
            btnLoginWGoogle.BackColor = Color.FromArgb(114, 88, 219);
            btnLoginWGoogle.ForeColor = Color.White;
            btnLoginWGoogle.Location = new Point(144, 319);
            btnLoginWGoogle.Name = "btnLoginWGoogle";
            btnLoginWGoogle.Size = new Size(297, 44);
            btnLoginWGoogle.TabIndex = 48;
            btnLoginWGoogle.Text = "Login with google";
            btnLoginWGoogle.UseVisualStyleBackColor = false;
            btnLoginWGoogle.Click += btnLoginWGoogle_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(336, 355);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 47;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(114, 88, 219);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(144, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(297, 44);
            btnLogin.TabIndex = 43;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassWord
            // 
            txtPassWord.Anchor = AnchorStyles.Top;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Location = new Point(204, 188);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PlaceholderText = "Password";
            txtPassWord.Size = new Size(230, 20);
            txtPassWord.TabIndex = 39;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(144, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 1);
            panel4.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = Color.White;
            label3.Image = Properties.Resources.profile_3135715__1_;
            label3.Location = new Point(151, 174);
            label3.Name = "label3";
            label3.Size = new Size(30, 49);
            label3.TabIndex = 37;
            label3.Text = " ";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(204, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(230, 20);
            txtUsername.TabIndex = 36;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(144, 137);
            panel7.Name = "panel7";
            panel7.Size = new Size(297, 1);
            panel7.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.BackColor = Color.White;
            label2.Image = Properties.Resources.profile_3135715__1_;
            label2.Location = new Point(151, 89);
            label2.Name = "label2";
            label2.Size = new Size(30, 49);
            label2.TabIndex = 34;
            label2.Text = " ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 479);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label6;
        private Button btnLogin;
        private TextBox txtPassWord;
        private Panel panel4;
        private Label label3;
        private TextBox txtUsername;
        private Panel panel7;
        private Label label2;
        private Button btnLoginWGoogle;
        private Label lblForget;
        private Button btnResgister;
    }
}