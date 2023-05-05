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
using System.Xml.Linq;

namespace HumanResourceManagement.ChildForms
{
    public partial class frmUpdateDepartment : Form
    {
        public frmUpdateDepartment()
        {
            InitializeComponent();
            LoadTheme();
            UpdateDepartment();
            LoadDepartment();
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

        void UpdateDepartment()
        {
            try
            {
                List<DepartmentDTO> departments = DepartmentDAO.Instance.LoadDepartment();

                foreach (DepartmentDTO department in departments)
                {
                    int quantity = int.Parse(EmployeeDAO.Instance.CountByDepartment(department.IdDepartment).ToString());
                    DepartmentDAO.Instance.UpdateQuantityDepartment(department.IdDepartment, quantity);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadDepartment()
        {
            try
            {
                List<DepartmentDTO> departments = DepartmentDAO.Instance.LoadDepartment();

                dgvDepartment.DataSource = departments;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildForms.Department_Child.frmAddDepartment frmAddDepartment = new ChildForms.Department_Child.frmAddDepartment();
            frmAddDepartment.ShowDialog();
            LoadDepartment();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa có phòng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvDepartment.SelectedRows[0];
            string idDepartment = row.Cells[0].Value.ToString();
            string nameDepartment = row.Cells[1].Value.ToString();
            ChildForms.Department_Child.frmEditDepartment frmAddDepartment = new ChildForms.Department_Child.frmEditDepartment(idDepartment, nameDepartment);
            frmAddDepartment.ShowDialog();
            LoadDepartment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa có phòng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc sẽ xoá phòng ban này không? Sau khi xoá sẽ không thể khôi phục.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvDepartment.SelectedRows[0];
                    string idDepartment = row.Cells[0].Value.ToString();
                    if (DepartmentDAO.Instance.DeleteDepartment(idDepartment))
                    {
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDepartment();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
