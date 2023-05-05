namespace HumanResourceManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMain_Exit = new System.Windows.Forms.Button();
            this.btnMain_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMain_Exit
            // 
            this.btnMain_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMain_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain_Exit.Image = global::HumanResourceManagement.Properties.Resources.btnExit;
            this.btnMain_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain_Exit.Location = new System.Drawing.Point(65, 266);
            this.btnMain_Exit.Name = "btnMain_Exit";
            this.btnMain_Exit.Size = new System.Drawing.Size(179, 54);
            this.btnMain_Exit.TabIndex = 1;
            this.btnMain_Exit.Text = "Thoát";
            this.btnMain_Exit.UseVisualStyleBackColor = true;
            this.btnMain_Exit.Click += new System.EventHandler(this.btnMain_Exit_Click);
            // 
            // btnMain_Login
            // 
            this.btnMain_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain_Login.Image = global::HumanResourceManagement.Properties.Resources.btnLogin;
            this.btnMain_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain_Login.Location = new System.Drawing.Point(65, 172);
            this.btnMain_Login.Name = "btnMain_Login";
            this.btnMain_Login.Size = new System.Drawing.Size(179, 54);
            this.btnMain_Login.TabIndex = 0;
            this.btnMain_Login.Text = "Đăng Nhập";
            this.btnMain_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMain_Login.UseVisualStyleBackColor = true;
            this.btnMain_Login.Click += new System.EventHandler(this.btnMain_Login_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnMain_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnMain_Exit;
            this.ClientSize = new System.Drawing.Size(962, 632);
            this.Controls.Add(this.btnMain_Login);
            this.Controls.Add(this.btnMain_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhân Sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMain_Exit;
        private System.Windows.Forms.Button btnMain_Login;
    }
}

