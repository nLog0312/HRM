using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class frmAfterLogin : Form
    {
        // Fields
        private Button currentBtn;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int clickCatalog = 0;
        private int clickSalary = 0;
        private int clickReport = 0;

        public frmAfterLogin()
        {
            InitializeComponent();
            CustomizeDesing();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            btnAdministration.Visible = false;

            lblAccount.Text = frmAccountLogin.Instance.GetUserName();
            int role = frmAccountLogin.Instance.GetRole();

            switch (role)
            {
                case 0:
                    lblRole.Text = "Admin";
                    btnAdministration.Visible = true;
                    break;
                default:
                    lblRole.Text = "Nhân viên";
                    break;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Set Color
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(panelTitleBar.BackColor, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control preBtn in panelSideMenu.Controls)
            {
                preBtn.BackColor = Color.FromArgb(51, 51, 76);
                preBtn.ForeColor = Color.Gainsboro;
                preBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            foreach (Control preBtn in panelSubCatalog.Controls)
            {
                preBtn.BackColor = Color.FromArgb(51, 51, 76);
                preBtn.ForeColor = Color.Gainsboro;
                preBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            foreach (Control preBtn in panelSubSalary.Controls)
            {
                preBtn.BackColor = Color.FromArgb(51, 51, 76);
                preBtn.ForeColor = Color.Gainsboro;
                preBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            foreach (Control preBtn in panelSubReport.Controls)
            {
                preBtn.BackColor = Color.FromArgb(51, 51, 76);
                preBtn.ForeColor = Color.Gainsboro;
                preBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        #endregion

        #region Form Child
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        #endregion

        // Menu Dropdown
        #region Menu Dropdown
        private void CustomizeDesing()
        {
            panelSubCatalog.Visible = false;
            panelSubSalary.Visible = false;
            panelSubReport.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubCatalog.Visible)
            {
                panelSubCatalog.Visible = false;
            }
            if (panelSubSalary.Visible)
            {
                panelSubSalary.Visible = false;
            }
            if (panelSubReport.Visible)
            {
                panelSubReport.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region Catalog Management
        private void btnCatalogManagement_Click(object sender, EventArgs e)
        {
            if (clickCatalog >= 1)
            {
                HideSubMenu();
                if (activeForm != null)
                    activeForm.Close();

                Reset();
                clickCatalog = 0;
            } else
            {
                if (activeForm != null)
                {
                    btnCloseChildForm.Visible = false;
                    activeForm.Close();
                    Reset();
                }
                clickCatalog += 1;
                clickSalary = 0;
                clickReport = 0;
                ActivateButton(sender);
                ShowSubMenu(panelSubCatalog);
            }
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmUpdatePosition());
        }

        private void btnLevelSalary_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmUpdateLevelSalary());
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmUpdateDepartment());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmUpdateEmployee());
        }
        #endregion

        #region Salary Management
        private void btnSalaryManagement_Click(object sender, EventArgs e)
        {
            if (clickSalary >= 1)
            {
                HideSubMenu();
                if (activeForm != null)
                    activeForm.Close();

                Reset();
                clickSalary = 0;
            }
            else
            {
                if (activeForm != null)
                {
                    btnCloseChildForm.Visible = false;
                    activeForm.Close();
                    Reset();
                }
                clickSalary += 1;
                clickCatalog = 0;
                clickReport = 0;
                ActivateButton(sender);
                ShowSubMenu(panelSubSalary);
            }
        }

        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmTimeSheet());
        }

        private void btnPayRoll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmPayRoll());
        }
        #endregion

        #region Report & Rate
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (clickReport >= 1)
            {
                HideSubMenu();
                if (activeForm != null)
                    activeForm.Close();

                Reset();
                clickReport = 0;
            }
            else
            {
                if (activeForm != null)
                {
                    btnCloseChildForm.Visible = false;
                    activeForm.Close();
                    Reset();
                }
                clickReport += 1;
                clickCatalog = 0;
                clickSalary = 0;
                ActivateButton(sender);
                ShowSubMenu(panelSubReport);
            }
        }

        private void btnSubReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmStatistical());
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.frmRate());
        }
        #endregion

        #region Customize Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            Reset();
        }

        private void Reset()
        {
            clickCatalog = 0;
            clickSalary = 0;
            clickReport = 0;
            HideSubMenu();
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentBtn = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizeApp_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            } else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new ChildForms.Acount_Child.frmAllAcount());
        }
    }
}
