namespace HumanResourceManagement.ChildForms.Department_Child
{
    partial class frmAddDepartment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNameDepartment = new System.Windows.Forms.Panel();
            this.txbNameDepartment = new System.Windows.Forms.TextBox();
            this.lblNameDepartment = new System.Windows.Forms.Label();
            this.panelIdDepartment = new System.Windows.Forms.Panel();
            this.txbIdDepartment = new System.Windows.Forms.TextBox();
            this.lblIdDepartment = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelNameDepartment.SuspendLayout();
            this.panelIdDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panelNameDepartment);
            this.panel1.Controls.Add(this.panelIdDepartment);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 519);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelNameDepartment
            // 
            this.panelNameDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNameDepartment.Controls.Add(this.txbNameDepartment);
            this.panelNameDepartment.Controls.Add(this.lblNameDepartment);
            this.panelNameDepartment.Location = new System.Drawing.Point(127, 228);
            this.panelNameDepartment.Name = "panelNameDepartment";
            this.panelNameDepartment.Size = new System.Drawing.Size(509, 55);
            this.panelNameDepartment.TabIndex = 0;
            // 
            // txbNameDepartment
            // 
            this.txbNameDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNameDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameDepartment.Location = new System.Drawing.Point(176, 10);
            this.txbNameDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNameDepartment.Name = "txbNameDepartment";
            this.txbNameDepartment.Size = new System.Drawing.Size(330, 36);
            this.txbNameDepartment.TabIndex = 4;
            // 
            // lblNameDepartment
            // 
            this.lblNameDepartment.AutoSize = true;
            this.lblNameDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDepartment.Location = new System.Drawing.Point(7, 17);
            this.lblNameDepartment.Name = "lblNameDepartment";
            this.lblNameDepartment.Size = new System.Drawing.Size(109, 25);
            this.lblNameDepartment.TabIndex = 0;
            this.lblNameDepartment.Text = "Tên Phòng";
            // 
            // panelIdDepartment
            // 
            this.panelIdDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIdDepartment.Controls.Add(this.txbIdDepartment);
            this.panelIdDepartment.Controls.Add(this.lblIdDepartment);
            this.panelIdDepartment.Location = new System.Drawing.Point(127, 139);
            this.panelIdDepartment.Name = "panelIdDepartment";
            this.panelIdDepartment.Size = new System.Drawing.Size(509, 55);
            this.panelIdDepartment.TabIndex = 3;
            // 
            // txbIdDepartment
            // 
            this.txbIdDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdDepartment.Location = new System.Drawing.Point(176, 10);
            this.txbIdDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIdDepartment.Name = "txbIdDepartment";
            this.txbIdDepartment.ReadOnly = true;
            this.txbIdDepartment.Size = new System.Drawing.Size(330, 36);
            this.txbIdDepartment.TabIndex = 4;
            // 
            // lblIdDepartment
            // 
            this.lblIdDepartment.AutoSize = true;
            this.lblIdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDepartment.Location = new System.Drawing.Point(7, 17);
            this.lblIdDepartment.Name = "lblIdDepartment";
            this.lblIdDepartment.Size = new System.Drawing.Size(102, 25);
            this.lblIdDepartment.TabIndex = 0;
            this.lblIdDepartment.Text = "Mã Phòng";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(327, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Location = new System.Drawing.Point(484, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(156, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm Phòng Ban, Đơn Vị Mới";
            // 
            // frmAddDepartment
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddDepartment";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNameDepartment.ResumeLayout(false);
            this.panelNameDepartment.PerformLayout();
            this.panelIdDepartment.ResumeLayout(false);
            this.panelIdDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNameDepartment;
        private System.Windows.Forms.TextBox txbNameDepartment;
        private System.Windows.Forms.Label lblNameDepartment;
        private System.Windows.Forms.Panel panelIdDepartment;
        private System.Windows.Forms.TextBox txbIdDepartment;
        private System.Windows.Forms.Label lblIdDepartment;
    }
}