using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Dtos.Image;
using Source.Dtos.Order;
using Source.Dtos.Payment;
using Source.Dtos.Product;
using Source.Dtos.Role;
using Source.Service;
using Source.Views.Admin;

namespace Source.Views
{
    public partial class PhuongAnh_Test : Form
    {
        private readonly ImageService _imageService;
        private readonly OrderService _orderService;
        private readonly ProductService _productService;
        private readonly PaymentService _paymentService;
        private readonly PermissionService _permissionService;
        public PhuongAnh_Test()
        {
            InitializeComponent();
            _imageService = new ImageService();
            _orderService = new OrderService();
            _productService = new ProductService();
            _paymentService = new PaymentService();
            _permissionService = new PermissionService();
        }
        // Test Image Service
        private async void TestUploadMultipleImages()
        {
            
        }
        private async void TestGetImagesByProductId()
        {
            string s = "AB3A1D7B-23A7-45BD-9E75-1EA2640F9D2B";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _imageService.GetImagesByProductId(guid);
            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.Url}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestUpdateImages()
        {

        }
        private async void TestDeleteImage()
        {
            string s = "9EAABDF5-9676-490F-AA74-30EFEBFC7654";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _imageService.DeleteImage(guid);
            if (registerResponse == true)
            {
                MessageBox.Show($"Registration Successful\nMessage:");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError:");
            }
        }
        // Test Order Service
        private async void TestCreateOrder()
        {
            //CreateOrderDto orderDto = new CreateOrderDto
            //{
            //    OrderDetails = new List<CreateOrderDetailDto>(),
            //    Status = "Pending",
            //    TotalAmount = 0
            //};

            //// Tạo chi tiết đơn hàng
            //CreateOrderDetailDto orderDetailDto = new CreateOrderDetailDto
            //{
            //    ProductId = Guid.Parse("DD3A1D7B-23A7-45BD-9E75-1EA2640F9D2D"),
            //    Quantity = 99,
            //    UnitPrice = 564.65m,
            //    DiscountAmount = 0.2m
            //};

            //// Thêm chi tiết đơn hàng và cập nhật tổng số tiền
            //orderDto.OrderDetails.Add(orderDetailDto);
            //orderDto.TotalAmount += orderDetailDto.Quantity * orderDetailDto.UnitPrice - orderDetailDto.DiscountAmount;

            //var registerResponse = await _orderService.CreateOrder(orderDto);
            //if (registerResponse != null && registerResponse.Success)
            //{
            //    MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}");
            //}
            //else
            //{
            //    MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            //}


            CreateOrderDto orderDto = new CreateOrderDto
            {
                Status = "Pending",
                TotalAmount = 0, // Sẽ được tính toán từ OrderDetails
                OrderDetails = new List<CreateOrderDetailDto>
                {
                    new CreateOrderDetailDto
                    {
                        ProductId = Guid.Parse("AB3A1D7B-23A7-45BD-9E75-1EA2640F9D1A"),
                        Quantity = 2,
                        UnitPrice = 100m,
                        DiscountAmount = 10m
                    },
                    new CreateOrderDetailDto
                    {
                        ProductId = Guid.Parse("AB3A1D7B-23A7-45BD-9E75-1EA2640F9D2B"),
                        Quantity = 1,
                        UnitPrice = 200m,
                        DiscountAmount = 20m
                    }
                }
            };
            //foreach (var detail in orderDto.OrderDetails)
            //{
            //    // Giả sử có một phương thức để lấy thông tin sản phẩm
            //    var product = await _productService.GetProductByIdAsync(detail.ProductId);
            //    if (product != null)
            //    {
            //        detail.UnitPrice = product.Data.Price; // Gán giá sản phẩm
            //    }
            //    else
            //    {
            //        throw new Exception($"Product with ID {detail.ProductId} not found.");
            //    }
            //}

            // Tính tổng tiền
            orderDto.TotalAmount = orderDto.OrderDetails.Sum(d => (d.UnitPrice * d.Quantity) - d.DiscountAmount);

            var registerResponse = await _orderService.CreateOrder(orderDto);

            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.TotalAmount}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestGetOrderById()
        {
            string s = "0C03C7F7-525E-4493-BEF9-4A8863D64D82";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _orderService.GetOrderById(guid);
            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.OrderDate}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestGetAllOrders()
        {
            var registerResponse = await _orderService.GetAllOrders();
            if (registerResponse != null && registerResponse.Success)
            {
                var orderIds = registerResponse.Data.Select(item => item.Id).ToList();
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nOrder IDs: {string.Join("\n ", orderIds)}");
            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestUpdateOrderStatus()
        {
            string s = "C4585F87-368E-4577-B96B-43DC8033E0CC";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _orderService.UpdateOrderStatus(guid, "Completed");
            if (registerResponse != null)
            {
                MessageBox.Show($"Successful\nMessage: {registerResponse}");

            }
            else
            {
                MessageBox.Show($"Failed\nError: { registerResponse}");
            }
        }
        private async void TestCreatePayment()
        {
            CreatePaymentDto paymentDto = new CreatePaymentDto()
            {
                OrderId = Guid.Parse("FB2EE1A1-5E43-4419-AFF6-09F80DD016F4"),
                Amount = 16.6m,
                PaymentMethod = "TienMat"
            };
            var registerResponse = await _paymentService.CreatePayment(paymentDto);

            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.OrderId}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }

        }
        private async void TestGetPaymentByOrderId()
        {
            string s = "5451221C-1148-4739-81B9-05E6DC3C62DF";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _paymentService.GetPaymentByOrderId(guid);
            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.Id}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestGetPermissions()
        {
            var registerResponse = await _permissionService.GetPermissions();
            if (registerResponse != null && registerResponse.Success)
            {
                //if (registerResponse.Data.permissionList == null)
                //{
                //    MessageBox.Show("Bi null Data");
                //}
                //else
                //{

                    MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.Count()}");
                //}

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestGetPermissionsWithRoles()
        {
            var registerResponse = await _permissionService.GetPermissionsWithRoles();
            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.PermissionName}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestGetById()
        {
            string s = "39A94C5C-85F2-427D-99A9-08DD0207DCCF";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _permissionService.GetById(guid);
            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.Name}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }
        }
        private async void TestCreateOrUpdatePermission()
        {
            CreatePermissionDto permissionDto = new CreatePermissionDto()
            {
                PermissionId = new Guid(),
                Name = "create_category",
                Description = "create category",
                IsCorePermission = false,
            };
            var registerResponse = await _permissionService.CreateOrUpdatePermission(permissionDto);

            if (registerResponse != null && registerResponse.Success)
            {
                MessageBox.Show($"Registration Successful\nMessage: {registerResponse.Message}\nUser: {registerResponse.Data.Name}");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError: {string.Join(", ", registerResponse.Errors)}");
            }

        }
        private async void TestDeletePermission()
        {
            string s = "A8FA42D4-E4BA-415D-A8E5-F758864FADD0";
            Guid guid = Guid.Parse(s);
            var registerResponse = await _permissionService.DeletePermission(guid);
            if (registerResponse == true)
            {
                MessageBox.Show($"Registration Successful\nMessage:");

            }
            else
            {
                MessageBox.Show($"Registration Failed\nError:");
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            //TestUploadMultipleImages();  // chua lam duoc do co IFormFile[]
            //TestGetImagesByProductId();
            //TestUpdateImages();  // chua lam duoc do co IFormFile[]
            //TestDeleteImage();

            //TestCreateOrder();
            //TestGetOrderById();
            //TestGetAllOrders();  
            TestUpdateOrderStatus();         //loi lay ra duoc ma khong dinh dang duoc

            //TestCreatePayment(); // Them duoc ma bao loi j a
            //TestGetPaymentByOrderId();

            //TestGetPermissions();           //loi lay ra duoc ma khong dinh dang duoc
            //TestGetPermissionsWithRoles(); //loi lay ra duoc ma khong dinh dang duoc
            //TestGetById();
            //TestCreateOrUpdatePermission();
            //TestDeletePermission();
        }
    }
}
