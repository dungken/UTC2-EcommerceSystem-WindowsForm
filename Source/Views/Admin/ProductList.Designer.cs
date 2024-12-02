using System.Windows.Forms;

namespace Source.Views.Admin
{
    partial class ProductList
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
            pnTitle = new Panel();
            lblHeader = new Label();
            btnAdd = new MyCustomControl.RJButton();
            pnLine = new Panel();
            pnMain = new Panel();
            pnHeader = new Panel();
            pnLeftHeader = new Panel();
            lblShow = new Label();
            cbxShow = new ComboBox();
            btnEntries = new Label();
            pnSearch = new Panel();
            lblSearch = new Label();
            textBox1 = new TextBox();
            pnFotter = new Panel();
            lblShowing = new Label();
            pnPage = new Panel();
            btnPre = new MyCustomControl.RJButton();
            btnNext = new MyCustomControl.RJButton();
            pnList = new Panel();
            gridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            pnTitle.SuspendLayout();
            pnMain.SuspendLayout();
            pnHeader.SuspendLayout();
            pnLeftHeader.SuspendLayout();
            pnSearch.SuspendLayout();
            pnFotter.SuspendLayout();
            pnPage.SuspendLayout();
            pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(btnAdd);
            pnTitle.Controls.Add(lblHeader);
            pnTitle.Location = new Point(0, -2);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(964, 91);
            pnTitle.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Cursor = Cursors.IBeam;
            lblHeader.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(23, 27);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(195, 35);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Categorie List";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSlateBlue;
            btnAdd.BackgroundColor = Color.MediumSlateBlue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(684, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Categories";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.Silver;
            pnLine.ForeColor = SystemColors.ActiveCaptionText;
            pnLine.Location = new Point(0, 88);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(964, 1);
            pnLine.TabIndex = 1;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(pnList);
            pnMain.Controls.Add(pnFotter);
            pnMain.Location = new Point(1, 101);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(963, 440);
            pnMain.TabIndex = 2;
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(pnSearch);
            pnHeader.Controls.Add(pnLeftHeader);
            pnHeader.Location = new Point(0, 104);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(963, 48);
            pnHeader.TabIndex = 0;
            // 
            // pnLeftHeader
            // 
            pnLeftHeader.Controls.Add(btnEntries);
            pnLeftHeader.Controls.Add(cbxShow);
            pnLeftHeader.Controls.Add(lblShow);
            pnLeftHeader.Location = new Point(12, 3);
            pnLeftHeader.Name = "pnLeftHeader";
            pnLeftHeader.Size = new Size(191, 42);
            pnLeftHeader.TabIndex = 0;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Location = new Point(6, 13);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(55, 22);
            lblShow.TabIndex = 0;
            lblShow.Text = "Show";
            // 
            // cbxShow
            // 
            cbxShow.FormattingEnabled = true;
            cbxShow.Location = new Point(67, 5);
            cbxShow.Name = "cbxShow";
            cbxShow.Size = new Size(43, 30);
            cbxShow.TabIndex = 1;
            // 
            // btnEntries
            // 
            btnEntries.AutoSize = true;
            btnEntries.Location = new Point(118, 12);
            btnEntries.Name = "btnEntries";
            btnEntries.Size = new Size(63, 22);
            btnEntries.TabIndex = 2;
            btnEntries.Text = "entries";
            // 
            // pnSearch
            // 
            pnSearch.Controls.Add(textBox1);
            pnSearch.Controls.Add(lblSearch);
            pnSearch.Location = new Point(597, 0);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(363, 45);
            pnSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 22);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(86, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 30);
            textBox1.TabIndex = 1;
            // 
            // pnFotter
            // 
            pnFotter.Controls.Add(pnPage);
            pnFotter.Controls.Add(lblShowing);
            pnFotter.Location = new Point(2, 389);
            pnFotter.Name = "pnFotter";
            pnFotter.Size = new Size(957, 48);
            pnFotter.TabIndex = 0;
            // 
            // lblShowing
            // 
            lblShowing.AutoSize = true;
            lblShowing.Cursor = Cursors.IBeam;
            lblShowing.Location = new Point(23, 14);
            lblShowing.Name = "lblShowing";
            lblShowing.Size = new Size(243, 22);
            lblShowing.TabIndex = 0;
            lblShowing.Text = "Showing 1 to 10 of 13 entries";
            // 
            // pnPage
            // 
            pnPage.Controls.Add(btnNext);
            pnPage.Controls.Add(btnPre);
            pnPage.Location = new Point(655, 3);
            pnPage.Name = "pnPage";
            pnPage.Size = new Size(299, 45);
            pnPage.TabIndex = 1;
            // 
            // btnPre
            // 
            btnPre.BackColor = Color.FromArgb(249, 251, 253);
            btnPre.BackgroundColor = Color.FromArgb(249, 251, 253);
            btnPre.BorderColor = Color.PaleVioletRed;
            btnPre.BorderRadius = 20;
            btnPre.BorderSize = 0;
            btnPre.Cursor = Cursors.Hand;
            btnPre.FlatAppearance.BorderSize = 0;
            btnPre.FlatStyle = FlatStyle.Flat;
            btnPre.ForeColor = Color.MediumSlateBlue;
            btnPre.Location = new Point(3, 1);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(108, 42);
            btnPre.TabIndex = 0;
            btnPre.Text = "Previous";
            btnPre.TextColor = Color.MediumSlateBlue;
            btnPre.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(249, 251, 253);
            btnNext.BackgroundColor = Color.FromArgb(249, 251, 253);
            btnNext.BorderColor = Color.PaleVioletRed;
            btnNext.BorderRadius = 20;
            btnNext.BorderSize = 0;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.MediumSlateBlue;
            btnNext.Location = new Point(194, 1);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(108, 42);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.TextColor = Color.MediumSlateBlue;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // pnList
            // 
            pnList.Controls.Add(gridView);
            pnList.Cursor = Cursors.IBeam;
            pnList.Location = new Point(-2, 51);
            pnList.Name = "pnList";
            pnList.Size = new Size(965, 336);
            pnList.TabIndex = 1;
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Columns.AddRange(new DataGridViewColumn[] { Id, Category, Date, Status, Action });
            gridView.Location = new Point(15, 4);
            gridView.Name = "gridView";
            gridView.RowHeadersVisible = false;
            gridView.RowHeadersWidth = 51;
            gridView.Size = new Size(938, 328);
            gridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Status";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 251, 253);
            ClientSize = new Size(964, 538);
            Controls.Add(pnHeader);
            Controls.Add(pnMain);
            Controls.Add(pnLine);
            Controls.Add(pnTitle);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductList";
            Text = "ProductList";
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            pnMain.ResumeLayout(false);
            pnHeader.ResumeLayout(false);
            pnLeftHeader.ResumeLayout(false);
            pnLeftHeader.PerformLayout();
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnFotter.ResumeLayout(false);
            pnFotter.PerformLayout();
            pnPage.ResumeLayout(false);
            pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);

            // Custom
            gridView.BorderStyle = BorderStyle.None;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Đường kẻ giữa các ô
            gridView.GridColor = Color.Gray; // Màu đường kẻ
        }

        #endregion

        private Panel pnTitle;
        private MyCustomControl.RJButton btnAdd;
        private Label lblHeader;
        private Panel pnLine;
        private Panel pnMain;
        private Panel pnHeader;
        private Panel pnLeftHeader;
        private Label lblShow;
        private Panel pnSearch;
        private Label lblSearch;
        private Label btnEntries;
        private ComboBox cbxShow;
        private Panel pnFotter;
        private TextBox textBox1;
        private Panel pnPage;
        private MyCustomControl.RJButton btnPre;
        private Label lblShowing;
        private Panel pnList;
        private MyCustomControl.RJButton btnNext;
        private DataGridView gridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Action;
    }
}