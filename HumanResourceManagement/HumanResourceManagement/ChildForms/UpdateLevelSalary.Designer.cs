namespace HumanResourceManagement.ChildForms
{
    partial class frmUpdateLevelSalary
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
            this.lblTitleLevelSalary = new System.Windows.Forms.Label();
            this.dgvLevelSalary = new System.Windows.Forms.DataGridView();
            this.levelSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficientsSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelSalary)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleLevelSalary
            // 
            this.lblTitleLevelSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleLevelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLevelSalary.Location = new System.Drawing.Point(0, 0);
            this.lblTitleLevelSalary.Name = "lblTitleLevelSalary";
            this.lblTitleLevelSalary.Size = new System.Drawing.Size(1032, 58);
            this.lblTitleLevelSalary.TabIndex = 4;
            this.lblTitleLevelSalary.Text = "Danh Sách Bậc Lương Nhân Sự";
            this.lblTitleLevelSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLevelSalary
            // 
            this.dgvLevelSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLevelSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLevelSalary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvLevelSalary.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLevelSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevelSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelSalary,
            this.basicSalary,
            this.coefficientsSalary,
            this.totalSalary});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLevelSalary.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLevelSalary.Location = new System.Drawing.Point(12, 61);
            this.dgvLevelSalary.Name = "dgvLevelSalary";
            this.dgvLevelSalary.ReadOnly = true;
            this.dgvLevelSalary.RowHeadersWidth = 51;
            this.dgvLevelSalary.RowTemplate.Height = 24;
            this.dgvLevelSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLevelSalary.Size = new System.Drawing.Size(1008, 413);
            this.dgvLevelSalary.TabIndex = 3;
            // 
            // levelSalary
            // 
            this.levelSalary.DataPropertyName = "levelSalary";
            this.levelSalary.HeaderText = "Bậc Lương";
            this.levelSalary.MinimumWidth = 6;
            this.levelSalary.Name = "levelSalary";
            this.levelSalary.ReadOnly = true;
            // 
            // basicSalary
            // 
            this.basicSalary.DataPropertyName = "basicSalary";
            this.basicSalary.HeaderText = "Lương Cơ Bản";
            this.basicSalary.MinimumWidth = 6;
            this.basicSalary.Name = "basicSalary";
            this.basicSalary.ReadOnly = true;
            // 
            // coefficientsSalary
            // 
            this.coefficientsSalary.DataPropertyName = "coefficientsSalary";
            this.coefficientsSalary.HeaderText = "Hệ Số Lương";
            this.coefficientsSalary.MinimumWidth = 6;
            this.coefficientsSalary.Name = "coefficientsSalary";
            this.coefficientsSalary.ReadOnly = true;
            // 
            // totalSalary
            // 
            this.totalSalary.DataPropertyName = "totalSalary";
            this.totalSalary.HeaderText = "Lương";
            this.totalSalary.MinimumWidth = 6;
            this.totalSalary.Name = "totalSalary";
            this.totalSalary.ReadOnly = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnDelete);
            this.panelTitleBar.Controls.Add(this.btnEdit);
            this.panelTitleBar.Controls.Add(this.btnAdd);
            this.panelTitleBar.Location = new System.Drawing.Point(12, 480);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 71);
            this.panelTitleBar.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::HumanResourceManagement.Properties.Resources.delete_4219;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(366, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 71);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "  Xoá";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // frmUpdateLevelSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.lblTitleLevelSalary);
            this.Controls.Add(this.dgvLevelSalary);
            this.Name = "frmUpdateLevelSalary";
            this.Text = "CẬP NHẬT BẬC LƯƠNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelSalary)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitleLevelSalary;
        private System.Windows.Forms.DataGridView dgvLevelSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefficientsSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalary;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}