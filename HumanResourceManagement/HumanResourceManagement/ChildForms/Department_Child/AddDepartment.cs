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
    public partial class frmAddDepartment : Form
    {
        public frmAddDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int countDepartment = int.Parse(DepartmentDAO.Instance.CountDepartment().ToString()) + 1;
            string idDepartment = "DE" + countDepartment.ToString();
            string nameDepartment = txbNameDepartment.Text;

            if (string.IsNullOrEmpty(nameDepartment))
            {
                MessageBox.Show("Tên phòng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DepartmentDAO.Instance.InsertDepartment(idDepartment, nameDepartment))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txbNameDepartment.Focus();
        }
    }
}
