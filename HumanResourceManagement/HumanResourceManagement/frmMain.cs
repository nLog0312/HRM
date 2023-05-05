using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.btnMain_Login.Image = (Image)(new Bitmap(HumanResourceManagement.Properties.Resources.btnLogin, new Size(30, 30)));
            this.btnMain_Exit.Image = (Image)(new Bitmap(HumanResourceManagement.Properties.Resources.btnExit, new Size(30, 30)));
        }

        private void btnMain_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMain_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountLogin frmAL = new frmAccountLogin();
            frmAL.ShowDialog();
            this.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
