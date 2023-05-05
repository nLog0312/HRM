namespace HumanResourceManagement.ChildForms.TimeSheet_Child
{
    partial class frmTimeSheetDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTimeSheetDetail = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unExcused = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excused = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTimeSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nmrTotal = new System.Windows.Forms.NumericUpDown();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblWorkDay = new System.Windows.Forms.Label();
            this.nmrWorđay = new System.Windows.Forms.NumericUpDown();
            this.panelWorkDay = new System.Windows.Forms.Panel();
            this.lblExcused = new System.Windows.Forms.Label();
            this.nmrExcused = new System.Windows.Forms.NumericUpDown();
            this.panelExcused = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.lblIdEmployee = new System.Windows.Forms.Label();
            this.txbIdEmployee = new System.Windows.Forms.TextBox();
            this.panelIdTimeSheet = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panelId = new System.Windows.Forms.Panel();
            this.lblUnexcused = new System.Windows.Forms.Label();
            this.nmrUnexcused = new System.Windows.Forms.NumericUpDown();
            this.panelUnExcused = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ctTextBox1 = new HumanResourceManagement.CustomUI.CTTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheetDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTotal)).BeginInit();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrWorđay)).BeginInit();
            this.panelWorkDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExcused)).BeginInit();
            this.panelExcused.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelIdTimeSheet.SuspendLayout();
            this.panelId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnexcused)).BeginInit();
            this.panelUnExcused.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Controls.Add(this.dgvTimeSheetDetail);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panelIdTimeSheet);
            this.panel1.Controls.Add(this.panelId);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panelName);
            this.panel1.Controls.Add(this.panelTotal);
            this.panel1.Controls.Add(this.panelUnExcused);
            this.panel1.Controls.Add(this.panelExcused);
            this.panel1.Controls.Add(this.panelWorkDay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 682);
            this.panel1.TabIndex = 1;
            // 
            // dgvTimeSheetDetail
            // 
            this.dgvTimeSheetDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimeSheetDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeSheetDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvTimeSheetDetail.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTimeSheetDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSheetDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTimeSheet,
            this.idEmployee,
            this.nameEmployee,
            this.workDay,
            this.excused,
            this.unExcused,
            this.total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimeSheetDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimeSheetDetail.Location = new System.Drawing.Point(4, 191);
            this.dgvTimeSheetDetail.Name = "dgvTimeSheetDetail";
            this.dgvTimeSheetDetail.ReadOnly = true;
            this.dgvTimeSheetDetail.RowHeadersWidth = 51;
            this.dgvTimeSheetDetail.RowTemplate.Height = 24;
            this.dgvTimeSheetDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeSheetDetail.Size = new System.Drawing.Size(1197, 423);
            this.dgvTimeSheetDetail.TabIndex = 22;
            this.dgvTimeSheetDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeSheetDetail_CellClick);
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Tổng Số Công";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // unExcused
            // 
            this.unExcused.DataPropertyName = "unExcused";
            this.unExcused.HeaderText = "Số Ngày Nghỉ (không phép)";
            this.unExcused.MinimumWidth = 6;
            this.unExcused.Name = "unExcused";
            this.unExcused.ReadOnly = true;
            // 
            // excused
            // 
            this.excused.DataPropertyName = "excused";
            this.excused.HeaderText = "Số Ngày Nghỉ (có phép)";
            this.excused.MinimumWidth = 6;
            this.excused.Name = "excused";
            this.excused.ReadOnly = true;
            // 
            // workDay
            // 
            this.workDay.DataPropertyName = "workDay";
            this.workDay.HeaderText = "Số Ngày Làm";
            this.workDay.MinimumWidth = 6;
            this.workDay.Name = "workDay";
            this.workDay.ReadOnly = true;
            // 
            // nameEmployee
            // 
            this.nameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nameEmployee.DataPropertyName = "nameEmployee";
            this.nameEmployee.HeaderText = "Tên Nhân Viên";
            this.nameEmployee.MinimumWidth = 6;
            this.nameEmployee.Name = "nameEmployee";
            this.nameEmployee.ReadOnly = true;
            this.nameEmployee.Width = 24;
            // 
            // idEmployee
            // 
            this.idEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idEmployee.DataPropertyName = "idEmployee";
            this.idEmployee.HeaderText = "Mã Nhân Viên";
            this.idEmployee.MinimumWidth = 6;
            this.idEmployee.Name = "idEmployee";
            this.idEmployee.ReadOnly = true;
            this.idEmployee.Width = 24;
            // 
            // idTimeSheet
            // 
            this.idTimeSheet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idTimeSheet.DataPropertyName = "idTimeSheet";
            this.idTimeSheet.HeaderText = "Mã";
            this.idTimeSheet.MinimumWidth = 6;
            this.idTimeSheet.Name = "idTimeSheet";
            this.idTimeSheet.ReadOnly = true;
            this.idTimeSheet.Width = 24;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Location = new System.Drawing.Point(782, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 49);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(939, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 49);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Tổng Số Công";
            // 
            // nmrTotal
            // 
            this.nmrTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrTotal.Enabled = false;
            this.nmrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrTotal.Location = new System.Drawing.Point(201, 9);
            this.nmrTotal.Name = "nmrTotal";
            this.nmrTotal.Size = new System.Drawing.Size(62, 26);
            this.nmrTotal.TabIndex = 1;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.nmrTotal);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Location = new System.Drawing.Point(774, 4);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(281, 53);
            this.panelTotal.TabIndex = 16;
            // 
            // lblWorkDay
            // 
            this.lblWorkDay.AutoSize = true;
            this.lblWorkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDay.Location = new System.Drawing.Point(3, 10);
            this.lblWorkDay.Name = "lblWorkDay";
            this.lblWorkDay.Size = new System.Drawing.Size(131, 25);
            this.lblWorkDay.TabIndex = 0;
            this.lblWorkDay.Text = "Số Ngày Làm";
            // 
            // nmrWorđay
            // 
            this.nmrWorđay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrWorđay.Enabled = false;
            this.nmrWorđay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrWorđay.Location = new System.Drawing.Point(234, 10);
            this.nmrWorđay.Name = "nmrWorđay";
            this.nmrWorđay.ReadOnly = true;
            this.nmrWorđay.Size = new System.Drawing.Size(62, 26);
            this.nmrWorđay.TabIndex = 1;
            // 
            // panelWorkDay
            // 
            this.panelWorkDay.Controls.Add(this.nmrWorđay);
            this.panelWorkDay.Controls.Add(this.lblWorkDay);
            this.panelWorkDay.Location = new System.Drawing.Point(446, 4);
            this.panelWorkDay.Name = "panelWorkDay";
            this.panelWorkDay.Size = new System.Drawing.Size(305, 53);
            this.panelWorkDay.TabIndex = 16;
            // 
            // lblExcused
            // 
            this.lblExcused.AutoSize = true;
            this.lblExcused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcused.Location = new System.Drawing.Point(3, 10);
            this.lblExcused.Name = "lblExcused";
            this.lblExcused.Size = new System.Drawing.Size(192, 25);
            this.lblExcused.TabIndex = 0;
            this.lblExcused.Text = "Ngày Nghỉ (có phép)";
            // 
            // nmrExcused
            // 
            this.nmrExcused.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrExcused.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrExcused.Location = new System.Drawing.Point(234, 10);
            this.nmrExcused.Name = "nmrExcused";
            this.nmrExcused.Size = new System.Drawing.Size(62, 26);
            this.nmrExcused.TabIndex = 1;
            this.nmrExcused.ValueChanged += new System.EventHandler(this.nmrExcused_ValueChanged);
            // 
            // panelExcused
            // 
            this.panelExcused.Controls.Add(this.nmrExcused);
            this.panelExcused.Controls.Add(this.lblExcused);
            this.panelExcused.Location = new System.Drawing.Point(446, 63);
            this.panelExcused.Name = "panelExcused";
            this.panelExcused.Size = new System.Drawing.Size(305, 53);
            this.panelExcused.TabIndex = 16;
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên Nhân Viên";
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(157, 7);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(241, 30);
            this.txbName.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.txbName);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Controls.Add(this.panel2);
            this.panelName.Location = new System.Drawing.Point(4, 122);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(408, 53);
            this.panelName.TabIndex = 12;
            // 
            // lblIdEmployee
            // 
            this.lblIdEmployee.AutoSize = true;
            this.lblIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmployee.Location = new System.Drawing.Point(7, 12);
            this.lblIdEmployee.Name = "lblIdEmployee";
            this.lblIdEmployee.Size = new System.Drawing.Size(137, 25);
            this.lblIdEmployee.TabIndex = 0;
            this.lblIdEmployee.Text = "Mã Nhân Viên";
            // 
            // txbIdEmployee
            // 
            this.txbIdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIdEmployee.Enabled = false;
            this.txbIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdEmployee.Location = new System.Drawing.Point(157, 9);
            this.txbIdEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIdEmployee.Name = "txbIdEmployee";
            this.txbIdEmployee.ReadOnly = true;
            this.txbIdEmployee.Size = new System.Drawing.Size(241, 30);
            this.txbIdEmployee.TabIndex = 1;
            // 
            // panelIdTimeSheet
            // 
            this.panelIdTimeSheet.Controls.Add(this.txbIdEmployee);
            this.panelIdTimeSheet.Controls.Add(this.lblIdEmployee);
            this.panelIdTimeSheet.Location = new System.Drawing.Point(4, 63);
            this.panelIdTimeSheet.Name = "panelIdTimeSheet";
            this.panelIdTimeSheet.Size = new System.Drawing.Size(408, 53);
            this.panelIdTimeSheet.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(7, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã";
            // 
            // txbId
            // 
            this.txbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(157, 8);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(241, 30);
            this.txbId.TabIndex = 1;
            // 
            // panelId
            // 
            this.panelId.Controls.Add(this.txbId);
            this.panelId.Controls.Add(this.lblId);
            this.panelId.Location = new System.Drawing.Point(4, 4);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(408, 53);
            this.panelId.TabIndex = 21;
            // 
            // lblUnexcused
            // 
            this.lblUnexcused.AutoSize = true;
            this.lblUnexcused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnexcused.Location = new System.Drawing.Point(3, 10);
            this.lblUnexcused.Name = "lblUnexcused";
            this.lblUnexcused.Size = new System.Drawing.Size(225, 25);
            this.lblUnexcused.TabIndex = 0;
            this.lblUnexcused.Text = "Ngày Nghỉ (không phép)";
            // 
            // nmrUnexcused
            // 
            this.nmrUnexcused.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrUnexcused.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrUnexcused.Location = new System.Drawing.Point(234, 10);
            this.nmrUnexcused.Name = "nmrUnexcused";
            this.nmrUnexcused.Size = new System.Drawing.Size(62, 26);
            this.nmrUnexcused.TabIndex = 1;
            this.nmrUnexcused.ValueChanged += new System.EventHandler(this.nmrUnexcused_ValueChanged);
            // 
            // panelUnExcused
            // 
            this.panelUnExcused.Controls.Add(this.nmrUnexcused);
            this.panelUnExcused.Controls.Add(this.lblUnexcused);
            this.panelUnExcused.Location = new System.Drawing.Point(446, 122);
            this.panelUnExcused.Name = "panelUnExcused";
            this.panelUnExcused.Size = new System.Drawing.Size(305, 53);
            this.panelUnExcused.TabIndex = 16;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txbSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Location = new System.Drawing.Point(4, 620);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(647, 59);
            this.panelSearch.TabIndex = 26;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(265, 16);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(345, 26);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(15, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(223, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm theo tên nhân viên:";
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
            // frmTimeSheetDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(1220, 698);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimeSheetDetail";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeSheetDetail";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheetDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTotal)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrWorđay)).EndInit();
            this.panelWorkDay.ResumeLayout(false);
            this.panelWorkDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExcused)).EndInit();
            this.panelExcused.ResumeLayout(false);
            this.panelExcused.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelIdTimeSheet.ResumeLayout(false);
            this.panelIdTimeSheet.PerformLayout();
            this.panelId.ResumeLayout(false);
            this.panelId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnexcused)).EndInit();
            this.panelUnExcused.ResumeLayout(false);
            this.panelUnExcused.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTimeSheetDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTimeSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn excused;
        private System.Windows.Forms.DataGridViewTextBoxColumn unExcused;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelIdTimeSheet;
        private System.Windows.Forms.TextBox txbIdEmployee;
        private System.Windows.Forms.Label lblIdEmployee;
        private System.Windows.Forms.Panel panelId;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private CustomUI.CTTextBox ctTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.NumericUpDown nmrTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelUnExcused;
        private System.Windows.Forms.NumericUpDown nmrUnexcused;
        private System.Windows.Forms.Label lblUnexcused;
        private System.Windows.Forms.Panel panelExcused;
        private System.Windows.Forms.NumericUpDown nmrExcused;
        private System.Windows.Forms.Label lblExcused;
        private System.Windows.Forms.Panel panelWorkDay;
        private System.Windows.Forms.NumericUpDown nmrWorđay;
        private System.Windows.Forms.Label lblWorkDay;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}