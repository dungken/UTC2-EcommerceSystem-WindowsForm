using Source.Models;
using Source.Repository;
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

namespace Source.Views
{
    public partial class Test1 : Form
    {
        private readonly AccountService _accountService;
        public Test1()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _accountService.Enable2FA();
            //MessageBox.Show("Category name: " + category.Name);
        }
    }
}
