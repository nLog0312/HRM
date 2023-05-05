namespace HumanResourceManagement.ChildForms.Employee_Child
{
    partial class frmEditEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFolk = new System.Windows.Forms.Panel();
            this.txbFolk = new System.Windows.Forms.TextBox();
            this.lblFolk = new System.Windows.Forms.Label();
            this.panelSex = new System.Windows.Forms.Panel();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctTextBox2 = new HumanResourceManagement.CustomUI.CTTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctTextBox1 = new HumanResourceManagement.CustomUI.CTTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIdEmployee = new System.Windows.Forms.Panel();
            this.txbIdEmployee = new System.Windows.Forms.TextBox();
            this.lblIdEmployee = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.idEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexEmployee = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.folkEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelComboBox = new System.Windows.Forms.Panel();
            this.cbbLevelSalary = new System.Windows.Forms.ComboBox();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.lblLevelSalary = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFolk.SuspendLayout();
            this.panelSex.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelIdEmployee.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panelComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelFolk);
            this.panel1.Controls.Add(this.panelSex);
            this.panel1.Controls.Add(this.panelDate);
            this.panel1.Controls.Add(this.panelIdEmployee);
            this.panel1.Controls.Add(this.panelPhone);
            this.panel1.Controls.Add(this.panelName);
            this.panel1.Controls.Add(this.panelAddress);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Controls.Add(this.panelComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 711);
            this.panel1.TabIndex = 0;
            // 
            // panelFolk
            // 
            this.panelFolk.Controls.Add(this.txbFolk);
            this.panelFolk.Controls.Add(this.lblFolk);
            this.panelFolk.Location = new System.Drawing.Point(4, 240);
            this.panelFolk.Name = "panelFolk";
            this.panelFolk.Size = new System.Drawing.Size(408, 53);
            this.panelFolk.TabIndex = 25;
            // 
            // txbFolk
            // 
            this.txbFolk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFolk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFolk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFolk.Location = new System.Drawing.Point(157, 7);
            this.txbFolk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFolk.Name = "txbFolk";
            this.txbFolk.Size = new System.Drawing.Size(241, 30);
            this.txbFolk.TabIndex = 1;
            // 
            // lblFolk
            // 
            this.lblFolk.AutoSize = true;
            this.lblFolk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolk.Location = new System.Drawing.Point(3, 10);
            this.lblFolk.Name = "lblFolk";
            this.lblFolk.Size = new System.Drawing.Size(87, 25);
            this.lblFolk.TabIndex = 0;
            this.lblFolk.Text = "Dân Tộc";
            // 
            // panelSex
            // 
            this.panelSex.Controls.Add(this.cbbSex);
            this.panelSex.Controls.Add(this.lblSex);
            this.panelSex.Controls.Add(this.panel3);
            this.panelSex.Location = new System.Drawing.Point(4, 181);
            this.panelSex.Name = "panelSex";
            this.panelSex.Size = new System.Drawing.Size(408, 53);
            this.panelSex.TabIndex = 24;
            // 
            // cbbSex
            // 
            this.cbbSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbbSex.Location = new System.Drawing.Point(157, 11);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(122, 28);
            this.cbbSex.TabIndex = 1;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(7, 10);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(90, 25);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "Giới Tính";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.ctTextBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 53);
            this.panel3.TabIndex = 0;
            // 
            // ctTextBox2
            // 
            this.ctTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.ctTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctTextBox2.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.ctTextBox2.BorderSize = 2;
            this.ctTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.ctTextBox2.Location = new System.Drawing.Point(164, 6);
            this.ctTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctTextBox2.Multiline = false;
            this.ctTextBox2.Name = "ctTextBox2";
            this.ctTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBox2.PasswordChar = false;
            this.ctTextBox2.ReadOnly = false;
            this.ctTextBox2.Size = new System.Drawing.Size(304, 35);
            this.ctTextBox2.TabIndex = 0;
            this.ctTextBox2.Texts = "";
            this.ctTextBox2.UnderlineStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dân Tộc";
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.dtDate);
            this.panelDate.Controls.Add(this.lblDate);
            this.panelDate.Controls.Add(this.panel2);
            this.panelDate.Location = new System.Drawing.Point(4, 122);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(408, 53);
            this.panelDate.TabIndex = 23;
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(157, 12);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(241, 26);
            this.dtDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày Sinh";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ctTextBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 53);
            this.panel2.TabIndex = 0;
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ctTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ctTextBox1.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.ctTextBox1.BorderSize = 2;
            this.ctTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ctTextBox1.Location = new System.Drawing.Point(164, 6);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.ReadOnly = false;
            this.ctTextBox1.Size = new System.Drawing.Size(304, 35);
            this.ctTextBox1.TabIndex = 0;
            this.ctTextBox1.Texts = "";
            this.ctTextBox1.UnderlineStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dân Tộc";
            // 
            // panelIdEmployee
            // 
            this.panelIdEmployee.Controls.Add(this.txbIdEmployee);
            this.panelIdEmployee.Controls.Add(this.lblIdEmployee);
            this.panelIdEmployee.Location = new System.Drawing.Point(4, 4);
            this.panelIdEmployee.Name = "panelIdEmployee";
            this.panelIdEmployee.Size = new System.Drawing.Size(408, 53);
            this.panelIdEmployee.TabIndex = 32;
            // 
            // txbIdEmployee
            // 
            this.txbIdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIdEmployee.Enabled = false;
            this.txbIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdEmployee.Location = new System.Drawing.Point(157, 8);
            this.txbIdEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIdEmployee.Name = "txbIdEmployee";
            this.txbIdEmployee.ReadOnly = true;
            this.txbIdEmployee.Size = new System.Drawing.Size(241, 30);
            this.txbIdEmployee.TabIndex = 1;
            // 
            // lblIdEmployee
            // 
            this.lblIdEmployee.AutoSize = true;
            this.lblIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmployee.Location = new System.Drawing.Point(7, 11);
            this.lblIdEmployee.Name = "lblIdEmployee";
            this.lblIdEmployee.Size = new System.Drawing.Size(137, 25);
            this.lblIdEmployee.TabIndex = 0;
            this.lblIdEmployee.Text = "Mã Nhân Viên";
            // 
            // panelPhone
            // 
            this.panelPhone.Controls.Add(this.txbPhone);
            this.panelPhone.Controls.Add(this.lblPhone);
            this.panelPhone.Location = new System.Drawing.Point(456, 141);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(447, 53);
            this.panelPhone.TabIndex = 27;
            // 
            // txbPhone
            // 
            this.txbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(150, 7);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(280, 30);
            this.txbPhone.TabIndex = 1;
            this.txbPhone.TextChanged += new System.EventHandler(this.txbPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(3, 10);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(137, 25);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Số Điện Thoại";
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.txbName);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Location = new System.Drawing.Point(4, 63);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(408, 53);
            this.panelName.TabIndex = 22;
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(157, 9);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(241, 30);
            this.txbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên Nhân Viên";
            // 
            // panelAddress
            // 
            this.panelAddress.Controls.Add(this.txbAddress);
            this.panelAddress.Controls.Add(this.lblAddress);
            this.panelAddress.Location = new System.Drawing.Point(456, 200);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(447, 93);
            this.panelAddress.TabIndex = 28;
            // 
            // txbAddress
            // 
            this.txbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(150, 4);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(277, 82);
            this.txbAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 7);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 25);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa Chỉ";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1069, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 49);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Location = new System.Drawing.Point(912, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 49);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmployee,
            this.nameEmployee,
            this.dateEmployee,
            this.sexEmployee,
            this.folkEmployee,
            this.phoneEmployee,
            this.addressEmployee,
            this.idDepartment,
            this.idPosition,
            this.levelSalary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.Enabled = false;
            this.dgvEmployee.Location = new System.Drawing.Point(4, 321);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1243, 386);
            this.dgvEmployee.TabIndex = 31;
            // 
            // idEmployee
            // 
            this.idEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idEmployee.DataPropertyName = "idEmployee";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.idEmployee.DefaultCellStyle = dataGridViewCellStyle5;
            this.idEmployee.FillWeight = 103.4771F;
            this.idEmployee.HeaderText = "Mã NV";
            this.idEmployee.MinimumWidth = 6;
            this.idEmployee.Name = "idEmployee";
            this.idEmployee.ReadOnly = true;
            this.idEmployee.Width = 24;
            // 
            // nameEmployee
            // 
            this.nameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nameEmployee.DataPropertyName = "nameEmployee";
            this.nameEmployee.FillWeight = 408.6222F;
            this.nameEmployee.HeaderText = "Tên Nhân Viên";
            this.nameEmployee.MinimumWidth = 6;
            this.nameEmployee.Name = "nameEmployee";
            this.nameEmployee.ReadOnly = true;
            this.nameEmployee.Width = 24;
            // 
            // dateEmployee
            // 
            this.dateEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dateEmployee.DataPropertyName = "dateEmployee";
            this.dateEmployee.FillWeight = 267.3797F;
            this.dateEmployee.HeaderText = "Ngày Sinh";
            this.dateEmployee.MinimumWidth = 6;
            this.dateEmployee.Name = "dateEmployee";
            this.dateEmployee.ReadOnly = true;
            this.dateEmployee.Width = 24;
            // 
            // sexEmployee
            // 
            this.sexEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sexEmployee.DataPropertyName = "sexEmployee";
            this.sexEmployee.FillWeight = 31.50303F;
            this.sexEmployee.HeaderText = "Giới Tính";
            this.sexEmployee.MinimumWidth = 6;
            this.sexEmployee.Name = "sexEmployee";
            this.sexEmployee.ReadOnly = true;
            this.sexEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sexEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sexEmployee.Width = 83;
            // 
            // folkEmployee
            // 
            this.folkEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.folkEmployee.DataPropertyName = "folkEmployee";
            this.folkEmployee.FillWeight = 31.50303F;
            this.folkEmployee.HeaderText = "Dân Tộc";
            this.folkEmployee.MinimumWidth = 6;
            this.folkEmployee.Name = "folkEmployee";
            this.folkEmployee.ReadOnly = true;
            this.folkEmployee.Width = 24;
            // 
            // phoneEmployee
            // 
            this.phoneEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.phoneEmployee.DataPropertyName = "phoneEmployee";
            this.phoneEmployee.FillWeight = 31.50303F;
            this.phoneEmployee.HeaderText = "Số Điện Thoại";
            this.phoneEmployee.MinimumWidth = 6;
            this.phoneEmployee.Name = "phoneEmployee";
            this.phoneEmployee.ReadOnly = true;
            this.phoneEmployee.Width = 24;
            // 
            // addressEmployee
            // 
            this.addressEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressEmployee.DataPropertyName = "addressEmployee";
            this.addressEmployee.FillWeight = 31.50303F;
            this.addressEmployee.HeaderText = "Địa Chỉ";
            this.addressEmployee.MinimumWidth = 6;
            this.addressEmployee.Name = "addressEmployee";
            this.addressEmployee.ReadOnly = true;
            // 
            // idDepartment
            // 
            this.idDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idDepartment.DataPropertyName = "idDepartment";
            this.idDepartment.FillWeight = 31.50303F;
            this.idDepartment.HeaderText = "Tên Phòng";
            this.idDepartment.MinimumWidth = 6;
            this.idDepartment.Name = "idDepartment";
            this.idDepartment.ReadOnly = true;
            this.idDepartment.Width = 24;
            // 
            // idPosition
            // 
            this.idPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idPosition.DataPropertyName = "idPosition";
            this.idPosition.FillWeight = 31.50303F;
            this.idPosition.HeaderText = "Tên Chức Vụ";
            this.idPosition.MinimumWidth = 6;
            this.idPosition.Name = "idPosition";
            this.idPosition.ReadOnly = true;
            this.idPosition.Width = 24;
            // 
            // levelSalary
            // 
            this.levelSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.levelSalary.DataPropertyName = "levelSalary";
            this.levelSalary.FillWeight = 31.50303F;
            this.levelSalary.HeaderText = "Bậc Lương";
            this.levelSalary.MinimumWidth = 6;
            this.levelSalary.Name = "levelSalary";
            this.levelSalary.ReadOnly = true;
            this.levelSalary.Width = 92;
            // 
            // panelComboBox
            // 
            this.panelComboBox.Controls.Add(this.cbbLevelSalary);
            this.panelComboBox.Controls.Add(this.cbbPosition);
            this.panelComboBox.Controls.Add(this.cbbDepartment);
            this.panelComboBox.Controls.Add(this.lblLevelSalary);
            this.panelComboBox.Controls.Add(this.lblPosition);
            this.panelComboBox.Controls.Add(this.lblDepartment);
            this.panelComboBox.Location = new System.Drawing.Point(456, 4);
            this.panelComboBox.Name = "panelComboBox";
            this.panelComboBox.Size = new System.Drawing.Size(447, 131);
            this.panelComboBox.TabIndex = 26;
            // 
            // cbbLevelSalary
            // 
            this.cbbLevelSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLevelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLevelSalary.FormattingEnabled = true;
            this.cbbLevelSalary.Location = new System.Drawing.Point(150, 91);
            this.cbbLevelSalary.Name = "cbbLevelSalary";
            this.cbbLevelSalary.Size = new System.Drawing.Size(280, 28);
            this.cbbLevelSalary.TabIndex = 2;
            // 
            // cbbPosition
            // 
            this.cbbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(150, 47);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(280, 28);
            this.cbbPosition.TabIndex = 1;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(150, 5);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(280, 28);
            this.cbbDepartment.TabIndex = 0;
            // 
            // lblLevelSalary
            // 
            this.lblLevelSalary.AutoSize = true;
            this.lblLevelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelSalary.Location = new System.Drawing.Point(3, 90);
            this.lblLevelSalary.Name = "lblLevelSalary";
            this.lblLevelSalary.Size = new System.Drawing.Size(106, 25);
            this.lblLevelSalary.TabIndex = 0;
            this.lblLevelSalary.Text = "Bậc Lương";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(3, 46);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(129, 25);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Tên Chức Vụ";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(3, 4);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(109, 25);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Tên Phòng";
            // 
            // frmEditEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(1267, 727);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditEmployee";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "EditEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panelFolk.ResumeLayout(false);
            this.panelFolk.PerformLayout();
            this.panelSex.ResumeLayout(false);
            this.panelSex.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelIdEmployee.ResumeLayout(false);
            this.panelIdEmployee.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panelComboBox.ResumeLayout(false);
            this.panelComboBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFolk;
        private System.Windows.Forms.TextBox txbFolk;
        private System.Windows.Forms.Label lblFolk;
        private System.Windows.Forms.Panel panelSex;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Panel panel3;
        private CustomUI.CTTextBox ctTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel2;
        private CustomUI.CTTextBox ctTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIdEmployee;
        private System.Windows.Forms.TextBox txbIdEmployee;
        private System.Windows.Forms.Label lblIdEmployee;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmployee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sexEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn folkEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelSalary;
        private System.Windows.Forms.Panel panelComboBox;
        private System.Windows.Forms.ComboBox cbbLevelSalary;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.Label lblLevelSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartment;
    }
}