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
    public partial class OrderInvoices : Form
    {
        public OrderInvoices()
        {
            InitializeComponent();
        }

        //private void ChangeLabelColorInPanel(object sender, EventArgs e)
        //{
        //    // Duyệt qua tất cả các Control trong panel1
        //    foreach (System.Windows.Forms.Control control in pnOrder.Controls)
        //    {
        //        // Kiểm tra nếu Control là Label
        //        if (control is System.Windows.Forms.Label lbl)
        //        {
        //            // Gán sự kiện MouseEnter để đổi màu chữ khi trỏ chuột vào
        //            lbl.MouseEnter += (s, e) => lbl.ForeColor = Color.Red;

        //            // Gán sự kiện MouseLeave để trả về màu chữ mặc định khi rời chuột
        //            lbl.MouseLeave += (s, e) => lbl.ForeColor = Color.Black;
        //        }
        //    }
        //}
        private void RegisterEventsForLabelsInPanel(System.Windows.Forms.Panel panel)
        {
            object sender;
            EventArgs e;
            // Kiểm tra nếu Panel có chứa bất kỳ Control nào không
            if (panel.Controls.Count == 0)
            {
                MessageBox.Show("Panel không có bất kỳ Label nào để xử lý.");
                return;
            }

            // Duyệt qua tất cả các Control trong Panel
            foreach (System.Windows.Forms.Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.Label lbl)
                {
                    lbl.MouseEnter += label_MouseEnter;
                    lbl.MouseLeave += label_MouseLeave;
                }
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Label lbl)
            {
                lbl.ForeColor = Color.Red; // Đổi màu chữ khi chuột vào
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Label lbl)
            {
                lbl.ForeColor = Color.Black; // Đổi màu chữ khi chuột ra
            }
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
            pnlOrderInvoices.Controls.Add(childForm);
            pnlOrderInvoices.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            openChildForm(new ReviewProduct());
        }
    }


}
