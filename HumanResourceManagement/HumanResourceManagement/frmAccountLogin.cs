using HumanResourceManagement.DAO;
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
    public partial class frmAccountLogin : Form
    {
        private static string userNameText;
        private static int roleText;
        public frmAccountLogin()
        {
            InitializeComponent();
        }
        private void frmAccountLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txbAL_UserName.Focus();
        }
        bool Login(string userName, string password)
        {
            return UserLoginDAO.Instance.Login(userName, password);
        }

        private void btnAL_Login_Click(object sender, EventArgs e)
        {
            string userName = txbAL_UserName.Text;
            string password = txbAL_Password.Text;
            if (Login(userName, password))
            {
                userNameText = txbAL_UserName.Text;
                roleText = UserLoginDAO.Instance.GetRole(userName);
                this.Hide();
                frmAfterLogin frmAfterLogin = new frmAfterLogin();
                frmAfterLogin.ShowDialog();
                this.Show();
                txbAL_UserName.Text = "";
                txbAL_Password.Text = "";
                txbAL_UserName.Focus();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void btnAL_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static frmAccountLogin instance;

        public static frmAccountLogin Instance
        {
            get { if (instance == null) instance = new frmAccountLogin(); return instance; }
            private set { instance = value; }
        }

        public string GetUserName()
        {
            return userNameText;
        }

        public int GetRole()
        {
            return roleText;
        }
    }
}
