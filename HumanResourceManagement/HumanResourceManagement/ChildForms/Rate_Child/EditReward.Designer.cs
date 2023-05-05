namespace HumanResourceManagement.ChildForms.Rate_Child
{
    partial class frmEditReward
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelIdEmployee = new System.Windows.Forms.Panel();
            this.cbbIdEmployee = new System.Windows.Forms.ComboBox();
            this.lblIdEmployee = new System.Windows.Forms.Label();
            this.panelNameEmployee = new System.Windows.Forms.Panel();
            this.txbNameEmployee = new System.Windows.Forms.TextBox();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.panelReason = new System.Windows.Forms.Panel();
            this.txbReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.panelDesc = new System.Windows.Forms.Panel();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelId = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panelIdEmployee.SuspendLayout();
            this.panelNameEmployee.SuspendLayout();
            this.panelReason.SuspendLayout();
            this.panelDesc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelId.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(826, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sửa Khen Thưởng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Location = new System.Drawing.Point(168, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 49);
            this.btnSave.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(11, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panelIdEmployee
            // 
            this.panelIdEmployee.Controls.Add(this.cbbIdEmployee);
            this.panelIdEmployee.Controls.Add(this.lblIdEmployee);
            this.panelIdEmployee.Location = new System.Drawing.Point(11, 153);
            this.panelIdEmployee.Name = "panelIdEmployee";
            this.panelIdEmployee.Size = new System.Drawing.Size(327, 60);
            this.panelIdEmployee.TabIndex = 0;
            // 
            // cbbIdEmployee
            // 
            this.cbbIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIdEmployee.FormattingEnabled = true;
            this.cbbIdEmployee.Location = new System.Drawing.Point(93, 18);
            this.cbbIdEmployee.Name = "cbbIdEmployee";
            this.cbbIdEmployee.Size = new System.Drawing.Size(155, 28);
            this.cbbIdEmployee.TabIndex = 1;
            this.cbbIdEmployee.SelectedIndexChanged += new System.EventHandler(this.cbbIdEmployee_SelectedIndexChanged);
            // 
            // lblIdEmployee
            // 
            this.lblIdEmployee.AutoSize = true;
            this.lblIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmployee.Location = new System.Drawing.Point(7, 17);
            this.lblIdEmployee.Name = "lblIdEmployee";
            this.lblIdEmployee.Size = new System.Drawing.Size(73, 25);
            this.lblIdEmployee.TabIndex = 0;
            this.lblIdEmployee.Text = "Mã NV";
            // 
            // panelNameEmployee
            // 
            this.panelNameEmployee.Controls.Add(this.txbNameEmployee);
            this.panelNameEmployee.Controls.Add(this.lblNameEmployee);
            this.panelNameEmployee.Location = new System.Drawing.Point(402, 68);
            this.panelNameEmployee.Name = "panelNameEmployee";
            this.panelNameEmployee.Size = new System.Drawing.Size(327, 60);
            this.panelNameEmployee.TabIndex = 1;
            // 
            // txbNameEmployee
            // 
            this.txbNameEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNameEmployee.Enabled = false;
            this.txbNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameEmployee.Location = new System.Drawing.Point(93, 13);
            this.txbNameEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNameEmployee.Name = "txbNameEmployee";
            this.txbNameEmployee.ReadOnly = true;
            this.txbNameEmployee.Size = new System.Drawing.Size(231, 32);
            this.txbNameEmployee.TabIndex = 4;
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.Location = new System.Drawing.Point(7, 17);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(80, 25);
            this.lblNameEmployee.TabIndex = 0;
            this.lblNameEmployee.Text = "Tên NV";
            // 
            // panelReason
            // 
            this.panelReason.Controls.Add(this.txbReason);
            this.panelReason.Controls.Add(this.lblReason);
            this.panelReason.Location = new System.Drawing.Point(11, 238);
            this.panelReason.Name = "panelReason";
            this.panelReason.Size = new System.Drawing.Size(327, 60);
            this.panelReason.TabIndex = 2;
            // 
            // txbReason
            // 
            this.txbReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReason.Location = new System.Drawing.Point(93, 13);
            this.txbReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbReason.Name = "txbReason";
            this.txbReason.Size = new System.Drawing.Size(231, 32);
            this.txbReason.TabIndex = 4;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(7, 17);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(60, 25);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "Lý do";
            // 
            // panelDesc
            // 
            this.panelDesc.Controls.Add(this.txbDesc);
            this.panelDesc.Controls.Add(this.lblDesc);
            this.panelDesc.Location = new System.Drawing.Point(402, 153);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(410, 240);
            this.panelDesc.TabIndex = 3;
            // 
            // txbDesc
            // 
            this.txbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesc.Location = new System.Drawing.Point(103, 13);
            this.txbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(304, 223);
            this.txbDesc.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(7, 17);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(90, 25);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Nội dung";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panelDesc);
            this.panel1.Controls.Add(this.panelReason);
            this.panel1.Controls.Add(this.panelNameEmployee);
            this.panel1.Controls.Add(this.panelId);
            this.panel1.Controls.Add(this.panelIdEmployee);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 499);
            this.panel1.TabIndex = 5;
            // 
            // panelId
            // 
            this.panelId.Controls.Add(this.txbId);
            this.panelId.Controls.Add(this.lblId);
            this.panelId.Location = new System.Drawing.Point(11, 68);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(327, 60);
            this.panelId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(7, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Số QĐ";
            // 
            // txbId
            // 
            this.txbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(93, 14);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(231, 32);
            this.txbId.TabIndex = 4;
            // 
            // frmEditReward
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(842, 515);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditReward";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditReward";
            this.panelIdEmployee.ResumeLayout(false);
            this.panelIdEmployee.PerformLayout();
            this.panelNameEmployee.ResumeLayout(false);
            this.panelNameEmployee.PerformLayout();
            this.panelReason.ResumeLayout(false);
            this.panelReason.PerformLayout();
            this.panelDesc.ResumeLayout(false);
            this.panelDesc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelId.ResumeLayout(false);
            this.panelId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelIdEmployee;
        private System.Windows.Forms.ComboBox cbbIdEmployee;
        private System.Windows.Forms.Label lblIdEmployee;
        private System.Windows.Forms.Panel panelNameEmployee;
        private System.Windows.Forms.TextBox txbNameEmployee;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Panel panelReason;
        private System.Windows.Forms.TextBox txbReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Panel panelDesc;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;
    }
}