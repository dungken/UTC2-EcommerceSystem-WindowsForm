namespace Source.Views
{
    partial class ConfirmDeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDeleteAccount));
            pnHeader = new Panel();
            pnLineTop = new Panel();
            lblClose = new Label();
            lblHeader = new Label();
            pnNofi = new Panel();
            pnLineBot = new Panel();
            lblNofi = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            pnHeader.SuspendLayout();
            pnNofi.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = SystemColors.Control;
            pnHeader.Controls.Add(pnLineTop);
            pnHeader.Controls.Add(lblClose);
            pnHeader.Controls.Add(lblHeader);
            pnHeader.Location = new Point(1, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(602, 48);
            pnHeader.TabIndex = 0;
            // 
            // pnLineTop
            // 
            pnLineTop.BackColor = Color.Silver;
            pnLineTop.Location = new Point(3, 46);
            pnLineTop.Name = "pnLineTop";
            pnLineTop.Size = new Size(602, 1);
            pnLineTop.TabIndex = 10;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClose.ForeColor = SystemColors.ControlDark;
            lblClose.Location = new Point(565, 8);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(23, 26);
            lblClose.TabIndex = 26;
            lblClose.Text = "x";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Cursor = Cursors.IBeam;
            lblHeader.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(11, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(342, 25);
            lblHeader.TabIndex = 24;
            lblHeader.Text = "Xác nhận xóa tài khoản vĩnh viễn";
            // 
            // pnNofi
            // 
            pnNofi.Controls.Add(pnLineBot);
            pnNofi.Controls.Add(lblNofi);
            pnNofi.Location = new Point(1, 53);
            pnNofi.Name = "pnNofi";
            pnNofi.Size = new Size(602, 125);
            pnNofi.TabIndex = 1;
            // 
            // pnLineBot
            // 
            pnLineBot.BackColor = Color.Silver;
            pnLineBot.Location = new Point(3, 124);
            pnLineBot.Name = "pnLineBot";
            pnLineBot.Size = new Size(602, 1);
            pnLineBot.TabIndex = 11;
            // 
            // lblNofi
            // 
            lblNofi.Cursor = Cursors.IBeam;
            lblNofi.Location = new Point(11, 11);
            lblNofi.Name = "lblNofi";
            lblNofi.Size = new Size(591, 105);
            lblNofi.TabIndex = 0;
            lblNofi.Text = resources.GetString("lblNofi.Text");
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(333, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(426, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa tài khoản";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // ConfirmDeleteAccount
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(606, 232);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(pnNofi);
            Controls.Add(pnHeader);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConfirmDeleteAccount";
            Text = "ConfirmDeleteAccount";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnNofi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnHeader;
        private Label lblHeader;
        private Label lblClose;
        private Panel pnNofi;
        private Label lblNofi;
        private Button btnCancel;
        private Panel pnLineTop;
        private Button btnDelete;
        private Panel pnLineBot;
    }
}