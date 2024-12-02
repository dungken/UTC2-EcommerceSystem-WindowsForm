using Source.Models;
using Source.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Views
{
    public partial class Test1 : Form
    {
        private readonly CategoryRepository _categoryRepository;
        public Test1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //var category = await _categoryRepository.GetCategoryByIdAsync(Guid.Parse("661A73EE-B485-45E0-9898-0D83BE47E58B"));

            //MessageBox.Show("Category name: " + category.Name);
        }
    }
}
