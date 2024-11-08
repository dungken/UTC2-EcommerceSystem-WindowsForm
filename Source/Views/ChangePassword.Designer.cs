namespace Source.Views
{
    partial class ChangePassword
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
            pnImg = new Panel();
            pbxLeft = new PictureBox();
            pnMain = new Panel();
            lblHeader = new Label();
            pnForm = new Panel();
            label1 = new Label();
            btnUpdate = new Button();
            tbxAgain = new TextBox();
            pnLine2 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            pnLine4 = new Panel();
            label4 = new Label();
            tbxNewPass = new TextBox();
            pnLine3 = new Panel();
            label3 = new Label();
            pnLine1 = new Panel();
            label2 = new Label();
            lblUser = new Label();
            lblOldPass = new Label();
            pnImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLeft).BeginInit();
            pnMain.SuspendLayout();
            pnForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnImg
            // 
            pnImg.BackColor = Color.FromArgb(162, 185, 237);
            pnImg.Controls.Add(pbxLeft);
            pnImg.Dock = DockStyle.Left;
            pnImg.Location = new Point(0, 0);
            pnImg.Name = "pnImg";
            pnImg.Size = new Size(194, 479);
            pnImg.TabIndex = 2;
            // 
            // pbxLeft
            // 
            pbxLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxLeft.Image = Properties.Resources.img_posterResgister;
            pbxLeft.Location = new Point(0, 0);
            pbxLeft.Name = "pbxLeft";
            pbxLeft.Size = new Size(194, 476);
            pbxLeft.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLeft.TabIndex = 0;
            pbxLeft.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(lblHeader);
            pnMain.Controls.Add(pnForm);
            pnMain.Location = new Point(195, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(583, 479);
            pnMain.TabIndex = 3;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Cursor = Cursors.IBeam;
            lblHeader.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(199, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(176, 32);
            lblHeader.TabIndex = 23;
            lblHeader.Text = "Đổi mật khẩu";
            // 
            // pnForm
            // 
            pnForm.Anchor = AnchorStyles.Top;
            pnForm.Controls.Add(lblOldPass);
            pnForm.Controls.Add(lblUser);
            pnForm.Controls.Add(label1);
            pnForm.Controls.Add(btnUpdate);
            pnForm.Controls.Add(tbxAgain);
            pnForm.Controls.Add(pnLine2);
            pnForm.Controls.Add(button1);
            pnForm.Controls.Add(textBox3);
            pnForm.Controls.Add(pnLine4);
            pnForm.Controls.Add(label4);
            pnForm.Controls.Add(tbxNewPass);
            pnForm.Controls.Add(pnLine3);
            pnForm.Controls.Add(label3);
            pnForm.Controls.Add(pnLine1);
            pnForm.Controls.Add(label2);
            pnForm.Location = new Point(132, 50);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(337, 405);
            pnForm.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.White;
            label1.Image = Properties.Resources.icon_lock;
            label1.Location = new Point(22, 89);
            label1.Name = "label1";
            label1.Size = new Size(30, 49);
            label1.TabIndex = 38;
            label1.Text = " ";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(114, 88, 219);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(22, 335);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(297, 46);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // tbxAgain
            // 
            tbxAgain.Anchor = AnchorStyles.None;
            tbxAgain.BorderStyle = BorderStyle.None;
            tbxAgain.Location = new Point(58, 261);
            tbxAgain.Name = "tbxAgain";
            tbxAgain.PlaceholderText = "Nhập lại mật khẩu mới";
            tbxAgain.Size = new Size(230, 23);
            tbxAgain.TabIndex = 36;
            // 
            // pnLine2
            // 
            pnLine2.Anchor = AnchorStyles.Top;
            pnLine2.BackColor = Color.Black;
            pnLine2.Location = new Point(22, 141);
            pnLine2.Name = "pnLine2";
            pnLine2.Size = new Size(297, 1);
            pnLine2.TabIndex = 31;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(114, 88, 219);
            button1.ForeColor = Color.White;
            button1.Location = new Point(104, 486);
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
            textBox3.Location = new Point(164, 413);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Confirm password";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 28;
            // 
            // pnLine4
            // 
            pnLine4.Anchor = AnchorStyles.Top;
            pnLine4.BackColor = Color.Black;
            pnLine4.Location = new Point(22, 301);
            pnLine4.Name = "pnLine4";
            pnLine4.Size = new Size(297, 1);
            pnLine4.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.White;
            label4.Image = Properties.Resources.icon_lock;
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(30, 49);
            label4.TabIndex = 26;
            label4.Text = " ";
            // 
            // tbxNewPass
            // 
            tbxNewPass.Anchor = AnchorStyles.None;
            tbxNewPass.BorderStyle = BorderStyle.None;
            tbxNewPass.Location = new Point(58, 185);
            tbxNewPass.Name = "tbxNewPass";
            tbxNewPass.PlaceholderText = "Mật khẩu mới";
            tbxNewPass.Size = new Size(230, 23);
            tbxNewPass.TabIndex = 25;
            // 
            // pnLine3
            // 
            pnLine3.Anchor = AnchorStyles.Top;
            pnLine3.BackColor = Color.Black;
            pnLine3.Location = new Point(22, 225);
            pnLine3.Name = "pnLine3";
            pnLine3.Size = new Size(297, 1);
            pnLine3.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.White;
            label3.Image = Properties.Resources.icon_lock;
            label3.Location = new Point(22, 249);
            label3.Name = "label3";
            label3.Size = new Size(30, 49);
            label3.TabIndex = 23;
            label3.Text = " ";
            // 
            // pnLine1
            // 
            pnLine1.Anchor = AnchorStyles.Top;
            pnLine1.BackColor = Color.Black;
            pnLine1.Location = new Point(22, 66);
            pnLine1.Name = "pnLine1";
            pnLine1.Size = new Size(297, 1);
            pnLine1.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.White;
            label2.Image = Properties.Resources.ImageAvarata1;
            label2.Location = new Point(22, 18);
            label2.Name = "label2";
            label2.Size = new Size(30, 49);
            label2.TabIndex = 20;
            label2.Text = " ";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Enabled = false;
            lblUser.Location = new Point(70, 34);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 22);
            lblUser.TabIndex = 39;
            // 
            // lblOldPass
            // 
            lblOldPass.AutoSize = true;
            lblOldPass.Enabled = false;
            lblOldPass.Location = new Point(70, 106);
            lblOldPass.Name = "lblOldPass";
            lblOldPass.Size = new Size(0, 22);
            lblOldPass.TabIndex = 40;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 479);
            Controls.Add(pnMain);
            Controls.Add(pnImg);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangePassword";
            Text = "ChangePassword";
            pnImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLeft).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnImg;
        private PictureBox pbxLeft;
        private Panel pnMain;
        private Panel pnForm;
        private Panel pnLine2;
        private Button button1;
        private TextBox textBox3;
        private Panel pnLine4;
        private Label label4;
        private TextBox tbxNewPass;
        private Panel pnLine3;
        private Label label3;
        private Panel pnLine1;
        private Label label2;
        private Label lblHeader;
        private TextBox tbxAgain;
        private Button btnUpdate;
        private Label label1;
        private Label lblOldPass;
        private Label lblUser;
    }
}