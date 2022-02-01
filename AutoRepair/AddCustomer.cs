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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        CustomerProvider customer = new CustomerProvider();
        Panel panel = Application.OpenForms["Panel"] as Panel;
        DataGridView dw;
        string gender;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                gender = "Male";
            else
                gender = "Female";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                            textBox5.Text == "" || textBox6.Text=="")
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                dw = panel.Controls["dtcustomer"] as DataGridView;
                if (customer.Insert(Convert.ToDouble(textBox1.Text), textBox2.Text, textBox3.Text, gender, textBox5.Text,textBox6.Text))
                {
                    dw.DataSource = customer.get();
                    MessageBox.Show("The customer has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The customer with " + textBox1.Text + " has already been added.");
                }

            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 48 || (int)e.KeyChar > 57)
            {
                if ((int)e.KeyChar == 8)
                {
                }
                else
                {

                    MessageBox.Show("Lütfen Sadece Sayı Giriniz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
