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
    public partial class PaymentCustomer : Form
    {
        public PaymentCustomer()
        {
            InitializeComponent();
        }
        public static int parentX, parentY;
        private void btnOptionVourcher_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();

            using (OptionVourcher modal = new OptionVourcher())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.50d;
                modalBackground.Size = new Size(Login.frmWith, MainForm.frmHeight);


                modalBackground.Location = new Point(MainForm.frmMainLocationX, MainForm.frmMainLocationY);
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = MainForm.frmMainLocationX + MainForm.pnlChildFormLocationX;
                parentY = MainForm.frmMainLocationY + MainForm.pnlChildFormLocationY;
                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }

        private void btnOptionShippingMethod_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();

            using (OptionShippingMethod modal = new OptionShippingMethod())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.50d;
                modalBackground.Size = new Size(MainForm.frmWith, MainForm.frmHeight);


                modalBackground.Location = new Point(MainForm.frmMainLocationX, MainForm.frmMainLocationY);
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = MainForm.frmMainLocationX + MainForm.pnlChildFormLocationX;
                parentY = MainForm.frmMainLocationY + MainForm.pnlChildFormLocationY;
                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }
    }
}
