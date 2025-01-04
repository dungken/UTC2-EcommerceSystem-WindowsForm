using Newtonsoft.Json;
using Source.Dtos.Product;
using Source.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Views.Custommer
{
    public partial class ProductDetails : Form
    {

        private readonly ProductService _productService;

        private readonly ProductDTO _product;
        public ProductDetails(ProductDTO product)
        {
            InitializeComponent();
            
            _productService = new ProductService();
            _product = product;
            LoadProductDetails();
        }
        private async void LoadProductDetails()
        {
            try
            {
                var response = await _productService.GetProductByIdAsync(_product.Id);
                if (response != null)
                {
                    // Assuming the response contains the product details.
                    lblName.Text = response.Data.Name;
                    lblPrice.Text = response.Data.Price.ToString("C");
                    
                }
                else
                {
                    MessageBox.Show("Không thể tải thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

