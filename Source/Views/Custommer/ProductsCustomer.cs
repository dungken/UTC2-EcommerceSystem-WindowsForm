using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;



namespace Source.Views.Custommer
{
    public partial class ProductsCustomer : Form
    {
        public ProductsCustomer()
        {
            InitializeComponent();
            btnDecrease.Enabled = false;
        }

        private void changeInforMain(System.Windows.Forms.Panel panela)
        {
            foreach (System.Windows.Forms.Control ctrl in panela.Controls)
            {
                // Kiểm tra loại control và thực hiện các thao tác
                if (ctrl is PictureBox PictureBox)
                {
                    pictureMain.Image = PictureBox.Image;
                }
                else if (ctrl is System.Windows.Forms.Label label1)
                {
                    lblNameMain.Text = label1.Text;
                }
                else if (ctrl is System.Windows.Forms.Panel panel1)
                {
                    foreach (System.Windows.Forms.Control ctrl1 in panel1.Controls)
                    {
                        if (ctrl1 is System.Windows.Forms.Label label2)
                        {
                            if (label2.Name.Contains("Price"))
                            {
                                lblPriceMain.Text = label2.Text;
                            }
                            else if (label2.Name.Contains("Cate"))
                            {
                                lblCategoryMain.Text = label2.Text;
                            }
                        }
                    }
                }
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
    }
}
