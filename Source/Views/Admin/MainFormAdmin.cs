using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Service;
using ScottPlot;
using Source.Views.Admin;
using Source.Views.Custommer;
namespace Source.Views
{
    public partial class MainFormAdmin : Form
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        private readonly ProductService _productService;

        public static int frmAdminMainFormLocationX, frmAdminMainFormLocationY;
        public static int pnlChildFormMainLocationX, pnlChildFormMainLocationY;
        public static int frmWith, frmHeight;
        public MainFormAdmin()
        {
            InitializeComponent();
            _userService = new UserService();
            _orderService = new OrderService();
            _productService = new ProductService();

            LoadData();

            // Tạo ScottPlot control
            //plt = new FormsPlot
            //{
            //    Dock = DockStyle.Fill
            //};
            //this.Controls.Add(plt);

            //// Tải dữ liệu đơn hàng
            //LoadSampleOrders();

            //// Thống kê và hiển thị doanh thu theo tháng
            //var monthlyData = GetRevenueByMonth(_orders);
            //DisplayChart(monthlyData, "Thống Kê Doanh Thu Theo Tháng");

        }

        public async void LoadData()
        {
            //lblCustomerV.Text = _userService.GetAllUser().Result.Data.Users.
            //    Select(user => user.UserRoles.
            //    FirstOrDefault(role => role.Name == "User")).Count().ToString();
            //lblOrderV.Text = _orderService.GetAllOrdersAsync().Result.Data.Count().ToString();

            //var responeOrder = _orderService.GetAllOrdersAsync().Result.Data.ToList().
            //    Select(s => s.TotalAmount);
            //decimal totalSale = 0;
            //foreach (var order in responeOrder)
            //{
            //    totalSale += order;
            //}

            //lblTotalSaleV.Text = totalSale.ToString();

            //lblAvgSaleV.Text = (totalSale / int.Parse(lblOrderV.Text)).ToString();

            //int product = _productService.GetAllProductsAsync().Result.Data.Count();
            //lblTotalProductV.Text = product.ToString();

            //lblAvgItemSale.Text = (totalSale/product).ToString();
        }

        // Tạo Form con 
        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            frmAdminMainFormLocationX = Login.frmLoginLocationX;
            frmAdminMainFormLocationY = Login.frmLoginLocationY;
            frmHeight = Login.frmHeight;
            frmWith = Login.frmWith;
            pnlChildFormMainLocationX = pnlChildForm.Location.X;
            pnlChildFormMainLocationY = pnlChildForm.Location.Y;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm2.Controls.Add(childForm);
            pnlChildForm2.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductList());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryList());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new OrdersList());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomersList());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            openChildForm(new VouchersList());
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            openChildForm(new DiscountsList());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new Setting());
        }
    }
}
