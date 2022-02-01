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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        CarProvider car = new CarProvider();
        CarpartProvider carpart = new CarpartProvider();
        CustomerProvider customer = new CustomerProvider();
        EmployeeProvider employee = new EmployeeProvider();
        PermissionProvider permission = new PermissionProvider();
        StatisticsProvider statistics = new StatisticsProvider();
        LoginProvider login = new LoginProvider();
        bool employeesearch;
        bool carsearch;
        bool carpartsearch;
        bool statisticssearch;
        bool customersearch;
        bool permissionsearch;
        private void Panel_Load(object sender, EventArgs e)
        {
            dtlogin.Hide();
            dtprofil.DataSource = employee.getusername(lblusername.Text);
            dtstatistics.DataSource = statistics.get();
            dtcar.DataSource = car.get();
            dtcarpart.DataSource = carpart.get();
            dtcustomer.DataSource = customer.get();
            dtemployee.DataSource = employee.get();
            dtpermission.DataSource = permission.get();
            lblcarpartcount.Text=(dtcarpart.Rows.Count-1).ToString();
            permis();



        }
        public void permis()
        {
            int roleid;
            dtlogin.DataSource = employee.getroleid(lblusername.Text);
            roleid = Convert.ToInt32(dtlogin.Rows[0].Cells[0].Value);
            DataView dv = permission.get().DefaultView;
            dv.RowFilter = "Convert(Role_Id,System.String) LIKE '" + roleid + "%'";
            dtlogin.DataSource = dv;
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[1].Value) == 0)
                statisticToolStripMenuItem.Enabled = false;
            else
                statisticToolStripMenuItem.Enabled = true;
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[4].Value) == 0)
                employeeToolStripMenuItem.Enabled = false;
            else
            {
                employeeToolStripMenuItem.Enabled = true;
                employeeshow();
            }
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[2].Value) == 0)
            {
                dtemployee.Columns.Remove("Salary");
            }
            else
            {
                if (Convert.ToInt32(dtlogin.Rows[0].Cells[4].Value) == 0)
                {
                    employeeToolStripMenuItem.Enabled = true;
                    dtemployee.Columns.Remove("Email");
                    dtemployee.Columns.Remove("Name");
                    dtemployee.Columns.Remove("Surname");
                    dtemployee.Columns.Remove("Gender");
                    dtemployee.Columns.Remove("Address");
                    dtemployee.Columns.Remove("Phone_Number");
                    dtemployee.Columns.Remove("Working_Hours");
                    dtemployee.Columns.Remove("Username");
                }
            }
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[3].Value) == 0)
                carPartToolStripMenuItem.Enabled = false;
            else
            {
                carPartToolStripMenuItem.Enabled = true;
                carpartshow();
            }
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[5].Value) == 0)
                carToolStripMenuItem.Enabled = false;
            else
            {
                carToolStripMenuItem.Enabled = true;
                carshow();
            }
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[6].Value) == 0)
                permissionToolStripMenuItem.Enabled = false;
            else
                permissionToolStripMenuItem.Enabled = true;
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[7].Value) == 0)
                customerToolStripMenuItem.Enabled = false;
            else
                customerToolStripMenuItem.Enabled = true;
        }
        public void carshow()
        {
            label2.Hide();
            carsearch = true;
            carpartsearch = false;
            statisticssearch = false;
            employeesearch = false;
            customersearch = false;
            permissionsearch = false;
            dtcar.Show();
            btncaradd.Show();
            btncarremove.Show();
            btncarupdate.Show();
            dtcarpart.Hide();
            btncarpartadd.Hide();
            btncarpartremove.Hide();
            btncarpartupdate.Hide();
            btncustomeradd.Hide();
            btncustomerremove.Hide();
            btncustomerupdate.Hide();
            dtcustomer.Hide();
            dtemployee.Hide();
            btnempadd.Hide();
            btnempremove.Hide();
            btnempupdate.Hide();
            btnperadd.Hide();
            btnperremove.Hide();
            btnperupdate.Hide();
            dtpermission.Hide();
            dtstatistics.Hide();
            comboBox1.Items.Clear();
            dtprofil.Hide();
            lblcarpartcount.Hide();

        }
        public void carpartshow()
        {
            lblcarpartcount.Text = (dtcarpart.Rows.Count-1).ToString();
            lblcarpartcount.Show();
            label2.Show();
            carpartsearch = true;
            carsearch = false;
            statisticssearch = false;
            employeesearch = false;
            customersearch = false;
            permissionsearch = false;
            dtstatistics.Hide();
            btnperadd.Hide();
            btnperremove.Hide();
            btnperupdate.Hide();
            dtpermission.Hide();
            dtemployee.Hide();
            btnempadd.Hide();
            btnempremove.Hide();
            btnempupdate.Hide();
            btncustomeradd.Hide();
            btncustomerremove.Hide();
            btncustomerupdate.Hide();
            dtcustomer.Hide();
            dtcar.Hide();
            btncaradd.Hide();
            btncarremove.Hide();
            btncarupdate.Hide();
            dtcarpart.Show();
            btncarpartadd.Show();
            btncarpartremove.Show();
            btncarpartupdate.Show();
            comboBox1.Items.Clear();
            dtprofil.Hide();


        }
        public void customershow()
        {
            label2.Hide();
            lblcarpartcount.Hide();
            carsearch = false;
            carpartsearch = false;
            statisticssearch = false;
            employeesearch = false;
            customersearch = true;
            permissionsearch = false;
            dtstatistics.Hide();
            btnperadd.Hide();
            btnperremove.Hide();
            btnperupdate.Hide();
            dtpermission.Hide();
            dtemployee.Hide();
            btnempadd.Hide();
            btnempremove.Hide();
            btnempupdate.Hide();
            dtcar.Hide();
            btncaradd.Hide();
            btncarremove.Hide();
            btncarupdate.Hide();
            dtcarpart.Hide();
            btncarpartadd.Hide();
            btncarpartremove.Hide();
            btncarpartupdate.Hide();
            btncustomeradd.Show();
            btncustomerremove.Show();
            btncustomerupdate.Show();
            dtcustomer.Show();
            comboBox1.Items.Clear();
            dtprofil.Hide();

        }
        public void employeeshow()
        {
            label2.Hide();
            lblcarpartcount.Hide();
            carsearch = false;
            carpartsearch = false;
            statisticssearch = false;
            employeesearch = true;
            customersearch = false;
            permissionsearch = false;
            dtstatistics.Hide();
            btnperadd.Hide();
            btnperremove.Hide();
            btnperupdate.Hide();
            dtpermission.Hide();
            dtcar.Hide();
            btncaradd.Hide();
            btncarremove.Hide();
            btncarupdate.Hide();
            dtcarpart.Hide();
            btncarpartadd.Hide();
            btncarpartremove.Hide();
            btncarpartupdate.Hide();
            btncustomeradd.Hide();
            btncustomerremove.Hide();
            btncustomerupdate.Hide();
            dtcustomer.Hide();
            dtemployee.Show();
            btnempadd.Show();
            btnempremove.Show();
            btnempupdate.Show();
            comboBox1.Items.Clear();
            dtprofil.Hide();

        }
        public void permssionshow()
        {
            label2.Hide();
            lblcarpartcount.Hide();
            carsearch = false;
            carpartsearch = false;
            statisticssearch = false;
            employeesearch = false;
            customersearch = false;
            permissionsearch = true;
            btnperadd.Show();
            btnperremove.Show();
            btnperupdate.Show();
            dtpermission.Show();
            dtcar.Hide();
            btncaradd.Hide();
            btncarremove.Hide();
            btncarupdate.Hide();
            dtcarpart.Hide();
            btncarpartadd.Hide();
            btncarpartremove.Hide();
            btncarpartupdate.Hide();
            btncustomeradd.Hide();
            btncustomerremove.Hide();
            btncustomerupdate.Hide();
            dtcustomer.Hide();
            dtemployee.Hide();
            btnempadd.Hide();
            btnempremove.Hide();
            btnempupdate.Hide();
            dtstatistics.Hide();
            comboBox1.Items.Clear();
            dtprofil.Hide();

        }
        public void statisticsshow()
        {
            label2.Hide();
            lblcarpartcount.Hide();
            carsearch = false;
            carpartsearch = false;
            statisticssearch = true;
            employeesearch = false;
            customersearch = false;
            permissionsearch = false;
            btnperadd.Hide();
            btnperremove.Hide();
            btnperupdate.Hide();
            dtpermission.Hide();
            dtcar.Hide();
            btncaradd.Hide();
            btncarremove.Hide();
            btncarupdate.Hide();
            dtcarpart.Hide();
            btncarpartadd.Hide();
            btncarpartremove.Hide();
            btncarpartupdate.Hide();
            btncustomeradd.Hide();
            btncustomerremove.Hide();
            btncustomerupdate.Hide();
            dtcustomer.Hide();
            dtemployee.Hide();
            btnempadd.Hide();
            btnempremove.Hide();
            btnempupdate.Hide();
            dtstatistics.Show();
            comboBox1.Items.Clear();
            dtprofil.Hide();
        }
        public void profilshow()
        {
            label2.Hide();
            lblcarpartcount.Hide();
            carpartsearch = true;
            carsearch = false;
            statisticssearch = false;
            employeesearch = false;
            customersearch = false;
            permissionsearch = false;
            dtstatistics.Hide();
            btnperadd.Hide();
            btnperremove.Hide();
            btnperupdate.Hide();
            dtpermission.Hide();
            dtemployee.Hide();
            btnempadd.Hide();
            btnempremove.Hide();
            btnempupdate.Hide();
            btncustomeradd.Hide();
            btncustomerremove.Hide();
            btncustomerupdate.Hide();
            dtcustomer.Hide();
            dtcar.Hide();
            btncaradd.Hide();
            btncarremove.Hide();
            btncarupdate.Hide();
            dtcarpart.Hide();
            btncarpartadd.Hide();
            btncarpartremove.Hide();
            btncarpartupdate.Hide();
            comboBox1.Hide();
            dtprofil.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ıd;
            string brand;
            string model;
            string repairstatus;
            int repairfee;
            string repairtime;
            string damagereport;
            string type;
            int i;
            for (i = 0; i < dtcar.Rows.Count - 1; i++)
            {
                ıd = Convert.ToInt32(dtcar.Rows[i].Cells[0].Value);
                brand = dtcar.Rows[i].Cells[1].Value.ToString();
                model = dtcar.Rows[i].Cells[2].Value.ToString();
                repairstatus = dtcar.Rows[i].Cells[3].Value.ToString();
                repairfee = Convert.ToInt32(dtcar.Rows[i].Cells[4].Value);
                repairtime = dtcar.Rows[i].Cells[5].Value.ToString();
                damagereport = dtcar.Rows[i].Cells[6].Value.ToString();
                type = dtcar.Rows[i].Cells[7].Value.ToString();
                car.update(ıd, brand, model, repairstatus, repairfee, repairtime, damagereport, type);
            }
            dtcar.DataSource = car.get();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        private void btncarremove_Click(object sender, EventArgs e)
        {

            int CarId = Convert.ToInt32(dtcar.CurrentRow.Cells[0].Value);
            dtcar.DataSource = car.Remove(CarId);
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carshow();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void carPartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            carpartshow();
        }

        private void btncarpartremove_Click(object sender, EventArgs e)
        {
            int carpartId = Convert.ToInt32(dtcarpart.CurrentRow.Cells[0].Value);
            dtcarpart.DataSource = carpart.Remove(carpartId);
        }

        private void btncarpartupdate_Click(object sender, EventArgs e)
        {
            int Id;
            string orderdate;
            string items;
            int count;
            int price;
            int i;
            for (i = 0; i < dtcarpart.Rows.Count - 1; i++)
            {
                Id = Convert.ToInt32(dtcarpart.Rows[i].Cells[0].Value);
                orderdate = dtcarpart.Rows[i].Cells[1].Value.ToString();
                items = dtcarpart.Rows[i].Cells[2].Value.ToString();
                count = Convert.ToInt32(dtcarpart.Rows[i].Cells[3].Value);
                price = Convert.ToInt32(dtcarpart.Rows[i].Cells[4].Value);
                carpart.update(Id, orderdate, items, count, price);

            }
            dtcarpart.DataSource = carpart.get();
        }

        private void btncarpartadd_Click(object sender, EventArgs e)
        {
            AddCarPart addCarPart = new AddCarPart();
            addCarPart.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            customershow();
        }

        private void btncustomerremove_Click(object sender, EventArgs e)
        {
            double phonenumber = Convert.ToDouble(dtcustomer.CurrentRow.Cells[0].Value);
            dtcustomer.DataSource = customer.Remove(phonenumber);
        }

        private void btncustomerupdate_Click(object sender, EventArgs e)
        {
            double PhoneNumber;
            string Name;
            string Surname;
            string Gender;
            string Address;
            string Email;
            int i;
            for (i = 0; i < dtcustomer.Rows.Count - 1; i++)
            {
                PhoneNumber = Convert.ToDouble(dtcustomer.Rows[i].Cells[0].Value);
                Name = dtcustomer.Rows[i].Cells[1].Value.ToString();
                Surname = dtcustomer.Rows[i].Cells[2].Value.ToString();
                Gender = dtcustomer.Rows[i].Cells[3].Value.ToString();
                Address = dtcustomer.Rows[i].Cells[4].Value.ToString();
                Email = dtcustomer.Rows[i].Cells[5].Value.ToString();
                customer.update(PhoneNumber, Name, Surname, Gender, Address, Email);

            }
            dtcustomer.DataSource = customer.get();
        }

        private void btncustomeradd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtlogin.Rows[0].Cells[2].Value) == 0)
            {
                employeeshow();
                btnempadd.Hide();
                btnempremove.Hide();
                btnempupdate.Hide();
            }
            else {
                if (Convert.ToInt32(dtlogin.Rows[0].Cells[4].Value) == 0)
                {
                    employeeshow();
                    employeeToolStripMenuItem.Enabled = true; 
                    btnempadd.Hide();
                    btnempremove.Hide();
                    btnempupdate.Hide();
                }
                else
                    employeeshow();

            }

        }

    private void btnempupdate_Click(object sender, EventArgs e)
    {
        int Role_Id;
        string Email;
        string Name;
        string Surname;
        string Gender;
        string Address;
        double Phone_Number;
        double Salary;
        string Working_Hours;
        string Username;
        int i;
        for (i = 0; i < dtemployee.Rows.Count - 1; i++)
        {
            Role_Id = Convert.ToInt32(dtemployee.Rows[i].Cells[0].Value);
            Email = dtemployee.Rows[i].Cells[1].Value.ToString();
            Name = dtemployee.Rows[i].Cells[2].Value.ToString();
            Surname = dtemployee.Rows[i].Cells[3].Value.ToString();
            Gender = dtemployee.Rows[i].Cells[4].Value.ToString();
            Address = dtemployee.Rows[i].Cells[5].Value.ToString();
            Phone_Number = Convert.ToDouble(dtemployee.Rows[i].Cells[6].Value);
            Salary = Convert.ToDouble(dtemployee.Rows[i].Cells[7].Value);
            Working_Hours = dtemployee.Rows[i].Cells[8].Value.ToString();
            Username = dtemployee.Rows[i].Cells[9].Value.ToString();
            employee.update(Username, Role_Id, Email, Name, Surname, Gender, Address, Phone_Number, Salary, Working_Hours);

        }
        dtemployee.DataSource = employee.get();
    }

    private void btnempremove_Click(object sender, EventArgs e)
    {
        string username = Convert.ToString(dtemployee.CurrentRow.Cells[9].Value);
        dtemployee.DataSource = employee.Remove(username);
    }

    private void btnempadd_Click(object sender, EventArgs e)
    {
        AddEmployee addEmployee = new AddEmployee();
        addEmployee.Show();
    }

    private void btnperupdate_Click(object sender, EventArgs e)
    {
        int roleId;
        int Statistics;
        int Salary;
        int CarPart;
        int Employee;
        int Car;
        int Permission;
        int Customer;
        int i;
        for (i = 0; i < dtpermission.Rows.Count - 1; i++)
        {

            roleId = Convert.ToInt32(dtpermission.Rows[i].Cells[0].Value);
            Statistics = Convert.ToInt32(dtpermission.Rows[i].Cells[1].Value);
            Salary = Convert.ToInt32(dtpermission.Rows[i].Cells[2].Value);
            CarPart = Convert.ToInt32(dtpermission.Rows[i].Cells[3].Value);
            Employee = Convert.ToInt32(dtpermission.Rows[i].Cells[4].Value);
            Car = Convert.ToInt32(dtpermission.Rows[i].Cells[5].Value);
            Permission = Convert.ToInt32(dtpermission.Rows[i].Cells[6].Value);
            Customer = Convert.ToInt32(dtpermission.Rows[i].Cells[7].Value);

            permission.update(roleId, Statistics, Salary, CarPart, Employee, Car, Permission, Customer);

        }
        dtpermission.DataSource = permission.get();
    }

    private void btnperremove_Click(object sender, EventArgs e)
    {
        int roleıd = Convert.ToInt32(dtpermission.CurrentRow.Cells[0].Value);
        dtpermission.DataSource = permission.Remove(roleıd);
    }

    private void btnperadd_Click(object sender, EventArgs e)
    {
        AddPermission addPermission = new AddPermission();
        addPermission.Show();
    }

    private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
    {

        permssionshow();
    }

    private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
    {

        statisticsshow();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            if (comboBox1.Text == "") 
          MessageBox.Show("Lütfen Bir Tane Filter Seçin");
            else { 
                string ctxt = comboBox1.SelectedItem.ToString();
          
            if (employeesearch == true)
                {
                    if (ctxt == "Username")
                    {

                        DataView dv = employee.get().DefaultView;
                        dv.RowFilter = "Username LIKE '" + textBox1.Text + "%'";
                        dtemployee.DataSource = dv;
                    }
                    else if (ctxt == "Name")
                    {
                        DataView dv = employee.get().DefaultView;
                        dv.RowFilter = "Name LIKE '" + textBox1.Text + "%'";
                        dtemployee.DataSource = dv;
                    }
                    else if (ctxt == "Surname")
                    {
                        DataView dv = employee.get().DefaultView;
                        dv.RowFilter = "Surname LIKE '" + textBox1.Text + "%'";
                        dtemployee.DataSource = dv;
                    }
                    else if (ctxt == "Email")
                    {
                        DataView dv = employee.get().DefaultView;
                        dv.RowFilter = "Email LIKE '" + textBox1.Text + "%'";
                        dtemployee.DataSource = dv;

                    }
                    else
                    {
                        DataView dv = employee.get().DefaultView;
                        dv.RowFilter = "CONVERT(Phone_Number, System.String) LIKE '" + textBox1.Text + "%'";
                        dtemployee.DataSource = dv;

                    }
                }
                else if (statisticssearch == true)
                {
                    if (ctxt == "Car Id")
                    {

                        DataView dv = statistics.get().DefaultView;
                        dv.RowFilter = "CONVERT(Car_Id, System.String) LIKE '" + textBox1.Text + "%'";
                        dtstatistics.DataSource = dv;
                    }
                }
                else if (customersearch == true)
                {
                    if (ctxt == "Phone Number")
                    {

                        DataView dv = customer.get().DefaultView;
                        dv.RowFilter = "CONVERT(Phone_Number, System.String) LIKE '" + textBox1.Text + "%'";
                        dtcustomer.DataSource = dv;
                    }
                    else if (ctxt == "Name")
                    {
                        DataView dv = customer.get().DefaultView;
                        dv.RowFilter = "Name LIKE '" + textBox1.Text + "%'";
                        dtcustomer.DataSource = dv;
                    }
                    else if (ctxt == "Surname")
                    {
                        DataView dv = customer.get().DefaultView;
                        dv.RowFilter = "Surname LIKE '" + textBox1.Text + "%'";
                        dtcustomer.DataSource = dv;
                    }
                    else
                    {
                        DataView dv = customer.get().DefaultView;
                        dv.RowFilter = "Email LIKE '" + textBox1.Text + "%'";
                        dtcustomer.DataSource = dv;

                    }
                }
                else if (carsearch == true)
                {
                    if (ctxt == "Car Id")
                    {

                        DataView dv = car.get().DefaultView;
                        dv.RowFilter = "CONVERT(Car_Id, System.String) LIKE '" + textBox1.Text + "%'";
                        dtcar.DataSource = dv;
                    }
                    else if (ctxt == "Brand")
                    {
                        DataView dv = car.get().DefaultView;
                        dv.RowFilter = "Brand LIKE '" + textBox1.Text + "%'";
                        dtcar.DataSource = dv;
                    }
                    else
                    {
                        DataView dv = car.get().DefaultView;
                        dv.RowFilter = "Model LIKE '" + textBox1.Text + "%'";
                        dtcar.DataSource = dv;
                    }
                }
                else if (carpartsearch == true)
                {
                    if (ctxt == "Item Id")
                    {

                        DataView dv = carpart.get().DefaultView;
                        dv.RowFilter = "CONVERT(Item_Id, System.String) LIKE '" + textBox1.Text + "%'";
                        dtcarpart.DataSource = dv;
                    }
                    else
                    {
                        DataView dv = carpart.get().DefaultView;
                        dv.RowFilter = "Items LIKE '" + textBox1.Text + "%'";
                        dtcarpart.DataSource = dv;
                    }
                }
                else
                {
                    if (ctxt == "Role Id")
                    {

                        DataView dv = permission.get().DefaultView;
                        dv.RowFilter = "CONVERT(Role_Id, System.String) LIKE '" + textBox1.Text + "%'";
                        dtcarpart.DataSource = dv;
                    }
                }
            }
        }


    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void comboBox1_Click(object sender, EventArgs e)
    {
        if (carsearch == true)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Car Id");
            comboBox1.Items.Add("Brand");
            comboBox1.Items.Add("Model");

        }
        else if (carpartsearch == true)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Item Id");
            comboBox1.Items.Add("Items");

            }
            else if (statisticssearch == true)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Car Id");

            }
            else if (customersearch == true)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Phone Number");
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Surname");
            comboBox1.Items.Add("Email");

            }
            else if (employeesearch == true)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Username");
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Surname");
            comboBox1.Items.Add("Email");
            comboBox1.Items.Add("Phone Number");

            }
            else
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Role Id");

            }

        }

        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

        private void dtprofil_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilshow();
        }

        private void dtprofil_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtprofil.DataSource = employee.getusername(lblusername.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

