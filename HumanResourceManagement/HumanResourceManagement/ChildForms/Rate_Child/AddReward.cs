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

namespace HumanResourceManagement.ChildForms.Rate_Child
{
    public partial class frmAddReward : Form
    {
        public frmAddReward()
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
            string idEmployee = cbbIdEmployee.SelectedValue.ToString();
            string nameEmployee = EmployeeDAO.Instance.GetNameEmployee(idEmployee);
            txbNameEmployee.Text = nameEmployee;
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
            string id = "QĐ/" + DateTime.Now.ToString("ddMMyyyymmss"); // "QL" + "ddMMyyyyHHmmss"
            string idEmployee = cbbIdEmployee.SelectedValue.ToString();
            string nameEmployee = txbNameEmployee.Text;
            string reason = txbReason.Text;
            string description = txbDesc.Text;

            if (RewardDAO.Instance.InsertReward(id, idEmployee, nameEmployee, reason, description))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
