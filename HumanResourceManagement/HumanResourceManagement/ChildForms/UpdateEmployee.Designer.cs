namespace HumanResourceManagement.ChildForms
{
    partial class frmUpdateEmployee
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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1032, 58);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Danh Sách Nhân Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 118);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1008, 453);
            this.dgvEmployee.TabIndex = 2;
            // 
            // idEmployee
            // 
            this.idEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idEmployee.DataPropertyName = "idEmployee";
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
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnLeave);
            this.panelTitleBar.Controls.Add(this.btnEdit);
            this.panelTitleBar.Controls.Add(this.btnAdd);
            this.panelTitleBar.Location = new System.Drawing.Point(12, 577);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 71);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Image = global::HumanResourceManagement.Properties.Resources.sign_out_solid_icon_235722;
            this.btnLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeave.Location = new System.Drawing.Point(366, 0);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(187, 71);
            this.btnLeave.TabIndex = 15;
            this.btnLeave.Text = "  Nghỉ Việc";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::HumanResourceManagement.Properties.Resources.sheetandpencil_118361;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(183, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 71);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "  Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::HumanResourceManagement.Properties.Resources.add_archive_application_4473;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 71);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "  Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.txbSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Location = new System.Drawing.Point(12, 61);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1008, 51);
            this.panelSearch.TabIndex = 0;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(193, 14);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(300, 26);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(19, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(157, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Nhập tên nhân viên:";
            // 
            // frmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 671);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "frmUpdateEmployee";
            this.Text = "CẬP NHẬT NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txbSearch;
    }
}