﻿using System;
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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
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
    }
}
