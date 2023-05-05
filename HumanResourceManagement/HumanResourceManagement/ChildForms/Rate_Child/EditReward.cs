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
    public partial class frmEditReward : Form
    {
        public frmEditReward(string idReward, string idEmployee, string reason, string desc)
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

            txbId.Text = idReward;
            cbbIdEmployee.SelectedIndex = cbbIdEmployee.FindStringExact(idEmployee);
            txbNameEmployee.Text = nameEmployee;
            txbReason.Text = reason;
            txbDesc.Text = desc;
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
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật lại chiếc khen thưởng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string id = txbId.Text;
                string idEmployee = cbbIdEmployee.SelectedValue.ToString();
                string nameEmployee = txbNameEmployee.Text;
                string reason = txbReason.Text;
                string desc = txbDesc.Text;

                if (RewardDAO.Instance.UpdateReward(id, idEmployee, nameEmployee, reason, desc))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
