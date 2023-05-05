namespace HumanResourceManagement.ChildForms.Acount_Child
{
    partial class frmAllAcount
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
            this.lblTitlePosition = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpAcount = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbEye = new System.Windows.Forms.PictureBox();
            this.ptbRefresh = new System.Windows.Forms.PictureBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePosition
            // 
            this.lblTitlePosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitlePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePosition.Location = new System.Drawing.Point(0, 0);
            this.lblTitlePosition.Name = "lblTitlePosition";
            this.lblTitlePosition.Size = new System.Drawing.Size(1032, 45);
            this.lblTitlePosition.TabIndex = 10;
            this.lblTitlePosition.Text = "Danh Sách Tài Khoản";
            this.lblTitlePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnDelete);
            this.panelTitleBar.Controls.Add(this.btnEdit);
            this.panelTitleBar.Controls.Add(this.btnAdd);
            this.panelTitleBar.Location = new System.Drawing.Point(12, 493);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1008, 71);
            this.panelTitleBar.TabIndex = 1;
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
            this.btnDelete.TabIndex = 2;
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
            this.btnEdit.TabIndex = 1;
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
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "  Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flpAcount
            // 
            this.flpAcount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAcount.Location = new System.Drawing.Point(12, 73);
            this.flpAcount.Name = "flpAcount";
            this.flpAcount.Size = new System.Drawing.Size(571, 414);
            this.flpAcount.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ptbEye);
            this.panel1.Controls.Add(this.ptbRefresh);
            this.panel1.Controls.Add(this.txbDesc);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(589, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 414);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ptbEye
            // 
            this.ptbEye.Image = global::HumanResourceManagement.Properties.Resources.eye_slash_visible_hide_hidden_show_icon_145987;
            this.ptbEye.Location = new System.Drawing.Point(389, 135);
            this.ptbEye.Name = "ptbEye";
            this.ptbEye.Size = new System.Drawing.Size(30, 30);
            this.ptbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEye.TabIndex = 20;
            this.ptbEye.TabStop = false;
            this.ptbEye.Click += new System.EventHandler(this.ptbEye_Click);
            this.ptbEye.MouseLeave += new System.EventHandler(this.ptbEye_MouseLeave);
            this.ptbEye.MouseHover += new System.EventHandler(this.ptbEye_MouseHover);
            // 
            // ptbRefresh
            // 
            this.ptbRefresh.Image = global::HumanResourceManagement.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.ptbRefresh.Location = new System.Drawing.Point(379, 3);
            this.ptbRefresh.Name = "ptbRefresh";
            this.ptbRefresh.Size = new System.Drawing.Size(40, 40);
            this.ptbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbRefresh.TabIndex = 19;
            this.ptbRefresh.TabStop = false;
            this.ptbRefresh.Click += new System.EventHandler(this.ptbRefresh_Click);
            this.ptbRefresh.MouseLeave += new System.EventHandler(this.ptbRefresh_MouseLeave);
            this.ptbRefresh.MouseHover += new System.EventHandler(this.ptbRefresh_MouseHover);
            // 
            // txbDesc
            // 
            this.txbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesc.Location = new System.Drawing.Point(139, 188);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(249, 155);
            this.txbDesc.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(139, 134);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(249, 32);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(139, 86);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(249, 32);
            this.txbUserName.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 190);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 26);
            this.lblDesc.TabIndex = 16;
            this.lblDesc.Text = "Mô Tả";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 26);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 89);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 26);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "Tài Khoản";
            // 
            // frmAllAcount
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpAcount);
            this.Controls.Add(this.lblTitlePosition);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "frmAllAcount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllAcount";
            this.panelTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePosition;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpAcount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox ptbRefresh;
        private System.Windows.Forms.PictureBox ptbEye;
    }
}