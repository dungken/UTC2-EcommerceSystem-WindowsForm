namespace Source.Views.Admin
{
    partial class OrderDetails
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
            pnLine = new Panel();
            pnTitle = new Panel();
            cbxOrderId = new ComboBox();
            lblOrderId = new Label();
            lblHeader = new Label();
            pnPage = new Panel();
            btnNext = new MyCustomControl.RJButton();
            btnPre = new MyCustomControl.RJButton();
            pnList = new Panel();
            lblOrderSummary = new Label();
            gridView = new DataGridView();
            ProductImage = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            pnMain = new Panel();
            pnPrice = new Panel();
            pnLineShort = new Panel();
            lblTotalValue = new Label();
            lblDiscountValue = new Label();
            lblShippingCostValue = new Label();
            lblTotal = new Label();
            label3 = new Label();
            lblShippingCost = new Label();
            lblSubotalPriceValue = new Label();
            lblSubotalPrice = new Label();
            pnInformation = new Panel();
            lblPhone = new Label();
            label1 = new Label();
            lblAddressValue = new Label();
            lblAddress = new Label();
            lblNameValue = new Label();
            lblName = new Label();
            lblOrderCreated = new Label();
            rbtnName = new MyCustomControl.RJButton();
            rbtnContact = new MyCustomControl.RJButton();
            rbtnAddress = new MyCustomControl.RJButton();
            lblDate = new Label();
            rbtnOrderDate = new MyCustomControl.RJButton();
            pictureBox1 = new PictureBox();
            pnTitle.SuspendLayout();
            pnPage.SuspendLayout();
            pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            pnMain.SuspendLayout();
            pnPrice.SuspendLayout();
            pnInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.Silver;
            pnLine.ForeColor = SystemColors.ActiveCaptionText;
            pnLine.Location = new Point(3, 80);
            pnLine.Margin = new Padding(2, 3, 2, 3);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(964, 1);
            pnLine.TabIndex = 13;
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(cbxOrderId);
            pnTitle.Controls.Add(pnLine);
            pnTitle.Controls.Add(lblOrderId);
            pnTitle.Controls.Add(lblHeader);
            pnTitle.Location = new Point(0, -2);
            pnTitle.Margin = new Padding(2, 3, 2, 3);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(964, 84);
            pnTitle.TabIndex = 12;
            // 
            // cbxOrderId
            // 
            cbxOrderId.FormattingEnabled = true;
            cbxOrderId.Location = new Point(776, 27);
            cbxOrderId.Name = "cbxOrderId";
            cbxOrderId.Size = new Size(176, 30);
            cbxOrderId.TabIndex = 3;
            cbxOrderId.Text = "Selected Order Id";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Cursor = Cursors.IBeam;
            lblOrderId.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderId.Location = new Point(236, 27);
            lblOrderId.Margin = new Padding(2, 0, 2, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(191, 35);
            lblOrderId.TabIndex = 2;
            lblOrderId.Text = "#Order-78414";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Cursor = Cursors.IBeam;
            lblHeader.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(23, 27);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(209, 35);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Orders Details:";
            // 
            // pnPage
            // 
            pnPage.Controls.Add(btnNext);
            pnPage.Controls.Add(btnPre);
            pnPage.Location = new Point(306, 396);
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
            btnNext.Location = new Point(191, 3);
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
            // pnList
            // 
            pnList.Controls.Add(lblOrderSummary);
            pnList.Controls.Add(gridView);
            pnList.Cursor = Cursors.IBeam;
            pnList.Location = new Point(-2, 93);
            pnList.Margin = new Padding(2, 3, 2, 3);
            pnList.Name = "pnList";
            pnList.Size = new Size(607, 294);
            pnList.TabIndex = 1;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSummary.Location = new Point(13, 12);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(177, 25);
            lblOrderSummary.TabIndex = 1;
            lblOrderSummary.Text = "Order Summary";
            // 
            // gridView
            // 
            gridView.BorderStyle = BorderStyle.None;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Columns.AddRange(new DataGridViewColumn[] { ProductImage, ProductName, Quantity, Price });
            gridView.GridColor = Color.Gray;
            gridView.Location = new Point(5, 54);
            gridView.Margin = new Padding(2, 3, 2, 3);
            gridView.Name = "gridView";
            gridView.RowHeadersVisible = false;
            gridView.RowHeadersWidth = 51;
            gridView.Size = new Size(602, 246);
            gridView.TabIndex = 0;
            // 
            // ProductImage
            // 
            ProductImage.HeaderText = "Product Image";
            ProductImage.MinimumWidth = 6;
            ProductImage.Name = "ProductImage";
            ProductImage.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(pnPrice);
            pnMain.Controls.Add(pnPage);
            pnMain.Controls.Add(pnInformation);
            pnMain.Controls.Add(pictureBox1);
            pnMain.Controls.Add(pnList);
            pnMain.Location = new Point(1, 85);
            pnMain.Margin = new Padding(2, 3, 2, 3);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(963, 456);
            pnMain.TabIndex = 14;
            // 
            // pnPrice
            // 
            pnPrice.Controls.Add(pnLineShort);
            pnPrice.Controls.Add(lblTotalValue);
            pnPrice.Controls.Add(lblDiscountValue);
            pnPrice.Controls.Add(lblShippingCostValue);
            pnPrice.Controls.Add(lblTotal);
            pnPrice.Controls.Add(label3);
            pnPrice.Controls.Add(lblShippingCost);
            pnPrice.Controls.Add(lblSubotalPriceValue);
            pnPrice.Controls.Add(lblSubotalPrice);
            pnPrice.Location = new Point(627, 133);
            pnPrice.Name = "pnPrice";
            pnPrice.Size = new Size(324, 254);
            pnPrice.TabIndex = 6;
            // 
            // pnLineShort
            // 
            pnLineShort.BackColor = Color.Silver;
            pnLineShort.ForeColor = SystemColors.ActiveCaptionText;
            pnLineShort.Location = new Point(25, 173);
            pnLineShort.Margin = new Padding(2, 3, 2, 3);
            pnLineShort.Name = "pnLineShort";
            pnLineShort.Size = new Size(276, 1);
            pnLineShort.TabIndex = 14;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(204, 190);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(85, 22);
            lblTotalValue.TabIndex = 7;
            lblTotalValue.Text = "$1296.00";
            // 
            // lblDiscountValue
            // 
            lblDiscountValue.AutoSize = true;
            lblDiscountValue.Location = new Point(204, 131);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(65, 22);
            lblDiscountValue.TabIndex = 6;
            lblDiscountValue.Text = "$10.00";
            // 
            // lblShippingCostValue
            // 
            lblShippingCostValue.AutoSize = true;
            lblShippingCostValue.Location = new Point(204, 68);
            lblShippingCostValue.Name = "lblShippingCostValue";
            lblShippingCostValue.Size = new Size(65, 22);
            lblShippingCostValue.TabIndex = 5;
            lblShippingCostValue.Text = "$12.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(25, 190);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 22);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Payable:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 3;
            label3.Text = "Discount (-):";
            // 
            // lblShippingCost
            // 
            lblShippingCost.AutoSize = true;
            lblShippingCost.ForeColor = SystemColors.ControlDarkDark;
            lblShippingCost.Location = new Point(25, 68);
            lblShippingCost.Name = "lblShippingCost";
            lblShippingCost.Size = new Size(157, 22);
            lblShippingCost.TabIndex = 2;
            lblShippingCost.Text = "Shipping Cost (+):";
            // 
            // lblSubotalPriceValue
            // 
            lblSubotalPriceValue.AutoSize = true;
            lblSubotalPriceValue.Location = new Point(204, 14);
            lblSubotalPriceValue.Name = "lblSubotalPriceValue";
            lblSubotalPriceValue.Size = new Size(85, 22);
            lblSubotalPriceValue.TabIndex = 1;
            lblSubotalPriceValue.Text = "$1096.00";
            // 
            // lblSubotalPrice
            // 
            lblSubotalPrice.AutoSize = true;
            lblSubotalPrice.ForeColor = SystemColors.ControlDarkDark;
            lblSubotalPrice.Location = new Point(25, 16);
            lblSubotalPrice.Name = "lblSubotalPrice";
            lblSubotalPrice.Size = new Size(123, 22);
            lblSubotalPrice.TabIndex = 0;
            lblSubotalPrice.Text = "Subotal Price:";
            // 
            // pnInformation
            // 
            pnInformation.Controls.Add(lblPhone);
            pnInformation.Controls.Add(label1);
            pnInformation.Controls.Add(lblAddressValue);
            pnInformation.Controls.Add(lblAddress);
            pnInformation.Controls.Add(lblNameValue);
            pnInformation.Controls.Add(lblName);
            pnInformation.Controls.Add(lblOrderCreated);
            pnInformation.Controls.Add(rbtnName);
            pnInformation.Controls.Add(rbtnContact);
            pnInformation.Controls.Add(rbtnAddress);
            pnInformation.Controls.Add(lblDate);
            pnInformation.Controls.Add(rbtnOrderDate);
            pnInformation.Location = new Point(3, 3);
            pnInformation.Name = "pnInformation";
            pnInformation.Size = new Size(957, 84);
            pnInformation.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.FromArgb(214, 243, 251);
            lblPhone.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(772, 46);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(102, 19);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "022-345-664";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(214, 243, 251);
            label1.Location = new Point(772, 17);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 12;
            label1.Text = "Contact NO";
            // 
            // lblAddressValue
            // 
            lblAddressValue.AutoSize = true;
            lblAddressValue.BackColor = Color.FromArgb(253, 243, 209);
            lblAddressValue.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressValue.Location = new Point(553, 46);
            lblAddressValue.Name = "lblAddressValue";
            lblAddressValue.Size = new Size(93, 19);
            lblAddressValue.TabIndex = 11;
            lblAddressValue.Text = "144, Hà Nội";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.FromArgb(253, 243, 209);
            lblAddress.Location = new Point(553, 17);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(76, 22);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.BackColor = Color.FromArgb(243, 216, 218);
            lblNameValue.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameValue.Location = new Point(318, 44);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(90, 19);
            lblNameValue.TabIndex = 9;
            lblNameValue.Text = "Phuong Anh";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(243, 216, 218);
            lblName.Location = new Point(318, 17);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 22);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblOrderCreated
            // 
            lblOrderCreated.AutoSize = true;
            lblOrderCreated.BackColor = Color.FromArgb(213, 230, 221);
            lblOrderCreated.Location = new Point(53, 17);
            lblOrderCreated.Name = "lblOrderCreated";
            lblOrderCreated.Size = new Size(147, 22);
            lblOrderCreated.TabIndex = 7;
            lblOrderCreated.Text = "Order Created At";
            // 
            // rbtnName
            // 
            rbtnName.BackColor = Color.FromArgb(243, 216, 218);
            rbtnName.BackgroundColor = Color.FromArgb(243, 216, 218);
            rbtnName.BorderColor = Color.FromArgb(231, 177, 182);
            rbtnName.BorderRadius = 10;
            rbtnName.BorderSize = 2;
            rbtnName.FlatAppearance.BorderSize = 0;
            rbtnName.FlatStyle = FlatStyle.Flat;
            rbtnName.ForeColor = Color.Black;
            rbtnName.Location = new Point(251, 8);
            rbtnName.Name = "rbtnName";
            rbtnName.Size = new Size(226, 69);
            rbtnName.TabIndex = 6;
            rbtnName.TextAlign = ContentAlignment.TopCenter;
            rbtnName.TextColor = Color.Black;
            rbtnName.UseVisualStyleBackColor = false;
            // 
            // rbtnContact
            // 
            rbtnContact.BackColor = Color.FromArgb(214, 243, 251);
            rbtnContact.BackgroundColor = Color.FromArgb(214, 243, 251);
            rbtnContact.BorderColor = Color.FromArgb(175, 232, 247);
            rbtnContact.BorderRadius = 10;
            rbtnContact.BorderSize = 2;
            rbtnContact.FlatAppearance.BorderSize = 0;
            rbtnContact.FlatStyle = FlatStyle.Flat;
            rbtnContact.ForeColor = Color.Black;
            rbtnContact.Location = new Point(722, 8);
            rbtnContact.Name = "rbtnContact";
            rbtnContact.Size = new Size(226, 69);
            rbtnContact.TabIndex = 5;
            rbtnContact.TextAlign = ContentAlignment.TopCenter;
            rbtnContact.TextColor = Color.Black;
            rbtnContact.UseVisualStyleBackColor = false;
            // 
            // rbtnAddress
            // 
            rbtnAddress.BackColor = Color.FromArgb(253, 243, 209);
            rbtnAddress.BackgroundColor = Color.FromArgb(253, 243, 209);
            rbtnAddress.BorderColor = Color.FromArgb(251, 231, 165);
            rbtnAddress.BorderRadius = 10;
            rbtnAddress.BorderSize = 2;
            rbtnAddress.FlatAppearance.BorderSize = 0;
            rbtnAddress.FlatStyle = FlatStyle.Flat;
            rbtnAddress.ForeColor = Color.Black;
            rbtnAddress.Location = new Point(490, 8);
            rbtnAddress.Name = "rbtnAddress";
            rbtnAddress.Size = new Size(226, 69);
            rbtnAddress.TabIndex = 4;
            rbtnAddress.TextAlign = ContentAlignment.TopCenter;
            rbtnAddress.TextColor = Color.Black;
            rbtnAddress.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(213, 230, 221);
            lblDate.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(47, 46);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(181, 19);
            lblDate.TabIndex = 3;
            lblDate.Text = "16/03/2021 at 04:23 PM";
            // 
            // rbtnOrderDate
            // 
            rbtnOrderDate.BackColor = Color.FromArgb(213, 230, 221);
            rbtnOrderDate.BackgroundColor = Color.FromArgb(213, 230, 221);
            rbtnOrderDate.BorderColor = Color.FromArgb(172, 206, 188);
            rbtnOrderDate.BorderRadius = 10;
            rbtnOrderDate.BorderSize = 2;
            rbtnOrderDate.FlatAppearance.BorderSize = 0;
            rbtnOrderDate.FlatStyle = FlatStyle.Flat;
            rbtnOrderDate.ForeColor = Color.Black;
            rbtnOrderDate.Location = new Point(8, 8);
            rbtnOrderDate.Name = "rbtnOrderDate";
            rbtnOrderDate.Size = new Size(226, 69);
            rbtnOrderDate.TabIndex = 2;
            rbtnOrderDate.TextAlign = ContentAlignment.TopCenter;
            rbtnOrderDate.TextColor = Color.Black;
            rbtnOrderDate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(213, 230, 221);
            pictureBox1.Image = Properties.Resources.CartIcon;
            pictureBox1.Location = new Point(30, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 37);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 251, 253);
            ClientSize = new Size(964, 538);
            Controls.Add(pnMain);
            Controls.Add(pnTitle);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OrderDetails";
            Text = "OrderDetails";
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            pnPage.ResumeLayout(false);
            pnList.ResumeLayout(false);
            pnList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            pnMain.ResumeLayout(false);
            pnPrice.ResumeLayout(false);
            pnPrice.PerformLayout();
            pnInformation.ResumeLayout(false);
            pnInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLine;
        private Panel pnTitle;
        private ComboBox cbxOrderId;
        private Label lblOrderId;
        private Label lblHeader;
        private Panel pnPage;
        private MyCustomControl.RJButton btnNext;
        private MyCustomControl.RJButton btnPre;
        private Panel pnList;
        private DataGridView gridView;
        private Panel pnMain;
        private Label lblDate;
        private PictureBox pictureBox1;
        private Panel pnInformation;
        private Label lblOrderCreated;
        private MyCustomControl.RJButton rbtnName;
        private MyCustomControl.RJButton rbtnContact;
        private MyCustomControl.RJButton rbtnAddress;
        private MyCustomControl.RJButton rbtnOrderDate;
        private Label lblNameValue;
        private Label lblName;
        private Label lblAddress;
        private Label lblAddressValue;
        private Label lblOrderSummary;
        private DataGridViewTextBoxColumn ProductImage;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private Label lblPhone;
        private Label label1;
        private Panel pnPrice;
        private Label lblTotal;
        private Label label3;
        private Label lblShippingCost;
        private Label lblSubotalPriceValue;
        private Label lblSubotalPrice;
        private Label lblShippingCostValue;
        private Label lblDiscountValue;
        private Panel pnLineShort;
        private Label lblTotalValue;
    }
}