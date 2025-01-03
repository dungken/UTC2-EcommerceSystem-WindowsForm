﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Http;
using Source.Dtos.Product;
using Source.Models;
using Source.Service;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Guna.UI2.WinForms.Suite;
using Source.Dtos.Category;
using api.Dtos.Product;

namespace Source.Views.Admin
{

    public partial class ProductEdit : Form
    {
        private readonly ProductService _productService;
        private readonly ImageService _imageService;
        private readonly SizeService _sizeService;
        private readonly CategoriesService _categoriesService;

        public List<ColorDTO> _colors { get; set; } = new List<ColorDTO>();
        public List<SizeDTO> _sizes { get; set; } = new List<SizeDTO>();
        public List<ImageDTO> _images { get; set; } = new List<ImageDTO>();

        private ProductDTO _product;
        public List<IFormFile> _formFiles = new List<IFormFile>();
        private string _selectedFilePath = "";
        public ProductEdit()
        {
            InitializeComponent();
            pnBasicInfor.Paint += PanelLine_Paint;
            pnCategory.Paint += PanelLine_Paint;
            pnColor.Paint += PanelLine_Paint;
            pnSize.Paint += PanelLine_Paint;
            pnStatus.Paint += PanelLine_Paint;

            _productService = new ProductService();
            _imageService = new ImageService();
            _sizeService = new SizeService();
            _categoriesService = new CategoriesService();
        }
        public ProductEdit(ProductDTO product)
        {
            InitializeComponent();
            pnBasicInfor.Paint += PanelLine_Paint;
            pnCategory.Paint += PanelLine_Paint;
            pnColor.Paint += PanelLine_Paint;
            pnSize.Paint += PanelLine_Paint;
            pnStatus.Paint += PanelLine_Paint;

            _productService = new ProductService();
            _imageService = new ImageService();
            _sizeService = new SizeService();
            _categoriesService = new CategoriesService();

            _product = product;
            LoadProductData();
        }
        private void PanelLine_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            // Thiết lập màu và độ dày viền
            Color borderColor = Color.Silver;
            float borderSize = 0.5f;

