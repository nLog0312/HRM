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

namespace HumanResourceManagement.ChildForms
{
    public partial class frmTimeSheet : Form
    {
        public frmTimeSheet()
        {
            InitializeComponent();
            LoadTheme();
            LoadTimeSheet();

            for (int i = 2020; i <= DateTime.Now.Year; i++)
            {
                cbbYear.Items.Add(i.ToString());
            }
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

        void LoadTimeSheet()
        {
            try
            {
                List<TimeSheetDTO> timeSheets = TimeSheetDAO.Instance.LoadTimeSheet();

                dgvTimeSheet.DataSource = timeSheets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbMonth.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbYear.Text == "")
            {
                MessageBox.Show("Vui lòng chọn năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int month = int.Parse(cbbMonth.Text);
            int year = int.Parse(cbbYear.Text);
            string idTimeSheet = "TS" + month.ToString("00") + year.ToString();
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            int dayOfMonth = FunctionSupport.CountNumber(month, year);
            bool status = false;

            if (TimeSheetDAO.Instance.InsertTimeSheet(idTimeSheet, month, year, date, dayOfMonth, status))
            {
                // Create timesheet detail
                try
                {
                    List<EmployeeDTO> employees = EmployeeDAO.Instance.LoadEmployee();

                    foreach (EmployeeDTO employee in employees)
                    {
                        string idEmployee = employee.IdEmployee;
                        string nameEmployee = employee.NameEmployee;

                        if (TimeSheetDetailDAO.Instance.InsertTimeSheetDetail(idTimeSheet, idEmployee, nameEmployee, dayOfMonth, 0, 0, dayOfMonth))
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Create pay roll
                string idPayRoll = "PR" + month.ToString("00") + year.ToString();
                if (PayRollDAO.Instance.InsertPayRoll(idPayRoll, month, year, date))
                {
                    // Create timesheet detail
                    try
                    {
                        List<EmployeeDTO> employees = EmployeeDAO.Instance.LoadEmployee();

                        foreach (EmployeeDTO employee in employees)
                        {
                            string idEmployee = employee.IdEmployee;
                            string nameEmployee = employee.NameEmployee;
                            float basicSalary = EmployeeDAO.Instance.GetBassicSalaryByID(idEmployee);
                            float coefficientSalary = EmployeeDAO.Instance.GetCoefficientSalaryByID(idEmployee);
                            int workDay = TimeSheetDetailDAO.Instance.GetWorkDayTimeSheet(idTimeSheet, idEmployee);
                            int total = dayOfMonth;

                            float payDay = (basicSalary * coefficientSalary) / total;
                            float salary = payDay * total;

                            if (PayRollDetailDAO.Instance.InsertPayRollDetail(idPayRoll, idEmployee, idTimeSheet, salary, nameEmployee, total))
                            {
                                continue;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadTimeSheet();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvTimeSheet.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn một kỳ công trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvTimeSheet.SelectedRows[0];
            string idTimeSheet = row.Cells["idTimeSheet"].Value.ToString();
            int month = int.Parse(row.Cells["month"].Value.ToString());
            int year = int.Parse(row.Cells["year"].Value.ToString());

            ChildForms.TimeSheet_Child.frmTimeSheetDetail frmTimeSheetDetail = new ChildForms.TimeSheet_Child.frmTimeSheetDetail(idTimeSheet);
            frmTimeSheetDetail.ShowDialog();
            if (TimeSheetDAO.Instance.UpdateTimeSheet(idTimeSheet))
            {
                LoadTimeSheet();
                return;
            }
        }
    }
}
