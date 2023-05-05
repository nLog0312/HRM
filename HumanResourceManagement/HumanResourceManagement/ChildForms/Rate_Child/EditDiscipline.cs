using HumanResourceManagement.DAO;
using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement.ChildForms.Rate_Child
{
    public partial class frmEditDiscipline : Form
    {
        public frmEditDiscipline(string idDiscipline, string idEmployee, string reason, string desc, string dateStart, string dateEnd)
        {
            InitializeComponent();
            try
            {
                List<EmployeeDTO> employees = EmployeeDAO.Instance.LoadEmployee();

                cbbIdEmployee.DataSource = employees;
                cbbIdEmployee.DisplayMember = "IdEmployee";
                cbbIdEmployee.ValueMember = "IdEmployee";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nameEmployee = EmployeeDAO.Instance.GetNameEmployee(idEmployee);

            txbId.Text = idDiscipline;
            cbbIdEmployee.SelectedIndex = cbbIdEmployee.FindStringExact(idEmployee);
            txbNameEmployee.Text = nameEmployee;
            txbReason.Text = reason;
            txbDesc.Text = desc;
            dtDateStart.Text = dateStart;
            dtDateEnd.Text = dateEnd;
        }

        private void cbbIdEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEmployee = cbbIdEmployee.SelectedValue.ToString();
            if (!idEmployee.Contains("NV"))
            {
                return;
            }
            string nameEmployee = EmployeeDAO.Instance.GetNameEmployee(idEmployee);
            txbNameEmployee.Text = nameEmployee;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật chiếc kỷ luật này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string id = txbId.Text;
                string idEmployee = cbbIdEmployee.SelectedValue.ToString();
                string nameEmployee = txbNameEmployee.Text;
                string reason = txbReason.Text;
                string desc = txbDesc.Text;
                string dateStart = dtDateStart.Value.ToString("yyyy/MM/dd");
                string dateEnd = dtDateEnd.Value.ToString("yyyy/MM/dd");

                if (DisciplineDAO.Instance.UpdateDiscipline(id, idEmployee, nameEmployee, reason, desc, dateStart, dateEnd))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