            // Vẽ đường viền
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }
        private async void LoadCategories(Guid? selectedParentId = null)
        {
            var response = await _categoriesService.GetAllCategories();
            if (response.Success && response != null)
            {
                lbxCategory.Items.Clear();
                foreach (var category in response.Data)
                {
                    var listItem = new ListBoxItem
                    {
                        Text = category.Name,
                        Value = category.Id
                    };
                    lbxCategory.Items.Add(listItem);

                    // Nếu danh mục cha hiện tại khớp với ID, chọn nó
                    if (selectedParentId.HasValue && category.Id == selectedParentId)
                    {
                        lbxCategory.SelectedItem = listItem;
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to load parent categories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Định nghĩa class ListBoxItem để chứa giá trị ẩn
        public class ListBoxItem
        {
            public string Text { get; set; }
            public Guid Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        // Phương thức để lấy tên màu
        //private string GetColorName(Color color)
        //{
        //    // Kiểm tra xem màu có phải là một màu chuẩn đã định nghĩa trong Color hay không
        //    var colorProperty = typeof(Color).GetProperties()
        //        .FirstOrDefault(p => p.PropertyType == typeof(Color) && (Color)p.GetValue(null) == color);

        //    return colorProperty?.Name ?? "Unknown"; // Nếu không tìm thấy tên, trả về "Unknown"
        //}
        // vẽ màu
        // Xử lý sự kiện vẽ để hiển thị màu
        //private void LbxColor_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 0) return;

        //    // Lấy màu từ ListBox
        //    Color color = (Color)lbxColor.Items[e.Index];

        //    // Vẽ nền mục
        //    e.DrawBackground();

        //    // Vẽ ô vuông màu
        //    using (Brush brush = new SolidBrush(color))
        //    {
        //        e.Graphics.FillRectangle(brush, e.Bounds.X + 2, e.Bounds.Y + 2, 20, e.Bounds.Height - 4);
        //    }

        //    // Hiển thị tên màu (nếu cần)
        //    string colorName = $"ARGB: {color.ToArgb()}";
        //    using (Brush textBrush = new SolidBrush(e.ForeColor))
        //    {
        //        e.Graphics.DrawString(colorName, e.Font, textBrush, e.Bounds.X + 25, e.Bounds.Y + 2);
        //    }

        //    e.DrawFocusRectangle();
        //}
        // Hàm xử lý sự kiện vẽ item của ListBox
        //private void ListBoxColors_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    // Kiểm tra nếu item không phải là "None"
        //    if (e.Index >= 0)
        //    {
        //        // Lấy tên màu từ item trong ListBox
        //        string colorName = lbxColor.Items[e.Index].ToString();

        //        // Chuyển tên màu thành đối tượng Color
        //        Color color = Color.FromName(colorName);

        //        // Vẽ nền của item theo màu đã chọn
        //        e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);

        //        // Vẽ tên màu trên nền
        //        e.Graphics.DrawString(colorName, e.Font, Brushes.White, e.Bounds);
        //    }
        //}
        //private void LoadColorData()
        //{
        //    // Cấu hình ListBox để sử dụng chế độ vẽ tùy chỉnh
        //    lbxColor.DrawMode = DrawMode.OwnerDrawFixed;
        //    lbxColor.ItemHeight = 30; // Thiết lập chiều cao cho mỗi item (để dễ nhìn hơn)

        //    // Thêm các màu vào ListBox
        //    List<string> colors = _product.Colors.Select(s => s.Name).ToList();
        //    foreach (var color in colors)
        //    {
        //        lbxColor.Items.Add(color); // Thêm tên màu vào ListBox
        //    }

        //    // Đăng ký sự kiện vẽ tùy chỉnh
        //    lbxColor.DrawItem += ListBoxColors_DrawItem;
        //}
        private void LoadProductData()
        {
            if (_product.Status == "Active")
                rbtnActive.Checked = true;
            else if (_product.Status == "Inactive")
                rbtnInactive.Checked = true;
            else
                rbtnPending.Checked = true;

            // Duyệt qua danh sách và đánh dấu checkbox tương ứng
            //foreach (var size in _product.Sizes.Select(s => s.Name).ToList())
            //{
            //    switch (size)
            //    {
            //        case "XS":
            //            cbxXS.Checked = true;
            //            break;
            //        case "S":
            //            cbxS.Checked = true;
            //            break;
            //        case "M":
            //            cbxM.Checked = true;
            //            break;
            //        case "L":
            //            cbxL.Checked = true;
            //            break;
            //        case "XL":
            //            cbxXL.Checked = true;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            

            //LoadColorData();
            tbxName.Text = _product.Name;
            tbxDescription.Text = _product.Description;
            tbxPrice.Text = _product.Price.ToString();
            numeric.Value = _product.StockQuantity;
            LoadCategories();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            //// Mở hộp thoại chọn màu
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    // Lấy màu đã chọn
            //    Color selectedColor = colorDialog.Color;

            //    // Chuyển đổi thành mã màu Hex
            //    string hexColor = $"#{selectedColor.R:X2}{selectedColor.G:X2}{selectedColor.B:X2}";

            //    // Tìm tên màu gần nhất
            //    string colorName = GetColorName(selectedColor);

            //    MessageBox.Show($"Color Name: {colorName}\nHex Color: {hexColor}\nRGB: {selectedColor.R}, {selectedColor.G}, {selectedColor.B}");

            //    var newColorDto = new ColorDTO
            //    {
            //        Name = colorName,
            //        ColorCode = hexColor,
            //    };
            //    _colors.Add(newColorDto);
            //}

            //// Hiển thị danh sách màu đã chọn
            //lbxColor.Items.Add(colorDialog.Color);
        }

        private void btnPickImg_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog
            //{
            //    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
            //    Title = "Select a File to Upload"
            //};

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (var filePath in openFileDialog.FileNames)
            //    {

            //        _selectedFilePath = openFileDialog.FileName;
            //        string directoryPath = Path.GetDirectoryName(_selectedFilePath);
            //        string combinedPath = Path.Combine(directoryPath, Path.GetFileName(_selectedFilePath));
            //        _selectedFilePath = combinedPath;
            //        MessageBox.Show($"File selected: {combinedPath}");

            //        using (var stream = new MemoryStream(File.ReadAllBytes(_selectedFilePath)))
            //        {

            //            PictureBox pictureBox = new PictureBox
            //            {
            //                Image = Image.FromStream(stream),
            //                SizeMode = PictureBoxSizeMode.Zoom,
            //                Width = 100, // Điều chỉnh kích thước theo ý muốn
            //                Height = 100,
            //                Margin = new Padding(5)
            //            };

            //            flowLayoutPanel.Controls.Add(pictureBox); // Thêm PictureBox vào FlowLayoutPanel
            //        }

            //        // Tạo file giả lập đầu tiên
            //        byte[] imageData1 = File.ReadAllBytes(_selectedFilePath);
            //        var fileStream1 = new MemoryStream(imageData1);
            //        _formFiles.Add(new FormFile(
            //            baseStream: fileStream1,
            //            baseStreamOffset: 0,
            //            length: fileStream1.Length,
            //            name: "file1",
            //            fileName: _selectedFilePath
            //        )
            //        {
            //            Headers = new HeaderDictionary(),
            //            ContentType = "image/png"
            //        });
            //    }
            //}
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (lbxCategory.SelectedItem is ListBoxItem selectedItem)
            {
                _product.CategoryId = selectedItem.Value;
            }
            if (string.IsNullOrEmpty(tbxDescription.Text))
            {
                MessageBox.Show("Category description cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbtnActive.Checked)
            {
                _product.Status = "Active";
            }
            else if (rbtnInactive.Checked)
            {
                _product.Status = "Inactive";
            }
            else if (rbtnPending.Checked)
            {
                _product.Status = "Pending";
            }
            else
            {
                MessageBox.Show("Please select a status!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // size
            //foreach (var size1 in _product.Sizes.Select(s => s.Id).ToList())
            //{
            //    var respone = await _sizeService.DeleteSize(size1);
            //}
            //    List<string> size;
            //size = new List<string>();
            //if (cbxXS.Checked)
            //{
            //    size.Add("XS");
            //}
            //if (cbxS.Checked)
            //{
            //    size.Add("S");
            //}
            //if (cbxM.Checked)
            //{
            //    size.Add("M");
            //}
            //if (cbxL.Checked)
            //{
            //    size.Add("L");
            //}
            //if (cbxXL.Checked)
            //{
            //    size.Add("XL");
            //}
            //if (size != null)
            //{
            //    foreach (var index in size)
            //    {
            //        var newSizeDto = new SizeDTO
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = index,
            //        };
            //        _sizes.Add(newSizeDto);
            //    }

            //}

            if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Product name cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _product.Name = tbxName.Text;
            if (string.IsNullOrEmpty(tbxDescription.Text))
            {
                MessageBox.Show("Product description cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _product.Description = tbxDescription.Text;
            _product.StockQuantity = int.Parse(numeric.Value.ToString());
            if (!decimal.TryParse(tbxPrice.Text, out _))
            {
                MessageBox.Show("\"Please enter a valid value of price!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _product.Price = decimal.Parse(tbxPrice.Text);

            // Gọi API để cập nhật
            var result = await _productService.UpdateProductAsync(_product.Id, new UpdateProductDTO
            {
                Name = _product.Name,
                Description = _product.Description,
                Price = _product.Price,
                StockQuantity = _product.StockQuantity,
                CategoryId = _product.CategoryId,
                Status = _product.Status,
            });

            if (result.Success)
            {
                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Đóng form và báo thành công
            }
            else
            {
                MessageBox.Show("Failed to update category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void UploadMultiImg(Guid productId, string altText)
        {
            //var response = await _imageService.UploadMultipleImages(_formFiles.ToArray(), productId, altText);
            //if (response != null && response.Success)
            //{
            //    MessageBox.Show($"Registration Successful\nMessage: {response.Message}");
            //    foreach (var item in response.Data)
            //    {
            //        _images.Add(item);
            //        MessageBox.Show($"{item.CreatedAt}: {item.Url}");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show($"Registration Failed\nError: {string.Join(", ", response.Errors)}");
            //}
        }
    }
}
