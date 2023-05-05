using HumanResourceManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement.ChildForms.Department_Child
{
    public partial class frmEditDepartment : Form
    {
        public frmEditDepartment(string idDepartment, string nameDepartment)
        {
            InitializeComponent();
            txbIdDepartment.Text = idDepartment;
            txbNameDepartment.Text = nameDepartment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string idDepartment = txbIdDepartment.Text;
            string nameDepartment = txbNameDepartment.Text;

            if (string.IsNullOrEmpty(nameDepartment))
            {
                MessageBox.Show("Tên phòng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc cập nhật lại thông tin phòng ban không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DepartmentDAO.Instance.UpdateDepartment(idDepartment, nameDepartment))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
