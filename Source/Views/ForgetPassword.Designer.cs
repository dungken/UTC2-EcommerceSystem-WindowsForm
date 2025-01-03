namespace Source.Views
{
    partial class ForgetPassword
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
            lblExit = new Label();
            btnConfirm = new Button();
            txtNewPassword = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            btnGetLink = new Button();
            txtEmail = new TextBox();
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
            pictureBox1.Image = Properties.Resources.img_posterResgister;
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
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 36);
            label1.TabIndex = 2;
            label1.Text = "Forget Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblExit);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(txtNewPassword);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnGetLink);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(194, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 479);
            panel2.TabIndex = 5;
            // 
            // lblExit
            // 
            lblExit.Cursor = Cursors.Hand;
            lblExit.Image = Properties.Resources.icon_exit;
            lblExit.Location = new Point(0, 433);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(51, 46);
            lblExit.TabIndex = 48;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top;
            btnConfirm.BackColor = Color.FromArgb(114, 88, 219);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(121, 234);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(297, 44);
            btnConfirm.TabIndex = 47;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Top;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Location = new Point(161, 208);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.Size = new Size(230, 20);
            txtNewPassword.TabIndex = 46;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(118, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 1);
            panel4.TabIndex = 45;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = Color.White;
            label3.Image = Properties.Resources.icon_lock;
            label3.Location = new Point(125, 186);
            label3.Name = "label3";
            label3.Size = new Size(30, 49);
            label3.TabIndex = 44;
            label3.Text = " ";
            // 
            // btnGetLink
            // 
            btnGetLink.Anchor = AnchorStyles.Top;
            btnGetLink.BackColor = Color.FromArgb(114, 88, 219);
            btnGetLink.ForeColor = Color.White;
            btnGetLink.Location = new Point(118, 120);
            btnGetLink.Name = "btnGetLink";
            btnGetLink.Size = new Size(297, 44);
            btnGetLink.TabIndex = 43;
            btnGetLink.Text = "Get Link Reset";
            btnGetLink.UseVisualStyleBackColor = false;
            btnGetLink.Click += btnGetLink_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(161, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(230, 20);
            txtEmail.TabIndex = 36;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(118, 106);
            panel7.Name = "panel7";
            panel7.Size = new Size(297, 1);
            panel7.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.BackColor = Color.White;
            label2.Image = Properties.Resources.ImageAvarata;
            label2.Location = new Point(125, 58);
            label2.Name = "label2";
            label2.Size = new Size(30, 49);
            label2.TabIndex = 34;
            label2.Text = " ";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 479);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ForgetPassword";
            Text = "Login";
            Load += ForgetPassword_Load;
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
        private Button btnGetLink;
        private TextBox txtEmail;
        private Panel panel7;
        private Label label2;
        private Label lblForget;
        private TextBox txtNewPassword;
        private Panel panel4;
        private Label label3;
        private Button btnConfirm;
        private Label lblExit;
    }
}