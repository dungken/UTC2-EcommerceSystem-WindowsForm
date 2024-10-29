namespace Source.Views
{
    partial class Resgister
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            textBox4 = new TextBox();
            panel6 = new Panel();
            label5 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            textBox2 = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel7 = new Panel();
            label2 = new Label();
            lblExit = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.hinh_nen_ngau_6;
            pictureBox1.Location = new Point(3, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(162, 185, 237);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 479);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(224, 7);
            label1.Name = "label1";
            label1.Size = new Size(138, 36);
            label1.TabIndex = 2;
            label1.Text = "Resgister";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblExit);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(194, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 479);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(124, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 405);
            panel3.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(268, 315);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 33;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(96, 111);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Email";
            textBox4.Size = new Size(230, 20);
            textBox4.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(36, 135);
            panel6.Name = "panel6";
            panel6.Size = new Size(297, 1);
            panel6.TabIndex = 31;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = Color.White;
            label5.Image = Properties.Resources.profile_3135715__1_;
            label5.Location = new Point(43, 97);
            label5.Name = "label5";
            label5.Size = new Size(30, 49);
            label5.TabIndex = 30;
            label5.Text = " ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(114, 88, 219);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 334);
            button1.Name = "button1";
            button1.Size = new Size(297, 46);
            button1.TabIndex = 29;
            button1.Text = "Resgister";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(96, 261);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Confirm password";
            textBox3.Size = new Size(230, 20);
            textBox3.TabIndex = 28;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(36, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(297, 1);
            panel5.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.White;
            label4.Image = Properties.Resources.profile_3135715__1_;
            label4.Location = new Point(43, 247);
            label4.Name = "label4";
            label4.Size = new Size(30, 49);
            label4.TabIndex = 26;
            label4.Text = " ";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(96, 188);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(230, 20);
            textBox2.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(36, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 1);
            panel4.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.White;
            label3.Image = Properties.Resources.profile_3135715__1_;
            label3.Location = new Point(43, 174);
            label3.Name = "label3";
            label3.Size = new Size(30, 49);
            label3.TabIndex = 23;
            label3.Text = " ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(96, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(230, 20);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(36, 61);
            panel7.Name = "panel7";
            panel7.Size = new Size(297, 1);
            panel7.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.White;
            label2.Image = Properties.Resources.profile_3135715__1_;
            label2.Location = new Point(43, 23);
            label2.Name = "label2";
            label2.Size = new Size(30, 49);
            label2.TabIndex = 20;
            label2.Text = " ";
            // 
            // lblExit
            // 
            lblExit.Image = Properties.Resources._352473_return_icon;
            lblExit.Location = new Point(6, 7);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(59, 51);
            lblExit.TabIndex = 20;
            lblExit.Click += lblExit_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(173, 24);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "I agree all agreement";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Resgister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 479);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Resgister";
            Text = "Resgister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblExit;
        private Panel panel3;
        private Label label6;
        private TextBox textBox4;
        private Panel panel6;
        private Label label5;
        private Button button1;
        private TextBox textBox3;
        private Panel panel5;
        private Label label4;
        private TextBox textBox2;
        private Panel panel4;
        private Label label3;
        private TextBox textBox1;
        private Panel panel7;
        private Label label2;
        private CheckBox checkBox1;
    }
}