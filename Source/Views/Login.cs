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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
           
        }

        private void btnResgister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resgister().Show();
          
        }

        private void btnLoginWGoogle_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginWithGoogle().Show();
       
        }

        private void lblForget_Click(object sender, EventArgs e)
        {

        }
    }
}
