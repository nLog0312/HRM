namespace HumanResourceManagement.ChildForms
{
    partial class frmRate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNonReward = new System.Windows.Forms.Label();
            this.panelTitleBarReward = new System.Windows.Forms.Panel();
            this.btnDeleteReward = new System.Windows.Forms.Button();
            this.btnEditReward = new System.Windows.Forms.Button();
            this.btnAddReward = new System.Windows.Forms.Button();
            this.dgvReward = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNonDiscipline = new System.Windows.Forms.Label();
            this.panelTitleBarDiscipline = new System.Windows.Forms.Panel();
            this.btnDeleteDiscipline = new System.Windows.Forms.Button();
            this.btnEditDiscipline = new System.Windows.Forms.Button();
            this.btnAddDiscipline = new System.Windows.Forms.Button();
            this.dgvDiscipline = new System.Windows.Forms.DataGridView();
            this.idDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployeeDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployeeDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployeeReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployeeReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelTitleBarReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReward)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelTitleBarDiscipline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscipline)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblNonReward);
            this.tabPage1.Controls.Add(this.panelTitleBarReward);
            this.tabPage1.Controls.Add(this.dgvReward);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khen Thưởng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblNonReward
            // 
            this.lblNonReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNonReward.Location = new System.Drawing.Point(369, 170);
            this.lblNonReward.Name = "lblNonReward";
            this.lblNonReward.Size = new System.Drawing.Size(315, 84);
            this.lblNonReward.TabIndex = 18;
            this.lblNonReward.Text = "Không có dữ liệu khen thưởng nào, bạn có thể click nút \'Thêm\' để thêm mới";
            this.lblNonReward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonReward.Visible = false;
            // 
            // panelTitleBarReward
            // 
            this.panelTitleBarReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBarReward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBarReward.Controls.Add(this.btnDeleteReward);
            this.panelTitleBarReward.Controls.Add(this.btnEditReward);
            this.panelTitleBarReward.Controls.Add(this.btnAddReward);
            this.panelTitleBarReward.Location = new System.Drawing.Point(8, 458);
            this.panelTitleBarReward.Name = "panelTitleBarReward";
            this.panelTitleBarReward.Size = new System.Drawing.Size(1008, 71);
            this.panelTitleBarReward.TabIndex = 17;
            // 
            // btnDeleteReward
            // 
            this.btnDeleteReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteReward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDeleteReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReward.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReward.Image = global::HumanResourceManagement.Properties.Resources.delete_4219;
            this.btnDeleteReward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteReward.Location = new System.Drawing.Point(366, 0);
            this.btnDeleteReward.Name = "btnDeleteReward";
            this.btnDeleteReward.Size = new System.Drawing.Size(177, 71);
            this.btnDeleteReward.TabIndex = 15;
            this.btnDeleteReward.Text = "  Xoá";
            this.btnDeleteReward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteReward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteReward.UseVisualStyleBackColor = false;
            this.btnDeleteReward.Click += new System.EventHandler(this.btnDeleteReward_Click);
            // 
            // btnEditReward
            // 
            this.btnEditReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditReward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnEditReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReward.ForeColor = System.Drawing.Color.White;
            this.btnEditReward.Image = global::HumanResourceManagement.Properties.Resources.sheetandpencil_118361;
            this.btnEditReward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditReward.Location = new System.Drawing.Point(183, 0);
            this.btnEditReward.Name = "btnEditReward";
            this.btnEditReward.Size = new System.Drawing.Size(177, 71);
            this.btnEditReward.TabIndex = 14;
            this.btnEditReward.Text = "  Sửa";
            this.btnEditReward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditReward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditReward.UseVisualStyleBackColor = false;
            this.btnEditReward.Click += new System.EventHandler(this.btnEditReward_Click);
            // 
            // btnAddReward
            // 
            this.btnAddReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddReward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAddReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReward.ForeColor = System.Drawing.Color.White;
            this.btnAddReward.Image = global::HumanResourceManagement.Properties.Resources.add_archive_application_4473;
            this.btnAddReward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReward.Location = new System.Drawing.Point(0, 0);
            this.btnAddReward.Name = "btnAddReward";
            this.btnAddReward.Size = new System.Drawing.Size(177, 71);
            this.btnAddReward.TabIndex = 11;
            this.btnAddReward.Text = "  Thêm";
            this.btnAddReward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddReward.UseVisualStyleBackColor = false;
            this.btnAddReward.Click += new System.EventHandler(this.btnAddReward_Click);
            // 
            // dgvReward
            // 
            this.dgvReward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReward.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReward.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReward.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvReward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReward,
            this.idEmployeeReward,
            this.nameEmployeeReward,
            this.reasonReward,
            this.descriptionReward});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReward.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReward.Location = new System.Drawing.Point(8, 6);
            this.dgvReward.Name = "dgvReward";
            this.dgvReward.ReadOnly = true;
            this.dgvReward.RowHeadersWidth = 51;
            this.dgvReward.RowTemplate.Height = 24;
            this.dgvReward.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReward.Size = new System.Drawing.Size(1008, 446);
            this.dgvReward.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblNonDiscipline);
            this.tabPage2.Controls.Add(this.panelTitleBarDiscipline);
            this.tabPage2.Controls.Add(this.dgvDiscipline);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kỷ Luật";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNonDiscipline
            // 
            this.lblNonDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNonDiscipline.Location = new System.Drawing.Point(369, 173);
            this.lblNonDiscipline.Name = "lblNonDiscipline";
            this.lblNonDiscipline.Size = new System.Drawing.Size(297, 84);
            this.lblNonDiscipline.TabIndex = 20;
            this.lblNonDiscipline.Text = "Không có dữ liệu kỷ luật nào, bạn có thể click nút \'Thêm\' để thêm mới";
            this.lblNonDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonDiscipline.Visible = false;
            // 
            // panelTitleBarDiscipline
            // 
            this.panelTitleBarDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBarDiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBarDiscipline.Controls.Add(this.btnDeleteDiscipline);
            this.panelTitleBarDiscipline.Controls.Add(this.btnEditDiscipline);
            this.panelTitleBarDiscipline.Controls.Add(this.btnAddDiscipline);
            this.panelTitleBarDiscipline.Location = new System.Drawing.Point(8, 458);
            this.panelTitleBarDiscipline.Name = "panelTitleBarDiscipline";
            this.panelTitleBarDiscipline.Size = new System.Drawing.Size(1008, 71);
            this.panelTitleBarDiscipline.TabIndex = 19;
            // 
            // btnDeleteDiscipline
            // 
            this.btnDeleteDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteDiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDeleteDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiscipline.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDiscipline.Image = global::HumanResourceManagement.Properties.Resources.delete_4219;
            this.btnDeleteDiscipline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDiscipline.Location = new System.Drawing.Point(366, 0);
            this.btnDeleteDiscipline.Name = "btnDeleteDiscipline";
            this.btnDeleteDiscipline.Size = new System.Drawing.Size(177, 71);
            this.btnDeleteDiscipline.TabIndex = 15;
            this.btnDeleteDiscipline.Text = "  Xoá";
            this.btnDeleteDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDiscipline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteDiscipline.UseVisualStyleBackColor = false;
            this.btnDeleteDiscipline.Click += new System.EventHandler(this.btnDeleteDiscipline_Click);
            // 
            // btnEditDiscipline
            // 
            this.btnEditDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditDiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnEditDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiscipline.ForeColor = System.Drawing.Color.White;
            this.btnEditDiscipline.Image = global::HumanResourceManagement.Properties.Resources.sheetandpencil_118361;
            this.btnEditDiscipline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDiscipline.Location = new System.Drawing.Point(183, 0);
            this.btnEditDiscipline.Name = "btnEditDiscipline";
            this.btnEditDiscipline.Size = new System.Drawing.Size(177, 71);
            this.btnEditDiscipline.TabIndex = 14;
            this.btnEditDiscipline.Text = "  Sửa";
            this.btnEditDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDiscipline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditDiscipline.UseVisualStyleBackColor = false;
            this.btnEditDiscipline.Click += new System.EventHandler(this.btnEditDiscipline_Click);
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAddDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscipline.ForeColor = System.Drawing.Color.White;
            this.btnAddDiscipline.Image = global::HumanResourceManagement.Properties.Resources.add_archive_application_4473;
            this.btnAddDiscipline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDiscipline.Location = new System.Drawing.Point(0, 0);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.Size = new System.Drawing.Size(177, 71);
            this.btnAddDiscipline.TabIndex = 11;
            this.btnAddDiscipline.Text = "  Thêm";
            this.btnAddDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDiscipline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDiscipline.UseVisualStyleBackColor = false;
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // dgvDiscipline
            // 
            this.dgvDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiscipline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscipline.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDiscipline.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDiscipline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscipline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDiscipline,
            this.idEmployeeDiscipline,
            this.nameEmployeeDiscipline,
            this.dateStart,
            this.dateEnd,
            this.reasonDiscipline,
            this.descDiscipline});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscipline.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiscipline.Location = new System.Drawing.Point(8, 6);
            this.dgvDiscipline.Name = "dgvDiscipline";
            this.dgvDiscipline.RowHeadersWidth = 51;
            this.dgvDiscipline.RowTemplate.Height = 24;
            this.dgvDiscipline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscipline.Size = new System.Drawing.Size(1008, 446);
            this.dgvDiscipline.TabIndex = 18;
            // 
            // idDiscipline
            // 
            this.idDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDiscipline.DataPropertyName = "id";
            this.idDiscipline.HeaderText = "Số Quyết Định";
            this.idDiscipline.MinimumWidth = 6;
            this.idDiscipline.Name = "idDiscipline";
            this.idDiscipline.Width = 167;
            // 
            // idEmployeeDiscipline
            // 
            this.idEmployeeDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idEmployeeDiscipline.DataPropertyName = "idEmployee";
            this.idEmployeeDiscipline.HeaderText = "Mã Nhân Viên";
            this.idEmployeeDiscipline.MinimumWidth = 6;
            this.idEmployeeDiscipline.Name = "idEmployeeDiscipline";
            this.idEmployeeDiscipline.Width = 164;
            // 
            // nameEmployeeDiscipline
            // 
            this.nameEmployeeDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nameEmployeeDiscipline.DataPropertyName = "nameEmployee";
            this.nameEmployeeDiscipline.HeaderText = "Tên Nhân Viên";
            this.nameEmployeeDiscipline.MinimumWidth = 6;
            this.nameEmployeeDiscipline.Name = "nameEmployeeDiscipline";
            this.nameEmployeeDiscipline.Width = 24;
            // 
            // dateStart
            // 
            this.dateStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dateStart.DataPropertyName = "dateStart";
            this.dateStart.HeaderText = "Ngày BĐ";
            this.dateStart.MinimumWidth = 6;
            this.dateStart.Name = "dateStart";
            this.dateStart.Width = 24;
            // 
            // dateEnd
            // 
            this.dateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dateEnd.DataPropertyName = "dateEnd";
            this.dateEnd.HeaderText = "Ngày KT";
            this.dateEnd.MinimumWidth = 6;
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Width = 24;
            // 
            // reasonDiscipline
            // 
            this.reasonDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.reasonDiscipline.DataPropertyName = "reason";
            this.reasonDiscipline.HeaderText = "Lý Do";
            this.reasonDiscipline.MinimumWidth = 6;
            this.reasonDiscipline.Name = "reasonDiscipline";
            this.reasonDiscipline.Width = 24;
            // 
            // descDiscipline
            // 
            this.descDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descDiscipline.DataPropertyName = "description";
            this.descDiscipline.HeaderText = "Nội Dung";
            this.descDiscipline.MinimumWidth = 6;
            this.descDiscipline.Name = "descDiscipline";
            // 
            // idReward
            // 
            this.idReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idReward.DataPropertyName = "id";
            this.idReward.HeaderText = "Quyết Định";
            this.idReward.MinimumWidth = 6;
            this.idReward.Name = "idReward";
            this.idReward.ReadOnly = true;
            this.idReward.Width = 24;
            // 
            // idEmployeeReward
            // 
            this.idEmployeeReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idEmployeeReward.DataPropertyName = "idEmployee";
            this.idEmployeeReward.HeaderText = "Mã Nhân Viên";
            this.idEmployeeReward.MinimumWidth = 6;
            this.idEmployeeReward.Name = "idEmployeeReward";
            this.idEmployeeReward.ReadOnly = true;
            this.idEmployeeReward.Width = 164;
            // 
            // nameEmployeeReward
            // 
            this.nameEmployeeReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nameEmployeeReward.DataPropertyName = "nameEmployee";
            this.nameEmployeeReward.HeaderText = "Tên Nhân Viên";
            this.nameEmployeeReward.MinimumWidth = 6;
            this.nameEmployeeReward.Name = "nameEmployeeReward";
            this.nameEmployeeReward.ReadOnly = true;
            this.nameEmployeeReward.Width = 24;
            // 
            // reasonReward
            // 
            this.reasonReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.reasonReward.DataPropertyName = "reason";
            this.reasonReward.HeaderText = "Lý Do";
            this.reasonReward.MinimumWidth = 6;
            this.reasonReward.Name = "reasonReward";
            this.reasonReward.ReadOnly = true;
            this.reasonReward.Width = 24;
            // 
            // descriptionReward
            // 
            this.descriptionReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionReward.DataPropertyName = "description";
            this.descriptionReward.HeaderText = "Nội Dung";
            this.descriptionReward.MinimumWidth = 6;
            this.descriptionReward.Name = "descriptionReward";
            this.descriptionReward.ReadOnly = true;
            // 
            // frmRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRate";
            this.Text = "ĐÁNH GIÁ, KHEN THƯỞNG";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelTitleBarReward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReward)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelTitleBarDiscipline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscipline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelTitleBarReward;
        private System.Windows.Forms.Button btnDeleteReward;
        private System.Windows.Forms.Button btnEditReward;
        private System.Windows.Forms.Button btnAddReward;
        private System.Windows.Forms.DataGridView dgvReward;
        private System.Windows.Forms.Panel panelTitleBarDiscipline;
        private System.Windows.Forms.Button btnDeleteDiscipline;
        private System.Windows.Forms.Button btnEditDiscipline;
        private System.Windows.Forms.Button btnAddDiscipline;
        private System.Windows.Forms.DataGridView dgvDiscipline;
        private System.Windows.Forms.Label lblNonReward;
        private System.Windows.Forms.Label lblNonDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmployeeDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmployeeReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionReward;
    }
}