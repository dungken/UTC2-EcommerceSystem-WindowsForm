namespace Source.Views.Admin
{
    partial class CouponsAdd
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
            dateTimeStart = new DateTimePicker();
            rbtnInactive = new RadioButton();
            rbtnPending = new RadioButton();
            pnStatus = new Panel();
            rbtnActive = new RadioButton();
            lblStatus = new Label();
            tbxValue = new TextBox();
            lblValue = new Label();
            rbtnFixedAmount = new RadioButton();
            rbtnPercentage = new RadioButton();
            rbtnFree = new RadioButton();
            lblCouponType = new Label();
            cbxProduct = new ComboBox();
            lblProduct = new Label();
            tbxId = new TextBox();
            tbxLimit = new TextBox();
            lblId = new Label();
            pnLine = new Panel();
            btnSave = new MyCustomControl.RJButton();
            pnTitle = new Panel();
            lblHeader = new Label();
            lblLimit = new Label();
            dateTimeEnd = new DateTimePicker();
            pnDateSchedule = new Panel();
            lblEnd = new Label();
            lblStart = new Label();
            lblDateSchedule = new Label();
            pnInformation = new Panel();
            tbxName = new TextBox();
            lblName = new Label();
            lblBasic = new Label();
            pnStatus.SuspendLayout();
            pnTitle.SuspendLayout();
            pnDateSchedule.SuspendLayout();
            pnInformation.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(13, 82);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(250, 30);
            dateTimeStart.TabIndex = 2;
            // 
            // rbtnInactive
            // 
            rbtnInactive.AutoSize = true;
            rbtnInactive.Location = new Point(22, 101);
            rbtnInactive.Name = "rbtnInactive";
            rbtnInactive.Size = new Size(94, 26);
            rbtnInactive.TabIndex = 2;
            rbtnInactive.TabStop = true;
            rbtnInactive.Text = "Inactive";
            rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnPending
            // 
            rbtnPending.AutoSize = true;
            rbtnPending.Location = new Point(22, 149);
            rbtnPending.Name = "rbtnPending";
            rbtnPending.Size = new Size(94, 26);
            rbtnPending.TabIndex = 1;
            rbtnPending.TabStop = true;
            rbtnPending.Text = "Pending";
            rbtnPending.UseVisualStyleBackColor = true;
            // 
            // pnStatus
            // 
            pnStatus.BackColor = Color.White;
            pnStatus.Controls.Add(rbtnActive);
            pnStatus.Controls.Add(rbtnInactive);
            pnStatus.Controls.Add(rbtnPending);
            pnStatus.Controls.Add(lblStatus);
            pnStatus.Location = new Point(12, 122);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(314, 178);
            pnStatus.TabIndex = 14;
            // 
            // rbtnActive
            // 
            rbtnActive.AutoSize = true;
            rbtnActive.Location = new Point(22, 54);
            rbtnActive.Name = "rbtnActive";
            rbtnActive.Size = new Size(84, 26);
            rbtnActive.TabIndex = 3;
            rbtnActive.TabStop = true;
            rbtnActive.Text = "Active";
            rbtnActive.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Cursor = Cursors.IBeam;
            lblStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(13, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(161, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Coupon Status";
            // 
            // tbxValue
            // 
            tbxValue.Location = new Point(417, 190);
            tbxValue.Name = "tbxValue";
            tbxValue.Size = new Size(166, 30);
            tbxValue.TabIndex = 14;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Cursor = Cursors.IBeam;
            lblValue.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValue.Location = new Point(253, 197);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(135, 23);
            lblValue.TabIndex = 13;
            lblValue.Text = "Discount Value";
            // 
            // rbtnFixedAmount
            // 
            rbtnFixedAmount.AutoSize = true;
            rbtnFixedAmount.Location = new Point(26, 342);
            rbtnFixedAmount.Name = "rbtnFixedAmount";
            rbtnFixedAmount.Size = new Size(141, 26);
            rbtnFixedAmount.TabIndex = 12;
            rbtnFixedAmount.TabStop = true;
            rbtnFixedAmount.Text = "Fixed Amount";
            rbtnFixedAmount.UseVisualStyleBackColor = true;
            // 
            // rbtnPercentage
            // 
            rbtnPercentage.AutoSize = true;
            rbtnPercentage.Location = new Point(26, 292);
            rbtnPercentage.Name = "rbtnPercentage";
            rbtnPercentage.Size = new Size(117, 26);
            rbtnPercentage.TabIndex = 11;
            rbtnPercentage.TabStop = true;
            rbtnPercentage.Text = "Percentage";
            rbtnPercentage.UseVisualStyleBackColor = true;
            // 
            // rbtnFree
            // 
            rbtnFree.AutoSize = true;
            rbtnFree.Location = new Point(26, 240);
            rbtnFree.Name = "rbtnFree";
            rbtnFree.Size = new Size(142, 26);
            rbtnFree.TabIndex = 10;
            rbtnFree.TabStop = true;
            rbtnFree.Text = "Free Shipping";
            rbtnFree.UseVisualStyleBackColor = true;
            // 
            // lblCouponType
            // 
            lblCouponType.AutoSize = true;
            lblCouponType.Cursor = Cursors.IBeam;
            lblCouponType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCouponType.Location = new Point(19, 197);
            lblCouponType.Name = "lblCouponType";
            lblCouponType.Size = new Size(137, 23);
            lblCouponType.TabIndex = 9;
            lblCouponType.Text = "Coupons Types";
            // 
            // cbxProduct
            // 
            cbxProduct.FormattingEnabled = true;
            cbxProduct.Location = new Point(417, 55);
            cbxProduct.Name = "cbxProduct";
            cbxProduct.Size = new Size(166, 30);
            cbxProduct.TabIndex = 8;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Cursor = Cursors.IBeam;
            lblProduct.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(321, 62);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(76, 23);
            lblProduct.TabIndex = 7;
            lblProduct.Text = "Product";
            // 
            // tbxId
            // 
            tbxId.Location = new Point(118, 55);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(166, 30);
            tbxId.TabIndex = 6;
            // 
            // tbxLimit
            // 
            tbxLimit.Location = new Point(417, 118);
            tbxLimit.Name = "tbxLimit";
            tbxLimit.Size = new Size(166, 30);
            tbxLimit.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Cursor = Cursors.IBeam;
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(42, 57);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 23);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.Silver;
            pnLine.ForeColor = SystemColors.ActiveCaptionText;
            pnLine.Location = new Point(12, 90);
            pnLine.Margin = new Padding(2, 3, 2, 3);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(940, 10);
            pnLine.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSlateBlue;
            btnSave.BackgroundColor = Color.MediumSlateBlue;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(807, 24);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(pnLine);
            pnTitle.Controls.Add(btnSave);
            pnTitle.Controls.Add(lblHeader);
            pnTitle.Location = new Point(0, 16);
            pnTitle.Margin = new Padding(2, 3, 2, 3);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(964, 91);
            pnTitle.TabIndex = 13;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Cursor = Cursors.IBeam;
            lblHeader.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(23, 27);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(189, 35);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Coupons Add";
            // 
            // lblLimit
            // 
            lblLimit.AutoSize = true;
            lblLimit.Cursor = Cursors.IBeam;
            lblLimit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimit.Location = new Point(333, 118);
            lblLimit.Name = "lblLimit";
            lblLimit.Size = new Size(55, 23);
            lblLimit.TabIndex = 3;
            lblLimit.Text = "Limit";
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(13, 156);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(250, 30);
            dateTimeEnd.TabIndex = 4;
            // 
            // pnDateSchedule
            // 
            pnDateSchedule.BackColor = Color.White;
            pnDateSchedule.Controls.Add(dateTimeEnd);
            pnDateSchedule.Controls.Add(lblEnd);
            pnDateSchedule.Controls.Add(dateTimeStart);
            pnDateSchedule.Controls.Add(lblStart);
            pnDateSchedule.Controls.Add(lblDateSchedule);
            pnDateSchedule.Location = new Point(12, 319);
            pnDateSchedule.Name = "pnDateSchedule";
            pnDateSchedule.Size = new Size(314, 203);
            pnDateSchedule.TabIndex = 15;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Cursor = Cursors.IBeam;
            lblEnd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnd.Location = new Point(17, 124);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(89, 23);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "End Date";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Cursor = Cursors.IBeam;
            lblStart.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStart.Location = new Point(13, 46);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(99, 23);
            lblStart.TabIndex = 1;
            lblStart.Text = "Start Date";
            // 
            // lblDateSchedule
            // 
            lblDateSchedule.AutoSize = true;
            lblDateSchedule.Cursor = Cursors.IBeam;
            lblDateSchedule.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateSchedule.Location = new Point(13, 10);
            lblDateSchedule.Name = "lblDateSchedule";
            lblDateSchedule.Size = new Size(156, 25);
            lblDateSchedule.TabIndex = 0;
            lblDateSchedule.Text = "Date Schedule";
            // 
            // pnInformation
            // 
            pnInformation.BackColor = Color.White;
            pnInformation.Controls.Add(tbxValue);
            pnInformation.Controls.Add(lblValue);
            pnInformation.Controls.Add(rbtnFixedAmount);
            pnInformation.Controls.Add(rbtnPercentage);
            pnInformation.Controls.Add(rbtnFree);
            pnInformation.Controls.Add(lblCouponType);
            pnInformation.Controls.Add(cbxProduct);
            pnInformation.Controls.Add(lblProduct);
            pnInformation.Controls.Add(tbxId);
            pnInformation.Controls.Add(tbxLimit);
            pnInformation.Controls.Add(lblId);
            pnInformation.Controls.Add(lblLimit);
            pnInformation.Controls.Add(tbxName);
            pnInformation.Controls.Add(lblName);
            pnInformation.Controls.Add(lblBasic);
            pnInformation.Location = new Point(336, 122);
            pnInformation.Name = "pnInformation";
            pnInformation.Size = new Size(616, 400);
            pnInformation.TabIndex = 16;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(118, 116);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(166, 30);
            tbxName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Cursor = Cursors.IBeam;
            lblName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(19, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblBasic
            // 
            lblBasic.AutoSize = true;
            lblBasic.Cursor = Cursors.IBeam;
            lblBasic.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasic.Location = new Point(19, 14);
            lblBasic.Name = "lblBasic";
            lblBasic.Size = new Size(215, 25);
            lblBasic.TabIndex = 0;
            lblBasic.Text = "Coupon information";
            // 
            // CouponsAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 251, 253);
            ClientSize = new Size(964, 538);
            Controls.Add(pnStatus);
            Controls.Add(pnTitle);
            Controls.Add(pnDateSchedule);
            Controls.Add(pnInformation);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CouponsAdd";
            Text = "CouponsAdd";
            pnStatus.ResumeLayout(false);
            pnStatus.PerformLayout();
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            pnDateSchedule.ResumeLayout(false);
            pnDateSchedule.PerformLayout();
            pnInformation.ResumeLayout(false);
            pnInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimeStart;
        private RadioButton rbtnInactive;
        private RadioButton rbtnPending;
        private Panel pnStatus;
        private RadioButton rbtnActive;
        private Label lblStatus;
        private TextBox tbxValue;
        private Label lblValue;
        private RadioButton rbtnFixedAmount;
        private RadioButton rbtnPercentage;
        private RadioButton rbtnFree;
        private Label lblCouponType;
        private ComboBox cbxProduct;
        private Label lblProduct;
        private TextBox tbxId;
        private TextBox tbxLimit;
        private Label lblId;
        private Panel pnLine;
        private MyCustomControl.RJButton btnSave;
        private Panel pnTitle;
        private Label lblHeader;
        private Label lblLimit;
        private DateTimePicker dateTimeEnd;
        private Panel pnDateSchedule;
        private Label lblEnd;
        private Label lblStart;
        private Label lblDateSchedule;
        private Panel pnInformation;
        private TextBox tbxName;
        private Label lblName;
        private Label lblBasic;
    }
}