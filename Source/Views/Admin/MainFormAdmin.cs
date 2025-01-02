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
namespace Source.Views
{
    public partial class MainFormAdmin : Form
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        private readonly ProductService _productService;

        //private FormsPlot plt;
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

        public void LoadData()
        {
            //lblCustomerV = _userService.GetAllUser().Result.Data.Users.Where(s => s.UserRoles.Name == "User")
            lblOrderV.Text = _orderService.GetAllOrdersAsync().Result.Data.Count().ToString();

            var responeOrder = _orderService.GetAllOrdersAsync().Result.Data.ToList().Select(s => s.TotalAmount);
            decimal totalSale = 0;
            foreach (var order in responeOrder)
            {
                totalSale += order;
            }

            lblTotalSaleV.Text = totalSale.ToString();

            lblAvgSaleV.Text = (totalSale / int.Parse(lblOrderV.Text)).ToString();

            lblTotalProductV.Text = _productService.GetAllProductsAsync().Result.Data.Count().ToString();


        }

        public void Draw()
        {
        

            //// Tạo ScottPlot control
            //var plt = new FormsPlot
            //{
            //    Dock = DockStyle.Fill
            //};
            //this.Controls.Add(plt);

            //// Dữ liệu biểu đồ
            //double[] xs = { 1, 2, 3, 4, 5 }; // Giá trị trên trục X
            //double[] ys = { 5, 10, 8, 12, 7 }; // Giá trị trên trục Y

            //// Thêm biểu đồ dạng scatter (điểm nối với nhau bằng đường thẳng)
            //plt.Plot.AddScatter(xs, ys, color: System.Drawing.Color.Blue, label: "Đơn hàng");

            //// Thêm tiêu đề và chú thích
            //plt.Plot.Title("Thống Kê Đơn Hàng");
            //plt.Plot.XLabel("Ngày");
            //plt.Plot.YLabel("Số Lượng Đơn Hàng");
            //plt.Plot.Legend(location: ScottPlot.Alignment.LowerRight);

            //// Tùy chỉnh trục
            //plt.Plot.SetAxisLimits(yMin: 0, yMax: 15);

            //// Làm mới biểu đồ để hiển thị
            //plt.Refresh();

        }
    }
}
