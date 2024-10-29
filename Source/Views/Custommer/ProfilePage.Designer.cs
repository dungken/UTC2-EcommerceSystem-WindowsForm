namespace Source.Views.Custommer
{
    partial class ProfilePage
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            txtCreateDate = new TextBox();
            label5 = new Label();
            txtShipAddress = new TextBox();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 459);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(108, 125, 226);
            label2.Location = new Point(0, 239);
            label2.Name = "label2";
            label2.Size = new Size(250, 43);
            label2.TabIndex = 1;
            label2.Text = "Welcome to Profile Page ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(48, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 224, 234);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCreateDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtShipAddress);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 459);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(108, 125, 226);
            button2.Location = new Point(449, 361);
            button2.Name = "button2";
            button2.Size = new Size(144, 50);
            button2.TabIndex = 15;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(108, 125, 226);
            button1.Location = new Point(261, 361);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(108, 125, 226);
            label7.Location = new Point(78, 92);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 13;
            label7.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(108, 125, 226);
            label6.Location = new Point(78, 286);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 11;
            label6.Text = "Created Date";
            // 
            // txtCreateDate
            // 
            txtCreateDate.Enabled = false;
            txtCreateDate.Location = new Point(261, 286);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new Size(256, 27);
            txtCreateDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(108, 125, 226);
            label5.Location = new Point(78, 232);
            label5.Name = "label5";
            label5.Size = new Size(176, 28);
            label5.TabIndex = 9;
            label5.Text = "Shipping Address";
            // 
            // txtShipAddress
            // 
            txtShipAddress.Location = new Point(261, 232);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(256, 27);
            txtShipAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(108, 125, 226);
            label4.Location = new Point(78, 181);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(261, 181);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(256, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(108, 125, 226);
            label3.Location = new Point(78, 135);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 5;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(108, 125, 226);
            label1.Location = new Point(78, 47);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(261, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 27);
            txtName.TabIndex = 2;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 459);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProfilePage";
            ShowInTaskbar = false;
            Text = "ProfilePage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox txtName;
        private Label label5;
        private TextBox txtShipAddress;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label3;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtCreateDate;
        private Button button2;
        private Button button1;
        private Label label7;
        private TextBox textBox1;
    }
}