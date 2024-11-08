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
    public partial class PaymentMethod : Form
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblHeader1 = new Label();
            pnReceive = new Panel();
            pbxDone = new PictureBox();
            lblNhanHang = new Label();
            pbxNhanHang = new PictureBox();
            pnMomo = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pbxMomo = new PictureBox();
            pnLine = new Panel();
            pnReceive.SuspendLayout();
            ((ISupportInitialize)pbxDone).BeginInit();
            ((ISupportInitialize)pbxNhanHang).BeginInit();
            pnMomo.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pbxMomo).BeginInit();
            SuspendLayout();
            // 
            // lblHeader1
            // 
            lblHeader1.AutoSize = true;
            lblHeader1.Cursor = Cursors.IBeam;
            lblHeader1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader1.Location = new Point(12, 9);
            lblHeader1.Name = "lblHeader1";
            lblHeader1.Size = new Size(310, 32);
            lblHeader1.TabIndex = 2;
            lblHeader1.Text = "Phương thức thanh toán";
            // 
            // pnReceive
            // 
            pnReceive.Controls.Add(pbxDone);
            pnReceive.Controls.Add(lblNhanHang);
            pnReceive.Controls.Add(pbxNhanHang);
            pnReceive.Cursor = Cursors.Hand;
            pnReceive.Location = new Point(9, 47);
            pnReceive.Name = "pnReceive";
            pnReceive.Size = new Size(501, 75);
            pnReceive.TabIndex = 3;
            // 
            // pbxDone
            // 
            pbxDone.Image = Properties.Resources.icon_Done;
            pbxDone.Location = new Point(419, 15);
            pbxDone.Name = "pbxDone";
            pbxDone.Size = new Size(35, 35);
            pbxDone.TabIndex = 2;
            pbxDone.TabStop = false;
            // 
            // lblNhanHang
            // 
            lblNhanHang.AutoSize = true;
            lblNhanHang.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNhanHang.Location = new Point(107, 24);
            lblNhanHang.Name = "lblNhanHang";
            lblNhanHang.Size = new Size(257, 26);
            lblNhanHang.TabIndex = 1;
            lblNhanHang.Text = "Thanh toán khi nhận hàng";
            // 
            // pbxNhanHang
            // 
            pbxNhanHang.Image = Properties.Resources.receiver;
            pbxNhanHang.Location = new Point(8, 7);
            pbxNhanHang.Name = "pbxNhanHang";
            pbxNhanHang.Size = new Size(60, 60);
            pbxNhanHang.TabIndex = 0;
            pbxNhanHang.TabStop = false;
            // 
            // pnMomo
            // 
            pnMomo.Controls.Add(pictureBox1);
            pnMomo.Controls.Add(label1);
            pnMomo.Controls.Add(pbxMomo);
            pnMomo.Cursor = Cursors.Hand;
            pnMomo.Location = new Point(9, 128);
            pnMomo.Name = "pnMomo";
            pnMomo.Size = new Size(501, 75);
            pnMomo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Done;
            pictureBox1.Location = new Point(419, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 24);
            label1.Name = "label1";
            label1.Size = new Size(225, 26);
            label1.TabIndex = 1;
            label1.Text = "Thanh toán qua Momo";
            // 
            // pbxMomo
            // 
            pbxMomo.Image = Properties.Resources.icon_Momo;
            pbxMomo.Location = new Point(8, 7);
            pbxMomo.Name = "pbxMomo";
            pbxMomo.Size = new Size(60, 60);
            pbxMomo.TabIndex = 0;
            pbxMomo.TabStop = false;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.Silver;
            pnLine.Location = new Point(9, 128);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(501, 1);
            pnLine.TabIndex = 5;
            // 
            // PaymentMethod
            // 
            BackColor = Color.White;
            ClientSize = new Size(530, 249);
            Controls.Add(pnLine);
            Controls.Add(pnMomo);
            Controls.Add(pnReceive);
            Controls.Add(lblHeader1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentMethod";
            pnReceive.ResumeLayout(false);
            pnReceive.PerformLayout();
            ((ISupportInitialize)pbxDone).EndInit();
            ((ISupportInitialize)pbxNhanHang).EndInit();
            pnMomo.ResumeLayout(false);
            pnMomo.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pbxMomo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblHeader1;
        private PictureBox pbxNhanHang;
        private Label lblNhanHang;
        private Panel pnMomo;
        private Label label1;
        private PictureBox pbxMomo;
        private PictureBox pbxDone;
        private Panel pnLine;
        private PictureBox pictureBox1;
        private Panel pnReceive;
    }
}
