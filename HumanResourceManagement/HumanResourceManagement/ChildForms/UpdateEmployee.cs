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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HumanResourceManagement.ChildForms
{
    public partial class frmUpdateEmployee : Form
    {
        public frmUpdateEmployee()
        {
            InitializeComponent();
            LoadTheme();
            LoadEmployee();
        }

        List<EmployeeDTO> SearchEmployeeByName(string name)
        {
            List<EmployeeDTO> employees = EmployeeDAO.Instance.SearchEmployeeByName(name);

            return employees;
        }

        private void LoadTheme()
        {
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBar.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        void LoadEmployee()
        {
            try
            {
                List<EmployeeDTO> employees = EmployeeDAO.Instance.LoadEmployee();

                dgvEmployee.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildForms.Employee_Child.frmAddEmployee frmAddEmployee = new ChildForms.Employee_Child.frmAddEmployee();
            frmAddEmployee.ShowDialog();
            LoadEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn 1 nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvEmployee.SelectedRows[0];
            string idEmployee = row.Cells["idEmployee"].Value.ToString();
            string nameEmployee = row.Cells["nameEmployee"].Value.ToString();
            string date = row.Cells["dateEmployee"].Value.ToString();
            int sex = bool.Parse(row.Cells["sexEmployee"].Value.ToString()) ? 1 : 0;
            string folk = row.Cells["folkEmployee"].Value.ToString();
            string phoneNumber = row.Cells["phoneEmployee"].Value.ToString();
            string address = row.Cells["addressEmployee"].Value.ToString();
            string nameDepartment = row.Cells["idDepartment"].Value.ToString();
            string namePosition = row.Cells["idPosition"].Value.ToString();
            int levelSalary = int.Parse(row.Cells["levelSalary"].Value.ToString());

            ChildForms.Employee_Child.frmEditEmployee frmEditEmployee = new Employee_Child.frmEditEmployee(idEmployee, nameEmployee, date, sex, folk, phoneNumber, address, nameDepartment, namePosition, levelSalary);
            frmEditEmployee.ShowDialog();
            LoadEmployee();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn 1 nhân viên trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn nhân viên này đã nghỉ việc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                string idEmployee = row.Cells["idEmployee"].Value.ToString();

                if (EmployeeDAO.Instance.SetEmployeeLeave(idEmployee))
                {
                    MessageBox.Show("Đã cập nhật nhân viên nghỉ việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    StaticsticalDAO.Instance.InsertStaticstical(month, year, false);
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (SearchEmployeeByName(txbSearch.Text).Count <= 0)
            {
                MessageBox.Show("Không có nhân viên trùng tên tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSearch.Text = string.Empty;
                return;
            }
            dgvEmployee.DataSource = SearchEmployeeByName(txbSearch.Text);
        }
    }
}
