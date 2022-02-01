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
    public partial class AddPermission : Form
    {
        public AddPermission()
        {
            InitializeComponent();
        }
        PermissionProvider permission = new PermissionProvider();
        Panel panel = Application.OpenForms["Panel"] as Panel;
        DataGridView dw;

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "")
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                dw = panel.Controls["dtpermission"] as DataGridView;
                if (permission.Insert(Convert.ToInt32(textBox1.Text), Convert.ToInt32(cboxstat.Checked), Convert.ToInt32(cboxsalary.Checked), Convert.ToInt32(cboxcarpart.Checked), Convert.ToInt32(cboxemployee.Checked), Convert.ToInt32(cboxcar.Checked), Convert.ToInt32(cboxper.Checked), Convert.ToInt32(cboxcustomer.Checked)))
                {
                    dw.DataSource = permission.get();
                    MessageBox.Show("The permission has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The permission with " + textBox1.Text + " has already been added.");
                }

            }
        }

        private void AddPermission_Load(object sender, EventArgs e)
        {

        }

        private void cboxstat_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxstat.Checked == true)
                cboxstat.Text = "Allow";
            else
                cboxstat.Text = "Deny";
        }

        private void cboxsalary_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxsalary.Checked == true)
                cboxsalary.Text = "Allow";
            else
                cboxsalary.Text = "Deny";
        }

        private void cboxcarpart_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxcarpart.Checked == true)
                cboxcarpart.Text = "Allow";
            else
                cboxcarpart.Text = "Deny";
        }

        private void cboxemployee_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxemployee.Checked == true)
                cboxemployee.Text = "Allow";
            else
                cboxemployee.Text = "Deny";
        }

        private void cboxcar_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxcar.Checked == true)
                cboxcar.Text = "Allow";
            else
                cboxcar.Text = "Deny";
        }
    }
}
