namespace Source.Views
{
    partial class MainFormAdmin
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
            lblNavigation = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            btnProducts = new Button();
            btnHome = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnCategories = new Button();
            panel3 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel4 = new Panel();
            pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            lblNavigationImage = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pnlChildForm = new Panel();
            label7 = new Label();
            lblNotifications = new Label();
            lblAvarata = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            btnSale = new Button();
            btnInventory = new Button();
            btnSetting = new Button();
            btnLogOut = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblNavigation
            // 
            lblNavigation.AutoSize = true;
            lblNavigation.ForeColor = Color.Transparent;
            lblNavigation.Location = new Point(75, 38);
            lblNavigation.Name = "lblNavigation";
            lblNavigation.Size = new Size(51, 20);
            lblNavigation.TabIndex = 7;
            lblNavigation.Text = "Home";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search products";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(730, 26);
            label5.Name = "label5";
            label5.Size = new Size(32, 40);
            label5.TabIndex = 4;
            label5.Text = "          ";
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = Properties.Resources._45506_box_delivery_package_product_shipment_icon;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 131);
            btnProducts.Margin = new Padding(4, 3, 4, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(221, 50);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "         Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 81);
            btnHome.Margin = new Padding(4, 3, 4, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(221, 50);
            btnHome.TabIndex = 1;
            btnHome.Text = "         Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label6
            // 
            label6.Location = new Point(493, 26);
            label6.Name = "label6";
            label6.Size = new Size(50, 40);
            label6.TabIndex = 4;
            label6.Text = "          ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(831, 46);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(836, 26);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Location = new Point(639, 26);
            label2.Name = "label2";
            label2.Size = new Size(42, 40);
            label2.TabIndex = 3;
            label2.Text = "          ";
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 281);
            btnCustomers.Margin = new Padding(4, 3, 4, 3);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(221, 50);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "         Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnOrders.ForeColor = Color.White;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 231);
            btnOrders.Margin = new Padding(4, 3, 4, 3);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(221, 50);
            btnOrders.TabIndex = 7;
            btnOrders.Text = "         Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(0, 181);
            btnCategories.Margin = new Padding(4, 3, 4, 3);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(221, 50);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "         Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(162, 185, 237);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(221, 578);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 50);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(893, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 0;
            label1.Text = "          ";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBoxLogo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 81);
            panel4.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(0, 1);
            pictureBoxLogo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(218, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(162, 185, 237);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblAvarata);
            panel2.Controls.Add(lblNotifications);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblNavigationImage);
            panel2.Controls.Add(lblNavigation);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(221, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 77);
            panel2.TabIndex = 5;
            // 
            // lblNavigationImage
            // 
            lblNavigationImage.Location = new Point(7, 26);
            lblNavigationImage.Name = "lblNavigationImage";
            lblNavigationImage.Size = new Size(50, 40);
            lblNavigationImage.TabIndex = 8;
            lblNavigationImage.Text = "          ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(349, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(154, 156, 233);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnSetting);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnSale);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 628);
            panel1.TabIndex = 4;
            // 
            // pnlChildForm
            // 
            pnlChildForm.Controls.Add(pictureBox1);
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Location = new Point(0, 0);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1203, 628);
            pnlChildForm.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Image = Properties.Resources.circle;
            label7.Location = new Point(730, 26);
            label7.Name = "label7";
            label7.Size = new Size(42, 40);
            label7.TabIndex = 9;
            label7.Text = "          ";
            // 
            // lblNotifications
            // 
            lblNotifications.Anchor = AnchorStyles.Right;
            lblNotifications.Image = Properties.Resources.bell;
            lblNotifications.Location = new Point(784, 26);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(32, 40);
            lblNotifications.TabIndex = 10;
            lblNotifications.Text = "          ";
            // 
            // lblAvarata
            // 
            lblAvarata.Anchor = AnchorStyles.Right;
            lblAvarata.Cursor = Cursors.Hand;
            lblAvarata.Image = Properties.Resources.ImageAvarata;
            lblAvarata.Location = new Point(908, 26);
            lblAvarata.Name = "lblAvarata";
            lblAvarata.Size = new Size(42, 40);
            lblAvarata.TabIndex = 11;
            lblAvarata.Text = "          ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.imagesHome;
            pictureBox2.Location = new Point(639, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.Image = Properties.Resources.icon_home;
            label8.Location = new Point(19, 26);
            label8.Name = "label8";
            label8.Size = new Size(50, 40);
            label8.TabIndex = 13;
            label8.Text = "          ";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources.logo;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(218, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSale.ForeColor = Color.White;
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(0, 331);
            btnSale.Margin = new Padding(4, 3, 4, 3);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(221, 50);
            btnSale.TabIndex = 9;
            btnSale.Text = "         Sales Promotion";
            btnSale.TextAlign = ContentAlignment.MiddleLeft;
            btnSale.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 381);
            btnInventory.Margin = new Padding(4, 3, 4, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(221, 50);
            btnInventory.TabIndex = 10;
            btnInventory.Text = "         Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = Properties.Resources.icon_setting;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 431);
            btnSetting.Margin = new Padding(4, 3, 4, 3);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(221, 50);
            btnSetting.TabIndex = 11;
            btnSetting.Text = "         Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = Properties.Resources.icon_exit;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 578);
            btnLogOut.Margin = new Padding(4, 3, 4, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(221, 50);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "         Log out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // MainFormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 628);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlChildForm);
            Name = "MainFormAdmin";
            Text = "MainFormAdmin";
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNavigation;
        private TextBox textBox1;
        private Label label5;
        private Button btnProducts;
        private Button btnHome;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnCategories;
        private Panel panel3;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel4;
        private PictureBox pictureBoxLogo;
        private Panel panel2;
        private Label lblNavigationImage;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel pnlChildForm;
        private Label label7;
        private Label lblNotifications;
        private Label lblAvarata;
        private PictureBox pictureBox2;
        private Label label8;
        private PictureBox pictureBox3;
        private Button btnInventory;
        private Button btnSale;
        private Button btnSetting;
        private Button btnLogOut;
    }
}