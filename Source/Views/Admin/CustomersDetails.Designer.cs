namespace Source.Views.Admin
{
    partial class CustomersDetails
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
            pnMain = new Panel();
            pnHeader = new Panel();
            pnSearch = new Panel();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            pnLeftHeader = new Panel();
            btnEntries = new Label();
            cbxShow = new ComboBox();
            lblShow = new Label();
            pnList = new Panel();
            gridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            pnFotter = new Panel();
            pnPage = new Panel();
            btnNext = new MyCustomControl.RJButton();
            btnPre = new MyCustomControl.RJButton();
            lblShowing = new Label();
            lblHeader = new Label();
            pnLine = new Panel();
            pnProfile = new Panel();
            lblGender = new Label();
            lblAddress = new Label();
            label2 = new Label();
            lblDateOfBirth = new Label();
            lblPhone = new Label();
            lblName = new Label();
            lblId = new Label();
            picbxProfile = new PictureBox();
            lblProfile = new Label();
            lblCustomerOrder = new Label();
            pnStatus = new Panel();
            lblCmtProductValue = new Label();
            lblProductBuyValue = new Label();
            lblCmtProduct = new Label();
            lblProductBuy = new Label();
            lblStatus = new Label();
            pnMain.SuspendLayout();
            pnHeader.SuspendLayout();
            pnSearch.SuspendLayout();
            pnLeftHeader.SuspendLayout();
            pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            pnFotter.SuspendLayout();
            pnPage.SuspendLayout();
            pnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxProfile).BeginInit();
            pnStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(lblCustomerOrder);
            pnMain.Controls.Add(pnHeader);
            pnMain.Location = new Point(390, 72);
            pnMain.Margin = new Padding(2, 3, 2, 3);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(575, 464);
            pnMain.TabIndex = 11;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.White;
            pnHeader.Controls.Add(pnSearch);
            pnHeader.Controls.Add(pnLeftHeader);
            pnHeader.Location = new Point(2, 32);
            pnHeader.Margin = new Padding(2, 3, 2, 3);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(571, 47);
            pnHeader.TabIndex = 7;
            // 
            // pnSearch
            // 
            pnSearch.Controls.Add(tbxSearch);
            pnSearch.Controls.Add(lblSearch);
            pnSearch.Location = new Point(206, 3);
            pnSearch.Margin = new Padding(2, 3, 2, 3);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(363, 45);
            pnSearch.TabIndex = 1;
            // 
            // tbxSearch
            // 
            tbxSearch.Cursor = Cursors.IBeam;
            tbxSearch.Location = new Point(86, 7);
            tbxSearch.Margin = new Padding(2, 3, 2, 3);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(251, 30);
            tbxSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 12);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 22);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // pnLeftHeader
            // 
            pnLeftHeader.Controls.Add(btnEntries);
            pnLeftHeader.Controls.Add(cbxShow);
            pnLeftHeader.Controls.Add(lblShow);
            pnLeftHeader.Location = new Point(5, 3);
            pnLeftHeader.Margin = new Padding(2, 3, 2, 3);
            pnLeftHeader.Name = "pnLeftHeader";
            pnLeftHeader.Size = new Size(191, 42);
            pnLeftHeader.TabIndex = 0;
            // 
            // btnEntries
            // 
            btnEntries.AutoSize = true;
            btnEntries.Location = new Point(119, 12);
            btnEntries.Margin = new Padding(2, 0, 2, 0);
            btnEntries.Name = "btnEntries";
            btnEntries.Size = new Size(63, 22);
            btnEntries.TabIndex = 2;
            btnEntries.Text = "entries";
            // 
            // cbxShow
            // 
            cbxShow.FormattingEnabled = true;
            cbxShow.Location = new Point(67, 5);
            cbxShow.Margin = new Padding(2, 3, 2, 3);
            cbxShow.Name = "cbxShow";
            cbxShow.Size = new Size(43, 30);
            cbxShow.TabIndex = 1;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Location = new Point(6, 13);
            lblShow.Margin = new Padding(2, 0, 2, 0);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(55, 22);
            lblShow.TabIndex = 0;
            lblShow.Text = "Show";
            // 
            // pnList
            // 
            pnList.Controls.Add(gridView);
            pnList.Cursor = Cursors.IBeam;
            pnList.Location = new Point(388, 155);
            pnList.Margin = new Padding(2, 3, 2, 3);
            pnList.Name = "pnList";
            pnList.Size = new Size(572, 336);
            pnList.TabIndex = 1;
            // 
            // gridView
            // 
            gridView.BorderStyle = BorderStyle.None;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Status, TotalAmount });
            gridView.GridColor = Color.Gray;
            gridView.Location = new Point(2, 0);
            gridView.Margin = new Padding(2, 3, 2, 3);
            gridView.Name = "gridView";
            gridView.RowHeadersVisible = false;
            gridView.RowHeadersWidth = 51;
            gridView.Size = new Size(567, 328);
            gridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
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
            // TotalAmount
            // 
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 125;
            // 
            // pnFotter
            // 
            pnFotter.Controls.Add(pnPage);
            pnFotter.Controls.Add(lblShowing);
            pnFotter.Location = new Point(388, 489);
            pnFotter.Margin = new Padding(2, 3, 2, 3);
            pnFotter.Name = "pnFotter";
            pnFotter.Size = new Size(569, 47);
            pnFotter.TabIndex = 0;
            // 
            // pnPage
            // 
            pnPage.Controls.Add(btnNext);
            pnPage.Controls.Add(btnPre);
            pnPage.Location = new Point(270, 0);
            pnPage.Margin = new Padding(2, 3, 2, 3);
            pnPage.Name = "pnPage";
            pnPage.Size = new Size(299, 45);
            pnPage.TabIndex = 1;
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
            btnNext.Margin = new Padding(2, 3, 2, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(108, 42);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.TextColor = Color.MediumSlateBlue;
            btnNext.UseVisualStyleBackColor = false;
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
            btnPre.Location = new Point(2, 1);
            btnPre.Margin = new Padding(2, 3, 2, 3);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(108, 42);
            btnPre.TabIndex = 0;
            btnPre.Text = "Previous";
            btnPre.TextColor = Color.MediumSlateBlue;
            btnPre.UseVisualStyleBackColor = false;
            // 
            // lblShowing
            // 
            lblShowing.AutoSize = true;
            lblShowing.Cursor = Cursors.IBeam;
            lblShowing.Location = new Point(23, 14);
            lblShowing.Margin = new Padding(2, 0, 2, 0);
            lblShowing.Name = "lblShowing";
            lblShowing.Size = new Size(243, 22);
            lblShowing.TabIndex = 0;
            lblShowing.Text = "Showing 1 to 10 of 13 entries";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Cursor = Cursors.IBeam;
            lblHeader.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(11, 20);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(221, 35);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "Customer Detail";
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.Silver;
            pnLine.ForeColor = SystemColors.ActiveCaptionText;
            pnLine.Location = new Point(1, 69);
            pnLine.Margin = new Padding(2, 3, 2, 3);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(964, 1);
            pnLine.TabIndex = 13;
            // 
            // pnProfile
            // 
            pnProfile.Controls.Add(lblGender);
            pnProfile.Controls.Add(lblAddress);
            pnProfile.Controls.Add(label2);
            pnProfile.Controls.Add(lblDateOfBirth);
            pnProfile.Controls.Add(lblPhone);
            pnProfile.Controls.Add(lblName);
            pnProfile.Controls.Add(lblId);
            pnProfile.Controls.Add(picbxProfile);
            pnProfile.Controls.Add(lblProfile);
            pnProfile.Location = new Point(4, 76);
            pnProfile.Name = "pnProfile";
            pnProfile.Size = new Size(379, 312);
            pnProfile.TabIndex = 14;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = SystemColors.ControlDarkDark;
            lblGender.Location = new Point(115, 142);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(127, 19);
            lblGender.TabIndex = 8;
            lblGender.Text = "24 years, female";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(44, 282);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(328, 22);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "2734 West Fork Street,EASTON 02334.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 246);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 6;
            label2.Text = "202-555-0174";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(44, 210);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(102, 22);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "19/03/1980";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(44, 173);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(124, 22);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "202-555-0174";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(131, 119);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 23);
            lblName.TabIndex = 3;
            lblName.Text = "Joan Dyer";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ControlDarkDark;
            lblId.Location = new Point(123, 88);
            lblId.Name = "lblId";
            lblId.Size = new Size(119, 19);
            lblId.TabIndex = 2;
            lblId.Text = "ID : #CS-00002";
            // 
            // picbxProfile
            // 
            picbxProfile.Location = new Point(138, 23);
            picbxProfile.Name = "picbxProfile";
            picbxProfile.Size = new Size(90, 62);
            picbxProfile.TabIndex = 1;
            picbxProfile.TabStop = false;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.Location = new Point(12, 12);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(78, 25);
            lblProfile.TabIndex = 0;
            lblProfile.Text = "Profile";
            // 
            // lblCustomerOrder
            // 
            lblCustomerOrder.AutoSize = true;
            lblCustomerOrder.Cursor = Cursors.IBeam;
            lblCustomerOrder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerOrder.Location = new Point(7, 4);
            lblCustomerOrder.Name = "lblCustomerOrder";
            lblCustomerOrder.Size = new Size(188, 25);
            lblCustomerOrder.TabIndex = 15;
            lblCustomerOrder.Text = "Customer Orders";
            // 
            // pnStatus
            // 
            pnStatus.Controls.Add(lblCmtProductValue);
            pnStatus.Controls.Add(lblProductBuyValue);
            pnStatus.Controls.Add(lblCmtProduct);
            pnStatus.Controls.Add(lblProductBuy);
            pnStatus.Controls.Add(lblStatus);
            pnStatus.Location = new Point(3, 394);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(380, 138);
            pnStatus.TabIndex = 16;
            // 
            // lblCmtProductValue
            // 
            lblCmtProductValue.AutoSize = true;
            lblCmtProductValue.Location = new Point(28, 89);
            lblCmtProductValue.Name = "lblCmtProductValue";
            lblCmtProductValue.Size = new Size(40, 22);
            lblCmtProductValue.TabIndex = 6;
            lblCmtProductValue.Text = "105";
            // 
            // lblProductBuyValue
            // 
            lblProductBuyValue.AutoSize = true;
            lblProductBuyValue.Location = new Point(28, 37);
            lblProductBuyValue.Name = "lblProductBuyValue";
            lblProductBuyValue.Size = new Size(30, 22);
            lblProductBuyValue.TabIndex = 5;
            lblProductBuyValue.Text = "32";
            // 
            // lblCmtProduct
            // 
            lblCmtProduct.AutoSize = true;
            lblCmtProduct.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCmtProduct.ForeColor = SystemColors.ControlDarkDark;
            lblCmtProduct.Location = new Point(192, 91);
            lblCmtProduct.Name = "lblCmtProduct";
            lblCmtProduct.Size = new Size(155, 19);
            lblCmtProduct.TabIndex = 4;
            lblCmtProduct.Text = "Comment on Product";
            // 
            // lblProductBuy
            // 
            lblProductBuy.AutoSize = true;
            lblProductBuy.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductBuy.ForeColor = SystemColors.ControlDarkDark;
            lblProductBuy.Location = new Point(257, 40);
            lblProductBuy.Name = "lblProductBuy";
            lblProductBuy.Size = new Size(90, 19);
            lblProductBuy.TabIndex = 3;
            lblProductBuy.Text = "ProductBuy";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(13, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(152, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status Report";
            // 
            // CustomersDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 251, 253);
            ClientSize = new Size(964, 538);
            Controls.Add(pnStatus);
            Controls.Add(pnFotter);
            Controls.Add(pnList);
            Controls.Add(pnProfile);
            Controls.Add(pnLine);
            Controls.Add(lblHeader);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomersDetails";
            Text = "CustomersDetails";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            pnHeader.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            pnLeftHeader.ResumeLayout(false);
            pnLeftHeader.PerformLayout();
            pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            pnFotter.ResumeLayout(false);
            pnFotter.PerformLayout();
            pnPage.ResumeLayout(false);
            pnProfile.ResumeLayout(false);
            pnProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbxProfile).EndInit();
            pnStatus.ResumeLayout(false);
            pnStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnMain;
        private Panel pnHeader;
        private Panel pnSearch;
        private TextBox tbxSearch;
        private Label lblSearch;
        private Panel pnLeftHeader;
        private Label btnEntries;
        private ComboBox cbxShow;
        private Label lblShow;
        private Panel pnList;
        private DataGridView gridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn TotalAmount;
        private Panel pnFotter;
        private Panel pnPage;
        private MyCustomControl.RJButton btnNext;
        private MyCustomControl.RJButton btnPre;
        private Label lblShowing;
        private Label lblHeader;
        private Panel pnLine;
        private Panel pnProfile;
        private Label lblName;
        private Label lblId;
        private PictureBox picbxProfile;
        private Label lblProfile;
        private Label lblCustomerOrder;
        private Label lblGender;
        private Label lblAddress;
        private Label label2;
        private Label lblDateOfBirth;
        private Label lblPhone;
        private Panel pnStatus;
        private Label lblStatus;
        private Label lblCmtProductValue;
        private Label lblProductBuyValue;
        private Label lblCmtProduct;
        private Label lblProductBuy;
    }
}