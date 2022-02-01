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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        EmployeeProvider employee = new EmployeeProvider();
        PermissionProvider permission = new PermissionProvider();
        LoginProvider login = new LoginProvider();
        DataTable data = new DataTable();
        Panel panel = Application.OpenForms["Panel"] as Panel;
        DataGridView dw;
        DataGridView dw1;
        string gender;
        int userid;
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

            int i;
            dw1 = panel.Controls["dtpermission"] as DataGridView;
            dw1.DataSource = permission.get();
            for (i=0;i<dw1.Rows.Count-1;i++) {
                cboxroleid.Items.Add(dw1.Rows[i].Cells[0].Value.ToString());
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.dtpermission.DataSource = login.get();
            userid = panel.dtpermission.Rows.Count;
            userid--;
            panel.dtpermission.DataSource = permission.get();
            if (radioButton1.Checked == true)
                gender = "Male";
            else
                gender = "Female";

            if (cboxroleid.SelectedItem.ToString() == "" || txtusername.Text == "" || txtemail.Text == "" || txtname.Text == "" ||
                txtpassword.Text == "" || txtaddress.Text == "" || txtphonenumber.Text == "" || txtsalary.Text == "" || txtworkinghours.Text == "" || txtsurname.Text == "")
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {

                if (employee.Insert(txtusername.Text, Convert.ToInt32(cboxroleid.SelectedItem), txtemail.Text, txtname.Text, txtsurname.Text, gender, txtaddress.Text,
                    Convert.ToDouble(txtphonenumber.Text), Convert.ToDouble(txtsalary.Text), txtworkinghours.Text) && login.Insert(userid, txtusername.Text, txtpassword.Text))
                {
                    panel.dtemployee.DataSource = employee.get();
                    panel.dtpermission.DataSource = permission.get();
                    MessageBox.Show("The employee has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The employee with " + txtusername.Text + " has already been added.");
                }

            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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
