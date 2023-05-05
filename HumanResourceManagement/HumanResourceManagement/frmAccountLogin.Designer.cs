namespace HumanResourceManagement
{
    partial class frmAccountLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txbAL_Password = new System.Windows.Forms.TextBox();
            this.txbAL_UserName = new System.Windows.Forms.TextBox();
            this.btnAL_Exit = new System.Windows.Forms.Button();
            this.btnAL_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.txbAL_Password);
            this.panelLogin.Controls.Add(this.txbAL_UserName);
            this.panelLogin.Controls.Add(this.btnAL_Exit);
            this.panelLogin.Controls.Add(this.btnAL_Login);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogin.Location = new System.Drawing.Point(0, 182);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(597, 274);
            this.panelLogin.TabIndex = 0;
            // 
            // txbAL_Password
            // 
            this.txbAL_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAL_Password.Location = new System.Drawing.Point(237, 122);
            this.txbAL_Password.Name = "txbAL_Password";
            this.txbAL_Password.Size = new System.Drawing.Size(243, 36);
            this.txbAL_Password.TabIndex = 1;
            this.txbAL_Password.UseSystemPasswordChar = true;
            // 
            // txbAL_UserName
            // 
            this.txbAL_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAL_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAL_UserName.Location = new System.Drawing.Point(237, 32);
            this.txbAL_UserName.Name = "txbAL_UserName";
            this.txbAL_UserName.Size = new System.Drawing.Size(243, 36);
            this.txbAL_UserName.TabIndex = 0;
            // 
            // btnAL_Exit
            // 
            this.btnAL_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAL_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAL_Exit.Location = new System.Drawing.Point(311, 203);
            this.btnAL_Exit.Name = "btnAL_Exit";
            this.btnAL_Exit.Size = new System.Drawing.Size(169, 45);
            this.btnAL_Exit.TabIndex = 3;
            this.btnAL_Exit.Text = "Thoát";
            this.btnAL_Exit.UseVisualStyleBackColor = true;
            this.btnAL_Exit.Click += new System.EventHandler(this.btnAL_Exit_Click);
            // 
            // btnAL_Login
            // 
            this.btnAL_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAL_Login.Location = new System.Drawing.Point(104, 203);
            this.btnAL_Login.Name = "btnAL_Login";
            this.btnAL_Login.Size = new System.Drawing.Size(169, 45);
            this.btnAL_Login.TabIndex = 2;
            this.btnAL_Login.Text = "Đăng Nhập";
            this.btnAL_Login.UseVisualStyleBackColor = true;
            this.btnAL_Login.Click += new System.EventHandler(this.btnAL_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài Khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HumanResourceManagement.Properties.Resources.diagram;
            this.pictureBox1.Location = new System.Drawing.Point(207, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmAccountLogin
            // 
            this.AcceptButton = this.btnAL_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnAL_Exit;
            this.ClientSize = new System.Drawing.Size(597, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmAccountLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnAL_Exit;
        private System.Windows.Forms.Button btnAL_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbAL_UserName;
        private System.Windows.Forms.TextBox txbAL_Password;
    }
}