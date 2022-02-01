using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepair
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        LoginProvider login = new LoginProvider();


        private void button1_Click(object sender, EventArgs e)
        {
            if (login.LoginUser(txtusername.Text, txtpass.Text, txtusername.Text))
            {
                MessageBox.Show("Login Başarılı");
                Panel panel = new Panel();
                panel.lblusername.Text = txtusername.Text;
                panel.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Login Başarısız");
            }
        

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            txtpass.PasswordChar='*';
            else
            txtpass.PasswordChar = '\0';

        }

 
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
