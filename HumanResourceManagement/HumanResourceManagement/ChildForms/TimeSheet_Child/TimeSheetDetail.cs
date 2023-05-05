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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HumanResourceManagement.ChildForms.TimeSheet_Child
{
    public partial class frmTimeSheetDetail : Form
    {
        public frmTimeSheetDetail(string idTimeSheet)
        {
            InitializeComponent();
            LoadTimeSheetDetail(idTimeSheet);
        }

        void LoadTimeSheetDetail(string idTimeSheet)
        {
            try
            {
                List<TimeSheetDetailDTO> timeSheets = TimeSheetDetailDAO.Instance.LoadTimeSheetDetail(idTimeSheet);

                dgvTimeSheetDetail.DataSource = timeSheets;
                dgvTimeSheetDetail.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string idTimeSheet = dgvTimeSheetDetail.Rows[0].Cells["idTimeSheet"].Value.ToString();
            if (SearchTimeSheetByName(idTimeSheet, txbSearch.Text).Count <= 0)
            {
                MessageBox.Show("Không có nhân viên trùng tên tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSearch.Text = string.Empty;
                return;
            }


            dgvTimeSheetDetail.DataSource = SearchTimeSheetByName(idTimeSheet, txbSearch.Text);
        }

        List<TimeSheetDetailDTO> SearchTimeSheetByName(string id, string name)
        {
            List<TimeSheetDetailDTO> timeSheets = TimeSheetDetailDAO.Instance.SearchTimeSheetByName(id, name);

            return timeSheets;
        }

        private void dgvTimeSheetDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTimeSheetDetail.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần phải chọn một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvTimeSheetDetail.SelectedRows[0];
            string idTimeSheet = row.Cells["idTimeSheet"].Value.ToString();
            string idEmployee = row.Cells["idEmployee"].Value.ToString();
            string nameEmployee = row.Cells["nameEmployee"].Value.ToString();
            int workDay = int.Parse(row.Cells["workDay"].Value.ToString());
            int excused = int.Parse(row.Cells["excused"].Value.ToString());
            int unExcused = int.Parse(row.Cells["unExcused"].Value.ToString());
            int total = int.Parse(row.Cells["total"].Value.ToString());

            txbId.Text = idTimeSheet;
            txbIdEmployee.Text = idEmployee;
            txbName.Text = nameEmployee;
            nmrWorđay.Value = workDay;
            nmrExcused.Value = excused;
            nmrUnexcused.Value = unExcused;
            nmrTotal.Value = total;
        }

        private void nmrExcused_ValueChanged(object sender, EventArgs e)
        {
            if (nmrWorđay.Value == 0) return;
            nmrTotal.Value = nmrWorđay.Value - nmrExcused.Value - nmrUnexcused.Value;
        }

        private void nmrUnexcused_ValueChanged(object sender, EventArgs e)
        {
            if (nmrWorđay.Value == 0) return;
            nmrTotal.Value = nmrWorđay.Value - nmrExcused.Value - nmrUnexcused.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idTimeSheet;
            string idEmployee;
            string nameEmployee;
            int excused;
            int unExcused;
            int total;

            idTimeSheet = txbId.Text;
            if (idTimeSheet == string.Empty)
            {
                MessageBox.Show("Bạn cần phải chọn một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idPayRoll = "PR" + idTimeSheet.Substring(2);
            idEmployee = txbIdEmployee.Text;
            nameEmployee = txbName.Text;
            excused = int.Parse(nmrExcused.Value.ToString());
            unExcused = int.Parse(nmrUnexcused.Value.ToString());
            total = int.Parse(nmrTotal.Value.ToString());
            int dayOfMonth = TimeSheetDetailDAO.Instance.GetWorkDayTimeSheet(idTimeSheet, idEmployee);
            float basicSalary = EmployeeDAO.Instance.GetBassicSalaryByID(idEmployee);
            float coefficientSalary = EmployeeDAO.Instance.GetCoefficientSalaryByID(idEmployee);
            float payDay = (basicSalary * coefficientSalary) / dayOfMonth;
            float salary = payDay * total;

            if (TimeSheetDetailDAO.Instance.UpdateTimeSheetDetail(idTimeSheet, idEmployee, excused, unExcused, total))
            {
                if (PayRollDetailDAO.Instance.UpdatePayRollDetail(idPayRoll, idEmployee, salary, total))
                {
                    MessageBox.Show("Cập nhật bảng công nhân viên " + nameEmployee + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadTimeSheetDetail(idTimeSheet);
            }
            else
            {
                MessageBox.Show("Cập nhật bảng công nhân viên " + nameEmployee + " thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
