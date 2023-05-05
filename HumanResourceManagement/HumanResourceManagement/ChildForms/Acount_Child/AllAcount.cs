using HumanResourceManagement.DAO;
using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement.ChildForms.Acount_Child
{
    public partial class frmAllAcount : Form
    {
        string currentPassword;
        public frmAllAcount()
        {
            InitializeComponent();
            LoadTheme();
            LoadAcount();
        }

        private void LoadTheme()
        {
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBar.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        void RefreshInput()
        {
            txbUserName.Text = string.Empty;
            txbPassword.Text = string.Empty;
            txbDesc.Text = string.Empty;
        }
        void LoadAcount()
        {
            flpAcount.Controls.Clear();            
            List<UserDTO> users = UserLoginDAO.Instance.LoadUser();

            foreach (UserDTO user in users)
            {
                Button button = new Button() { Width = UserLoginDAO.Width, Height = UserLoginDAO.Height};
                if (user.Role == 0)
                {
                    button.Text = string.Format(
                        "Tài Khoản: {0}\nQuyền: {1}",
                        user.UserName, "Quản Trị Viên"
                    );
                } else
                {
                    button.Text = string.Format(
                        "Tài Khoản: {0}\nQuyền: {1}\nMô Tả: {2}",
                        user.UserName, "Nhân Viên", user.DescAcount
                    );
                }
                button.TextAlign = ContentAlignment.TopLeft;
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.Click += btn_Click;
                button.Tag = user;

                flpAcount.Controls.Add(button);
            }
            RefreshInput();
        }

        void btn_Click(object sender, EventArgs e)
        {
            UserDTO user = ((sender as Button).Tag as UserDTO);

            txbUserName.Text = user.UserName;
            txbPassword.Text = user.Password;
            txbDesc.Text = user.DescAcount;
            txbUserName.Enabled = false;
            txbUserName.ReadOnly = true;
            txbUserName.BorderStyle = BorderStyle.None;
            currentPassword = user.Password;
            btnAdd.Enabled = false;

            if (user.Role == 0)
            {
                btnDelete.Enabled = false;
            } else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassword.Text;
            string description = txbDesc.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    if (UserLoginDAO.Instance.InsertAccount(userName, password, description))
                    {
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAcount();
                    } else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txbUserName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string newPassword = txbPassword.Text;
            string description = txbDesc.Text;

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (newPassword != currentPassword)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn đổi mật khẩu mới?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        if (UserLoginDAO.Instance.UpdateAccount(userName, newPassword, description))
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAcount();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } else return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc sẽ xoá tài khoản này? Sau khi xoá sẽ không thể khôi phục.", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (UserLoginDAO.Instance.DeleteAccount(userName))
                {
                    MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAcount();
                }
                else
                {
                    MessageBox.Show("Xoá tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #region Button Refresh
        private void ptbRefresh_MouseHover(object sender, EventArgs e)
        {
            ptbRefresh.BackColor = Color.Gainsboro;
        }

        private void ptbRefresh_MouseLeave(object sender, EventArgs e)
        {
            ptbRefresh.BackColor = Color.Empty;
        }

        private void ptbRefresh_Click(object sender, EventArgs e)
        {
            txbUserName.Enabled = true;
            txbUserName.ReadOnly = false;
            txbUserName.BorderStyle = BorderStyle.FixedSingle;
            txbUserName.Text = string.Empty;
            txbPassword.Text = string.Empty;
            txbDesc.Text = string.Empty;
            btnAdd.Enabled = true;
        }
        #endregion

        #region Button Eye
        private void ptbEye_MouseHover(object sender, EventArgs e)
        {
            ptbEye.BackColor = Color.Gainsboro;
        }

        private void ptbEye_MouseLeave(object sender, EventArgs e)
        {
            ptbEye.BackColor = Color.Empty;
        }
        int checkEye = 0;
        private void ptbEye_Click(object sender, EventArgs e)
        {
            if (checkEye == 0)
            {
                ptbEye.Image = HumanResourceManagement.Properties.Resources.eye_visible_hide_hidden_show_icon_145988;
                txbPassword.UseSystemPasswordChar = false;
                checkEye = 1;
            } else
            {
                ptbEye.Image = HumanResourceManagement.Properties.Resources.eye_slash_visible_hide_hidden_show_icon_145987;
                txbPassword.UseSystemPasswordChar = true;
                checkEye = 0;
            }
        }
        #endregion
    }
}
