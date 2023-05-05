namespace HumanResourceManagement.ChildForms.PayRoll_Child
{
    partial class frmPayRollDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPayRollDetail = new System.Windows.Forms.DataGridView();
            this.idPayRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTimeSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayRollDetail)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dgvPayRollDetail);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 585);
            this.panel1.TabIndex = 0;
            // 
            // dgvPayRollDetail
            // 
            this.dgvPayRollDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayRollDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayRollDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPayRollDetail.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPayRollDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayRollDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPayRoll,
            this.idEmployee,
            this.idTimeSheet,
            this.nameEmployee,
            this.total,
            this.salary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayRollDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayRollDetail.Location = new System.Drawing.Point(4, 4);
            this.dgvPayRollDetail.Name = "dgvPayRollDetail";
            this.dgvPayRollDetail.ReadOnly = true;
            this.dgvPayRollDetail.RowHeadersWidth = 51;
            this.dgvPayRollDetail.RowTemplate.Height = 24;
            this.dgvPayRollDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayRollDetail.Size = new System.Drawing.Size(1011, 511);
            this.dgvPayRollDetail.TabIndex = 33;
            // 
            // idPayRoll
            // 
            this.idPayRoll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idPayRoll.DataPropertyName = "idPayRoll";
            this.idPayRoll.HeaderText = "Mã";
            this.idPayRoll.MinimumWidth = 6;
            this.idPayRoll.Name = "idPayRoll";
            this.idPayRoll.ReadOnly = true;
            this.idPayRoll.Width = 24;
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
            this.idTimeSheet.HeaderText = "Mã Bảng Công";
            this.idTimeSheet.MinimumWidth = 6;
            this.idTimeSheet.Name = "idTimeSheet";
            this.idTimeSheet.ReadOnly = true;
            this.idTimeSheet.Width = 24;
            // 
            // nameEmployee
            // 
            this.nameEmployee.DataPropertyName = "nameEmployee";
            this.nameEmployee.HeaderText = "Tên Nhân Viên";
            this.nameEmployee.MinimumWidth = 6;
            this.nameEmployee.Name = "nameEmployee";
            this.nameEmployee.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Tổng Số Công";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 84;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Lương";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 24;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txbSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Location = new System.Drawing.Point(4, 521);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(605, 59);
            this.panelSearch.TabIndex = 32;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(265, 16);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(337, 26);
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(865, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 49);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmPayRollDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1035, 601);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayRollDetail";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayRollDetail";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayRollDetail)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPayRollDetail;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPayRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTimeSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}