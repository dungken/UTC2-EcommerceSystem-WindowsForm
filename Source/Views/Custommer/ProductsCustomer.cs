using Source.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;
using Image = System.Windows.Controls.Image;
using Label = System.Windows.Forms.Label;
using Panel = System.Windows.Forms.Panel;

namespace Source.Views.Custommer
{
    public partial class ProductsCustomer : Form
    {
        private readonly ProductService _productService;
        private readonly CategoriesService _categoryService;
        private List<Source.Dtos.Product.ProductDTO> _products; // Danh sách sản phẩm DTO

        public ProductsCustomer()
        {
            InitializeComponent();
            btnDecrease.Enabled = false;
            _productService = new ProductService();
            _categoryService = new CategoriesService();
        }

        private void changeInforMain(Panel panela)
        {
            // Lấy các Label cần thiết
            var nameLabel = panela.Controls.OfType<Label>().FirstOrDefault(l => l.Name.Contains("Name"));
            var priceLabel = panela.Controls.OfType<Label>().FirstOrDefault(l => l.Name.Contains("Price"));
            var categoryLabel = panela.Controls.OfType<Label>().FirstOrDefault(l => l.Name.Contains("Cate"));

            // Lấy PictureBox (nếu có)
            var pictureBox = panela.Controls.OfType<PictureBox>().FirstOrDefault();

            // Gán thông tin từ các Label
            if (nameLabel != null)
            {
                lblNameMain.Text = nameLabel.Text;
            }

            if (priceLabel != null)
            {
                lblPriceMain.Text = priceLabel.Text;
            }

            if (categoryLabel != null)
            {
                lblCategoryMain.Text = categoryLabel.Text;
            }

            // Gán hình ảnh nếu có
            if (pictureBox != null && pictureBox.Image != null)
            {
                pictureBoxMain.Image = pictureBox.Image;
                pictureBoxMain.Visible = true;
            }
            else
            {
                pictureBoxMain.Image = null;
                pictureBoxMain.Visible = false;
            }
        }


        private void pnlProduct1_Click(object sender, EventArgs e)
        {
            changeInforMain(pnlProduct1);
        }

        private void pnlProduct2_Click(object sender, EventArgs e)
        {
            changeInforMain(pnlProduct2);
        }

        private void pnlProduct3_Click(object sender, EventArgs e)
        {
            changeInforMain(pnlProduct3);
        }

        private void pnlProduct4_Click(object sender, EventArgs e)
        {
            changeInforMain(pnlProduct4);
        }

        private void pnlProduct5_Click(object sender, EventArgs e)
        {
            changeInforMain(pnlProduct5);
        }

        private void pnlProduct6_Click(object sender, EventArgs e)
        {
            changeInforMain(pnlProduct6);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblQuantity.Text) > 1)
            {
                lblQuantity.Text = Convert.ToString(Convert.ToInt32(lblQuantity.Text) - 1);
            }
            if (Convert.ToInt32(lblQuantity.Text) == 1)
            {
                btnDecrease.Enabled = false;
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            btnDecrease.Enabled = true;
            lblQuantity.Text = Convert.ToString(Convert.ToInt32(lblQuantity.Text) + 1);
        }

        private async void ProductsCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                var response = await _productService.GetAllProductsAsync();
                if (response.Success)
                {
                    _products = response.Data.ToList(); // Lấy tất cả sản phẩm từ API
                    DisplayAllProducts(); // Hiển thị tất cả sản phẩm
                }
                else
                {
                    MessageBox.Show($"Lỗi khi tải sản phẩm: {response.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DisplayAllProducts()
        {
            ClearProductPanels();

            if (_products == null || !_products.Any())
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.");
                return;
            }

            for (int i = 0; i < _products.Count; i++)
            {
                var product = _products[i];
                var panel = GetProductPanel(i + 1);

                if (panel == null)
                {
                    MessageBox.Show($"Panel {i + 1} không tồn tại.");
                    continue;
                }

                var nameLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblNameProduct{i + 1}");
                var priceLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblPriceProduct{i + 1}");
                var categoryLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblCateProduct{i + 1}");

                // Hiển thị tên sản phẩm
                if (nameLabel != null)
                    nameLabel.Text = product.Name;

                // Hiển thị giá sản phẩm
                if (priceLabel != null)
                    priceLabel.Text = product.Price.ToString("N0");

                // Hiển thị danh mục sản phẩm
                if (categoryLabel != null)
                {
                    try
                    {

                        var category = await _categoryService.GetCategoryByIdAsync(product.CategoryId);
                        categoryLabel.Text = category?.Data?.Name ?? "Unknown Category";
                    }
                    catch (Exception ex)
                    {
                        categoryLabel.Text = "Error fetching";
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                panel.Visible = true;
            }
        }





        private void ClearProductPanels()
        {
            // Ẩn tất cả các panel và xóa thông tin cũ
            for (int i = 1; i <= 6; i++)
            {
                var panel = GetProductPanel(i);
                if (panel != null)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        if (ctrl is Label label)
                            label.Text = string.Empty;
                    }
                    panel.Visible = false;
                }
            }
        }

        private Panel GetProductPanel(int position)
        {
            switch (position)
            {
                case 1: return pnlProduct1;
                case 2: return pnlProduct2;
                case 3: return pnlProduct3;
                case 4: return pnlProduct4;
                case 5: return pnlProduct5;
                case 6: return pnlProduct6;
                default: return null;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var search = tbxSearch.Text;
        }


    }
}
