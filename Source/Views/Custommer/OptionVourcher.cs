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
    public partial class OptionVourcher : Form
    {
        int frmOptionVourcherLocationFixedY;
        public OptionVourcher()
        {
            InitializeComponent();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {

            int y = PaymentCustomer.parentY += 3;
            this.Location = new Point(PaymentCustomer.parentX * 3 / 2, y - 100);
            if (Opacity >= 1 && y - 100 >= frmOptionVourcherLocationFixedY)
            {
                modalEffect_Timer.Stop();
            }
            else if (Opacity != 1)
            {
                Opacity += 0.03;
            }



        }

        private void OptionVourcher_Load(object sender, EventArgs e)
        {
            frmOptionVourcherLocationFixedY = PaymentCustomer.parentY + 50;
            this.Location = new Point(PaymentCustomer.parentX * 3 / 2, PaymentCustomer.parentY + 50);
        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
