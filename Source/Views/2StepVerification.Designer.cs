namespace Source.Views
{
    partial class _2StepVerification
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
            panel2 = new Panel();
            pn2Step = new Panel();
            lblEnterCode = new Label();
            lblGetCode = new Label();
            tbxCode = new TextBox();
            lblOther = new Label();
            cbxRemember = new CheckBox();
            label6 = new Label();
            btnDone = new Button();
            pnLine = new Panel();
            lblExit = new Label();
            lblHeader = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pn2Step.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(162, 185, 237);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 569);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.img_posterResgister;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 566);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pn2Step);
            panel2.Controls.Add(lblExit);
            panel2.Controls.Add(lblHeader);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(194, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 569);
            panel2.TabIndex = 4;
            // 
            // pn2Step
            // 
            pn2Step.Anchor = AnchorStyles.Top;
            pn2Step.BackColor = Color.WhiteSmoke;
            pn2Step.Controls.Add(label1);
            pn2Step.Controls.Add(lblEnterCode);
            pn2Step.Controls.Add(lblGetCode);
            pn2Step.Controls.Add(tbxCode);
            pn2Step.Controls.Add(lblOther);
            pn2Step.Controls.Add(cbxRemember);
            pn2Step.Controls.Add(label6);
            pn2Step.Controls.Add(btnDone);
            pn2Step.Controls.Add(pnLine);
            pn2Step.Location = new Point(68, 61);
            pn2Step.Name = "pn2Step";
            pn2Step.Size = new Size(458, 496);
            pn2Step.TabIndex = 21;
            // 
            // lblEnterCode
            // 
            lblEnterCode.AutoSize = true;
            lblEnterCode.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterCode.Location = new Point(65, 111);
            lblEnterCode.Name = "lblEnterCode";
            lblEnterCode.Size = new Size(218, 23);
            lblEnterCode.TabIndex = 39;
            lblEnterCode.Text = "Enter a verification code";
            // 
            // lblGetCode
            // 
            lblGetCode.AutoSize = true;
            lblGetCode.Location = new Point(65, 162);
            lblGetCode.Name = "lblGetCode";
            lblGetCode.Size = new Size(322, 22);
            lblGetCode.TabIndex = 38;
            lblGetCode.Text = "Get a verfication code form your email ";
            // 
            // tbxCode
            // 
            tbxCode.BorderStyle = BorderStyle.FixedSingle;
            tbxCode.Location = new Point(65, 214);
            tbxCode.Multiline = true;
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(322, 54);
            tbxCode.TabIndex = 37;
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Cursor = Cursors.Hand;
            lblOther.ForeColor = SystemColors.Highlight;
            lblOther.Location = new Point(123, 437);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(215, 22);
            lblOther.TabIndex = 36;
            lblOther.Text = "Try another way to sign in";
            // 
            // cbxRemember
            // 
            cbxRemember.AutoSize = true;
            cbxRemember.Location = new Point(65, 357);
            cbxRemember.Name = "cbxRemember";
            cbxRemember.Size = new Size(322, 26);
            cbxRemember.TabIndex = 35;
            cbxRemember.Text = "Remember this computer for 30 days";
            cbxRemember.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(268, 315);
            label6.Name = "label6";
            label6.Size = new Size(0, 22);
            label6.TabIndex = 33;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.None;
            btnDone.BackColor = Color.CornflowerBlue;
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(65, 290);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(322, 46);
            btnDone.TabIndex = 29;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            // 
            // pnLine
            // 
            pnLine.Anchor = AnchorStyles.Top;
            pnLine.BackColor = Color.Black;
            pnLine.Location = new Point(3, 406);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(455, 1);
            pnLine.TabIndex = 27;
            // 
            // lblExit
            // 
            lblExit.Location = new Point(6, 7);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(59, 51);
            lblExit.TabIndex = 20;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(181, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(239, 36);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "2-Step Verification";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 57);
            label1.Name = "label1";
            label1.Size = new Size(206, 22);
            label1.TabIndex = 40;
            label1.Text = "Thêm tấm hình dô đây nè";
            // 
            // _2StepVerification
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "_2StepVerification";
            Text = "_2StepVerification";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            pn2Step.ResumeLayout(false);
            pn2Step.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel pn2Step;
        private CheckBox cbxRemember;
        private Label label6;
        private Button btnDone;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Panel pnLine;
        private Label label4;
        private TextBox textBox2;
        private Panel panel4;
        private Label label3;
        private Label lblExit;
        private Label lblHeader;
        private Label lblOther;
        private TextBox tbxCode;
        private Label lblEnterCode;
        private Label lblGetCode;
        private Label label1;
    }
}