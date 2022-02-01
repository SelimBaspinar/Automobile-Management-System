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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }
        CarProvider car = new CarProvider();
        StatisticsProvider statistics = new StatisticsProvider();
        DataTable data = new DataTable();
        Panel panel = Application.OpenForms["Panel"] as Panel;
        DataGridView dw;
        DataGridView dw1;
        int carcount=0;
        int repaircount=0;
        string repairstat;
        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
                repairstat = "Defective";
            else
                repairstat = "Repaired";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox5.Text == ""  || textBox7.Text == "" || textBox8.Text == "")
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                dw = panel.Controls["dtcar"] as DataGridView;

                dw1 = panel.Controls["dtstatistics"] as DataGridView;
                if (car.Insert(textBox1.Text, textBox2.Text, textBox3.Text, repairstat, textBox5.Text,
                    dateTimePicker1.Value.ToString().Substring(0,10), textBox7.Text, textBox8.Text))
                {
                    dw.DataSource = car.get();
                    if (statistics.Contains(textBox2.Text))
                    {
                        dw1.DataSource = statistics.getcarcount(textBox2.Text);
                        carcount = Convert.ToInt32(dw1.Rows[0].Cells[0].Value);
                        dw1.DataSource = statistics.getrepaircount(textBox2.Text);
                        repaircount = Convert.ToInt32(dw1.Rows[0].Cells[0].Value);
                        carcount++;
                        if (radioButton2.Checked == true)
                            repaircount++;
                        statistics.update(textBox2.Text, repaircount, carcount);
                        dw1.DataSource = statistics.get();

                    }
                    else {
                        if (radioButton2.Checked == true) { 
                        statistics.Insert(textBox2.Text,1,1);
                        dw1.DataSource = statistics.get();
                        }
                        else { 
                            statistics.Insert(textBox2.Text, 1, 0);
                        dw1.DataSource = statistics.get();
                        }
                    }
                    dw1.DataSource = statistics.get();

                    MessageBox.Show("The car has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The car with " + textBox1.Text + " has already been added.");
                }

            }

        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
