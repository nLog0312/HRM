namespace HumanResourceManagement.ChildForms
{
    partial class frmTimeSheet
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
            this.dgvTimeSheet = new System.Windows.Forms.DataGridView();
            this.idTimeSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1032, 50);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Bảng Công";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTimeSheet
            // 
            this.dgvTimeSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimeSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeSheet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvTimeSheet.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTimeSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTimeSheet,
            this.month,
            this.year,
            this.dateSalary,
            this.dayOfMonth,
            this.status});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimeSheet.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimeSheet.Location = new System.Drawing.Point(12, 150);
            this.dgvTimeSheet.Name = "dgvTimeSheet";
            this.dgvTimeSheet.ReadOnly = true;
            this.dgvTimeSheet.RowHeadersWidth = 51;
            this.dgvTimeSheet.RowTemplate.Height = 24;
            this.dgvTimeSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeSheet.Size = new System.Drawing.Size(1008, 337);
            this.dgvTimeSheet.TabIndex = 11;
            // 
            // idTimeSheet
            // 
            this.idTimeSheet.DataPropertyName = "idTimeSheet";
            this.idTimeSheet.HeaderText = "Mã";
            this.idTimeSheet.MinimumWidth = 6;
            this.idTimeSheet.Name = "idTimeSheet";
            this.idTimeSheet.ReadOnly = true;
            // 
            // month
            // 
            this.month.DataPropertyName = "month";
            this.month.HeaderText = "Tháng";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Năm";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // dateSalary
            // 
            this.dateSalary.DataPropertyName = "date";
            this.dateSalary.HeaderText = "Ngày Tính Công";
            this.dateSalary.MinimumWidth = 6;
            this.dateSalary.Name = "dateSalary";
            this.dateSalary.ReadOnly = true;
            // 
            // dayOfMonth
            // 
            this.dayOfMonth.DataPropertyName = "dayOfMonth";
            this.dayOfMonth.HeaderText = "Số Ngày Công";
            this.dayOfMonth.MinimumWidth = 6;
            this.dayOfMonth.Name = "dayOfMonth";
            this.dayOfMonth.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng Thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbbYear);
            this.panel1.Controls.Add(this.cbbMonth);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 91);
            this.panel1.TabIndex = 13;
            // 
            // cbbYear
            // 
            this.cbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(391, 27);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 28);
            this.cbbYear.TabIndex = 1;
            // 
            // cbbMonth
            // 
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(174, 27);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(121, 28);
            this.cbbMonth.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(341, 30);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 20);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Năm";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(113, 30);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 20);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Tháng";
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
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::HumanResourceManagement.Properties.Resources.eye_visible_hide_hidden_show_icon_145988;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(183, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(177, 71);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "  Xem";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnShow);
            this.panelTitleBar.Controls.Add(this.btnAdd);
            this.panelTitleBar.Location = new System.Drawing.Point(12, 493);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 71);
            this.panelTitleBar.TabIndex = 12;
            // 
            // frmTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvTimeSheet);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "frmTimeSheet";
            this.Text = "CHẤM CÔNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTimeSheet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTimeSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfMonth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}