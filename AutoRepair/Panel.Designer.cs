
namespace AutoRepair
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtcar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncarupdate = new System.Windows.Forms.Button();
            this.btncaradd = new System.Windows.Forms.Button();
            this.btncarremove = new System.Windows.Forms.Button();
            this.dtcarpart = new System.Windows.Forms.DataGridView();
            this.btncarpartupdate = new System.Windows.Forms.Button();
            this.btncarpartadd = new System.Windows.Forms.Button();
            this.btncarpartremove = new System.Windows.Forms.Button();
            this.dtcustomer = new System.Windows.Forms.DataGridView();
            this.btncustomerremove = new System.Windows.Forms.Button();
            this.btncustomeradd = new System.Windows.Forms.Button();
            this.btncustomerupdate = new System.Windows.Forms.Button();
            this.dtemployee = new System.Windows.Forms.DataGridView();
            this.btnempremove = new System.Windows.Forms.Button();
            this.btnempadd = new System.Windows.Forms.Button();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.dtpermission = new System.Windows.Forms.DataGridView();
            this.btnperremove = new System.Windows.Forms.Button();
            this.btnperadd = new System.Windows.Forms.Button();
            this.btnperupdate = new System.Windows.Forms.Button();
            this.dtstatistics = new System.Windows.Forms.DataGridView();
            this.dtlogin = new System.Windows.Forms.DataGridView();
            this.lblusername = new System.Windows.Forms.Label();
            this.dtprofil = new System.Windows.Forms.DataGridView();
            this.lblcarpartcount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtcar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcarpart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtemployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtstatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtprofil)).BeginInit();
            this.SuspendLayout();
            // 
            // dtcar
            // 
            this.dtcar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtcar.BackgroundColor = System.Drawing.Color.White;
            this.dtcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcar.Location = new System.Drawing.Point(12, 76);
            this.dtcar.Name = "dtcar";
            this.dtcar.RowHeadersVisible = false;
            this.dtcar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcar.Size = new System.Drawing.Size(776, 362);
            this.dtcar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carToolStripMenuItem,
            this.carPartToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.permissionToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // carPartToolStripMenuItem
            // 
            this.carPartToolStripMenuItem.Name = "carPartToolStripMenuItem";
            this.carPartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carPartToolStripMenuItem.Text = "Car Part";
            this.carPartToolStripMenuItem.Click += new System.EventHandler(this.carPartToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permissionToolStripMenuItem.Text = "Permission";
            this.permissionToolStripMenuItem.Click += new System.EventHandler(this.permissionToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ara :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncarupdate
            // 
            this.btncarupdate.Location = new System.Drawing.Point(442, 34);
            this.btncarupdate.Name = "btncarupdate";
            this.btncarupdate.Size = new System.Drawing.Size(75, 23);
            this.btncarupdate.TabIndex = 35;
            this.btncarupdate.Text = "Update";
            this.btncarupdate.UseVisualStyleBackColor = true;
            this.btncarupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncaradd
            // 
            this.btncaradd.Location = new System.Drawing.Point(533, 34);
            this.btncaradd.Name = "btncaradd";
            this.btncaradd.Size = new System.Drawing.Size(75, 23);
            this.btncaradd.TabIndex = 36;
            this.btncaradd.Text = "Add";
            this.btncaradd.UseVisualStyleBackColor = true;
            this.btncaradd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncarremove
            // 
            this.btncarremove.Location = new System.Drawing.Point(614, 33);
            this.btncarremove.Name = "btncarremove";
            this.btncarremove.Size = new System.Drawing.Size(75, 23);
            this.btncarremove.TabIndex = 37;
            this.btncarremove.Text = "Remove";
            this.btncarremove.UseVisualStyleBackColor = true;
            this.btncarremove.Click += new System.EventHandler(this.btncarremove_Click);
            // 
            // dtcarpart
            // 
            this.dtcarpart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcarpart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtcarpart.BackgroundColor = System.Drawing.Color.White;
            this.dtcarpart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcarpart.Location = new System.Drawing.Point(12, 76);
            this.dtcarpart.Name = "dtcarpart";
            this.dtcarpart.RowHeadersVisible = false;
            this.dtcarpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcarpart.Size = new System.Drawing.Size(776, 362);
            this.dtcarpart.TabIndex = 38;
            // 
            // btncarpartupdate
            // 
            this.btncarpartupdate.Location = new System.Drawing.Point(442, 33);
            this.btncarpartupdate.Name = "btncarpartupdate";
            this.btncarpartupdate.Size = new System.Drawing.Size(75, 23);
            this.btncarpartupdate.TabIndex = 39;
            this.btncarpartupdate.Text = "Update";
            this.btncarpartupdate.UseVisualStyleBackColor = true;
            this.btncarpartupdate.Click += new System.EventHandler(this.btncarpartupdate_Click);
            // 
            // btncarpartadd
            // 
            this.btncarpartadd.Location = new System.Drawing.Point(533, 33);
            this.btncarpartadd.Name = "btncarpartadd";
            this.btncarpartadd.Size = new System.Drawing.Size(75, 23);
            this.btncarpartadd.TabIndex = 40;
            this.btncarpartadd.Text = "Add";
            this.btncarpartadd.UseVisualStyleBackColor = true;
            this.btncarpartadd.Click += new System.EventHandler(this.btncarpartadd_Click);
            // 
            // btncarpartremove
            // 
            this.btncarpartremove.Location = new System.Drawing.Point(614, 33);
            this.btncarpartremove.Name = "btncarpartremove";
            this.btncarpartremove.Size = new System.Drawing.Size(75, 23);
            this.btncarpartremove.TabIndex = 41;
            this.btncarpartremove.Text = "Remove";
            this.btncarpartremove.UseVisualStyleBackColor = true;
            this.btncarpartremove.Click += new System.EventHandler(this.btncarpartremove_Click);
            // 
            // dtcustomer
            // 
            this.dtcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtcustomer.BackgroundColor = System.Drawing.Color.White;
            this.dtcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcustomer.Location = new System.Drawing.Point(12, 76);
            this.dtcustomer.Name = "dtcustomer";
            this.dtcustomer.RowHeadersVisible = false;
            this.dtcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcustomer.Size = new System.Drawing.Size(776, 362);
            this.dtcustomer.TabIndex = 42;
            // 
            // btncustomerremove
            // 
            this.btncustomerremove.Location = new System.Drawing.Point(614, 33);
            this.btncustomerremove.Name = "btncustomerremove";
            this.btncustomerremove.Size = new System.Drawing.Size(75, 23);
            this.btncustomerremove.TabIndex = 48;
            this.btncustomerremove.Text = "Remove";
            this.btncustomerremove.UseVisualStyleBackColor = true;
            this.btncustomerremove.Click += new System.EventHandler(this.btncustomerremove_Click);
            // 
            // btncustomeradd
            // 
            this.btncustomeradd.Location = new System.Drawing.Point(533, 33);
            this.btncustomeradd.Name = "btncustomeradd";
            this.btncustomeradd.Size = new System.Drawing.Size(75, 23);
            this.btncustomeradd.TabIndex = 47;
            this.btncustomeradd.Text = "Add";
            this.btncustomeradd.UseVisualStyleBackColor = true;
            this.btncustomeradd.Click += new System.EventHandler(this.btncustomeradd_Click);
            // 
            // btncustomerupdate
            // 
            this.btncustomerupdate.Location = new System.Drawing.Point(442, 33);
            this.btncustomerupdate.Name = "btncustomerupdate";
            this.btncustomerupdate.Size = new System.Drawing.Size(75, 23);
            this.btncustomerupdate.TabIndex = 46;
            this.btncustomerupdate.Text = "Update";
            this.btncustomerupdate.UseVisualStyleBackColor = true;
            this.btncustomerupdate.Click += new System.EventHandler(this.btncustomerupdate_Click);
            // 
            // dtemployee
            // 
            this.dtemployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtemployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtemployee.BackgroundColor = System.Drawing.Color.White;
            this.dtemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtemployee.Location = new System.Drawing.Point(12, 76);
            this.dtemployee.Name = "dtemployee";
            this.dtemployee.RowHeadersVisible = false;
            this.dtemployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtemployee.Size = new System.Drawing.Size(776, 362);
            this.dtemployee.TabIndex = 49;
            // 
            // btnempremove
            // 
            this.btnempremove.Location = new System.Drawing.Point(614, 33);
            this.btnempremove.Name = "btnempremove";
            this.btnempremove.Size = new System.Drawing.Size(75, 23);
            this.btnempremove.TabIndex = 52;
            this.btnempremove.Text = "Remove";
            this.btnempremove.UseVisualStyleBackColor = true;
            this.btnempremove.Click += new System.EventHandler(this.btnempremove_Click);
            // 
            // btnempadd
            // 
            this.btnempadd.Location = new System.Drawing.Point(533, 33);
            this.btnempadd.Name = "btnempadd";
            this.btnempadd.Size = new System.Drawing.Size(75, 23);
            this.btnempadd.TabIndex = 51;
            this.btnempadd.Text = "Add";
            this.btnempadd.UseVisualStyleBackColor = true;
            this.btnempadd.Click += new System.EventHandler(this.btnempadd_Click);
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(442, 33);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(75, 23);
            this.btnempupdate.TabIndex = 50;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // dtpermission
            // 
            this.dtpermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtpermission.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtpermission.BackgroundColor = System.Drawing.Color.White;
            this.dtpermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpermission.Location = new System.Drawing.Point(12, 76);
            this.dtpermission.Name = "dtpermission";
            this.dtpermission.RowHeadersVisible = false;
            this.dtpermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtpermission.Size = new System.Drawing.Size(776, 362);
            this.dtpermission.TabIndex = 53;
            // 
            // btnperremove
            // 
            this.btnperremove.Location = new System.Drawing.Point(614, 33);
            this.btnperremove.Name = "btnperremove";
            this.btnperremove.Size = new System.Drawing.Size(75, 23);
            this.btnperremove.TabIndex = 56;
            this.btnperremove.Text = "Remove";
            this.btnperremove.UseVisualStyleBackColor = true;
            this.btnperremove.Click += new System.EventHandler(this.btnperremove_Click);
            // 
            // btnperadd
            // 
            this.btnperadd.Location = new System.Drawing.Point(533, 33);
            this.btnperadd.Name = "btnperadd";
            this.btnperadd.Size = new System.Drawing.Size(75, 23);
            this.btnperadd.TabIndex = 55;
            this.btnperadd.Text = "Add";
            this.btnperadd.UseVisualStyleBackColor = true;
            this.btnperadd.Click += new System.EventHandler(this.btnperadd_Click);
            // 
            // btnperupdate
            // 
            this.btnperupdate.Location = new System.Drawing.Point(442, 33);
            this.btnperupdate.Name = "btnperupdate";
            this.btnperupdate.Size = new System.Drawing.Size(75, 23);
            this.btnperupdate.TabIndex = 54;
            this.btnperupdate.Text = "Update";
            this.btnperupdate.UseVisualStyleBackColor = true;
            this.btnperupdate.Click += new System.EventHandler(this.btnperupdate_Click);
            // 
            // dtstatistics
            // 
            this.dtstatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtstatistics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtstatistics.BackgroundColor = System.Drawing.Color.White;
            this.dtstatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtstatistics.Location = new System.Drawing.Point(12, 76);
            this.dtstatistics.Name = "dtstatistics";
            this.dtstatistics.RowHeadersVisible = false;
            this.dtstatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtstatistics.Size = new System.Drawing.Size(776, 362);
            this.dtstatistics.TabIndex = 57;
            // 
            // dtlogin
            // 
            this.dtlogin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtlogin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtlogin.BackgroundColor = System.Drawing.Color.White;
            this.dtlogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlogin.Location = new System.Drawing.Point(12, 76);
            this.dtlogin.Name = "dtlogin";
            this.dtlogin.RowHeadersVisible = false;
            this.dtlogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtlogin.Size = new System.Drawing.Size(776, 362);
            this.dtlogin.TabIndex = 58;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(731, 33);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 13);
            this.lblusername.TabIndex = 59;
            // 
            // dtprofil
            // 
            this.dtprofil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtprofil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtprofil.BackgroundColor = System.Drawing.Color.White;
            this.dtprofil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtprofil.Location = new System.Drawing.Point(12, 76);
            this.dtprofil.Name = "dtprofil";
            this.dtprofil.RowHeadersVisible = false;
            this.dtprofil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtprofil.Size = new System.Drawing.Size(776, 362);
            this.dtprofil.TabIndex = 60;
            this.dtprofil.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtprofil_CellEndEdit);
            this.dtprofil.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtprofil_CellValueChanged);
            // 
            // lblcarpartcount
            // 
            this.lblcarpartcount.AutoSize = true;
            this.lblcarpartcount.Location = new System.Drawing.Point(83, 60);
            this.lblcarpartcount.Name = "lblcarpartcount";
            this.lblcarpartcount.Size = new System.Drawing.Size(0, 13);
            this.lblcarpartcount.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Total Items :";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcarpartcount);
            this.Controls.Add(this.dtprofil);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.dtlogin);
            this.Controls.Add(this.dtstatistics);
            this.Controls.Add(this.btnperremove);
            this.Controls.Add(this.btnperadd);
            this.Controls.Add(this.btnperupdate);
            this.Controls.Add(this.dtpermission);
            this.Controls.Add(this.btnempremove);
            this.Controls.Add(this.btnempadd);
            this.Controls.Add(this.btnempupdate);
            this.Controls.Add(this.dtemployee);
            this.Controls.Add(this.btncustomerremove);
            this.Controls.Add(this.btncustomeradd);
            this.Controls.Add(this.btncustomerupdate);
            this.Controls.Add(this.dtcustomer);
            this.Controls.Add(this.btncarpartremove);
            this.Controls.Add(this.btncarpartadd);
            this.Controls.Add(this.btncarpartupdate);
            this.Controls.Add(this.btncarremove);
            this.Controls.Add(this.btncaradd);
            this.Controls.Add(this.btncarupdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtcarpart);
            this.Controls.Add(this.dtcar);
            this.Controls.Add(this.comboBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.Text = "Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Panel_FormClosed);
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtcarpart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtemployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtstatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtprofil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dtcar;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem carPartToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btncarupdate;
        public System.Windows.Forms.Button btncaradd;
        public System.Windows.Forms.Button btncarremove;
        public System.Windows.Forms.DataGridView dtcarpart;
        public System.Windows.Forms.Button btncarpartupdate;
        public System.Windows.Forms.Button btncarpartadd;
        public System.Windows.Forms.Button btncarpartremove;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtcustomer;
        public System.Windows.Forms.Button btncustomerremove;
        public System.Windows.Forms.Button btncustomeradd;
        public System.Windows.Forms.Button btncustomerupdate;
        public System.Windows.Forms.DataGridView dtemployee;
        public System.Windows.Forms.Button btnempremove;
        public System.Windows.Forms.Button btnempadd;
        public System.Windows.Forms.Button btnempupdate;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtpermission;
        public System.Windows.Forms.Button btnperremove;
        public System.Windows.Forms.Button btnperadd;
        public System.Windows.Forms.Button btnperupdate;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtstatistics;
        public System.Windows.Forms.DataGridView dtlogin;
        public System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtprofil;
        private System.Windows.Forms.Label lblcarpartcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}