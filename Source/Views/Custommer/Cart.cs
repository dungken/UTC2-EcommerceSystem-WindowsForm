using Source.Models;
using Source.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Views.Custommer
{
    public partial class Cart : Form
    {
        private readonly CartService _cartService;
        private readonly UserService _userService;
        private readonly ProductService _productService;
        private readonly DiscountsService _discountService;
        public Cart()
        {
            InitializeComponent();
            _cartService = new CartService();
            _userService = new UserService();
            _productService = new ProductService();
            _discountService = new DiscountsService();
        }

        private void pnProduct_Paint(object sender, PaintEventArgs e)
        {

        }
        // Tạo Form con 
        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlCart.Controls.Add(childForm);
            pnlCart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            openChildForm(new PaymentCustomer());
        }
        private Panel ClonePanel(Panel original, CartItem item)
        {
            var clonedPanel = new Panel
            {
                Width = original.Width,
                Height = original.Height,
                BorderStyle = original.BorderStyle,
                Dock = original.Dock,
                BackColor = original.BackColor,
                Margin = original.Margin,
                Padding = original.Padding
            };

            foreach (Control control in original.Controls)
            {
                Control clonedControl = null;

                if (control is Label label)
                {
                    clonedControl = new Label
                    {
                        Text = label.Text,
                        Location = label.Location,
                        Size = label.Size,
                        Font = label.Font,
                        ForeColor = label.ForeColor,
                        BackColor = label.BackColor,
                        Name = label.Name // Sao chép thuộc tính Name
                    };
                    if (label.Name == "lblDelete")
                    {
                        clonedControl.Click += lblDelete_Click;
                        clonedControl.Tag = item;
                    }
                }
                else if (control is PictureBox pictureBox)
                {
                    clonedControl = new PictureBox
                    {
                        Image = pictureBox.Image,
                        Location = pictureBox.Location,
                        Size = pictureBox.Size,
                        SizeMode = pictureBox.SizeMode,
                        BackColor = pictureBox.BackColor,
                        Name = pictureBox.Name // Sao chép thuộc tính Name
                    };
                }
                else if (control is CheckBox checkBox)
                {
                    clonedControl = new CheckBox
                    {
                        Text = checkBox.Text,
                        Location = checkBox.Location,
                        Size = checkBox.Size,
                        Font = checkBox.Font,
                        ForeColor = checkBox.ForeColor,
                        BackColor = checkBox.BackColor,
                        Checked = checkBox.Checked,
                        Name = checkBox.Name // Sao chép thuộc tính Name
                    };
                }
                else if (control is Panel panel)
                {
                    clonedControl = ClonePanel(panel, item);
                    clonedControl.Location = panel.Location;
                    clonedControl.Name = panel.Name; // Sao chép thuộc tính Name
                }
                // Add more control types as needed

                if (clonedControl != null)
                {
                    clonedPanel.Controls.Add(clonedControl);
                }
            }

            return clonedPanel;
        }

        private async void lblDelete_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (sender is Label label && label.Tag is CartItem item)
                {
                    // Code to delete the product from the cart
                    var userId = (await _userService.GetUserIdByToken()).Data.UserId;
                    await _cartService.RemoveFromCartAsync(userId, item.Id);

                    // Optionally, remove the panel from the UI
                    var panel = label.Parent as Panel;
                    if (panel != null)
                    {
                        pnlProductList.Controls.Remove(panel);
                    }

                    MessageBox.Show($"Deleted item: {item.Product.Name}");
                }
            }
        }

        private async void Cart_Load(object sender, EventArgs e)
        {
            var response = await _userService.GetUserIdByToken(); // Replace with actual user ID
            var userId = response.Data.UserId;
            var response1 = await _cartService.GetCartByUserIdAsync(userId);

            var cart = response1.Data;

            foreach (var item in cart.CartItems)
            {
                var productPanel = ClonePanel(pnlProduct, item);

                var nameLabel = productPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblNameProduct");
                if (nameLabel != null)
                {
                    nameLabel.Text = item.Product.Name;
                }

                var priceOldLabel = productPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblOldPrice");
                if (priceOldLabel != null)
                {
                    priceOldLabel.Text = item.Product.Price.ToString("C");
                }
                var priceCurLabel = productPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblCurrentPrice");
                if (priceCurLabel != null)
                {
                    //var respone3 = _discountService.GetProductsInDiscount();
                    priceCurLabel.Text = item.Product.Price.ToString("C");
                }
                var quantityLabel = productPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblQuantity");
                if (quantityLabel != null)
                {
                    quantityLabel.Text = item.Quantity.ToString();
                }
                var productPictureBox = productPanel.Controls.OfType<PictureBox>().FirstOrDefault(pb => pb.Name == "pictureBoxProduct");
                if (productPictureBox != null)
                {
                    var response2 = await _productService.GetAllImagesFromProductById(item.ProductId);
                    var listImage = response2.Data.ToList();
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            byte[] imageData = await client.GetByteArrayAsync(listImage[0].Url);
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                productPictureBox.Image = System.Drawing.Image.FromStream(stream);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải ảnh: " + ex.Message);
                    }
                }
                pnlProductList.Controls.Add(productPanel);
            }
        }

        private void cbxProduct_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {

        }

        private async void lblDelMul_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn tất cả xóa sản phẩm này khỏi giỏ hàng không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (sender is Label label && label.Tag is CartItem item)
                {
                    // Code to delete the product from the cart
                    var userId = (await _userService.GetUserIdByToken()).Data.UserId;
                    await _cartService.ClearCartAsync(userId);

                    // Optionally, remove the panel from the UI
                    var panel = label.Parent as Panel;
                    if (panel != null)
                    {
                        pnlProductList.Controls.Remove(panel);
                    }

                    MessageBox.Show($"Deleted item: {item.Product.Name}");
                }
            }
        }
    }
}
