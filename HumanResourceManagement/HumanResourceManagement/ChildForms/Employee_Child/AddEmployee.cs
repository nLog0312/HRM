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

namespace HumanResourceManagement.ChildForms.Employee_Child
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
            LoadEmployee();
        }

        void LoadEmployee()
        {
            try
            {
                List<EmployeeDTO> employees = EmployeeDAO.Instance.LoadEmployee();
                dgvEmployee.DataSource = employees;

                List<DepartmentDTO> departments = DepartmentDAO.Instance.LoadDepartment();
                List<PositionDTO> positions = PositionDAO.Instance.LoadPosition();
                List<LevelSalaryDTO> levelSalaries = LevelSalaryDAO.Instance.LoadLevelSalary();

                cbbDepartment.DataSource = departments;
                cbbDepartment.DisplayMember = "nameDepartment";
                cbbDepartment.ValueMember = "idDepartment";
                cbbDepartment.SelectedIndex = 0;

                cbbPosition.DataSource = positions;
                cbbPosition.DisplayMember = "namePosition";
                cbbPosition.ValueMember = "idPosition";

                cbbLevelSalary.DataSource = levelSalaries;
                cbbLevelSalary.DisplayMember = "levelSalary";
                cbbLevelSalary.ValueMember = "levelSalary";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                txbPhone.Text = txbPhone.Text.Remove(txbPhone.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtDate.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Vui lòng nhập năm sinh nhỏ hơn năm hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if ((DateTime.Now.Year - dtDate.Value.Year) < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if (cbbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Giới tính không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int quantityEmployee = (int)EmployeeDAO.Instance.CountEmployee();
            string idEmployee = "NV" + (quantityEmployee + 1).ToString("000000");
            string nameEmployee = txbName.Text;
            string date = dtDate.Value.ToString("yyyy/MM/dd");
            int sex = cbbSex.SelectedIndex;
            string folk = txbFolk.Text;
            string phoneNumber = txbPhone.Text;
            string address = txbAddress.Text;
            string idDepartment = cbbDepartment.SelectedValue.ToString();
            string idPosition = cbbPosition.SelectedValue.ToString();
            int levelSalary = int.Parse(cbbLevelSalary.SelectedValue.ToString());
            int leave = 0;


            if (string.IsNullOrEmpty(nameEmployee) || string.IsNullOrEmpty(folk) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Thông tin điền bị thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (EmployeeDAO.Instance.InsertEmployee(idEmployee, nameEmployee, date, sex, folk, phoneNumber, address, idDepartment, idPosition, levelSalary, leave))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    StaticsticalDAO.Instance.InsertStaticstical(month, year, true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
