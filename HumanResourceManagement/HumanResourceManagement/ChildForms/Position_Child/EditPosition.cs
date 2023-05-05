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

namespace HumanResourceManagement.ChildForms.Position_Child
{
    public partial class frmEditPosition : Form
    {
        public frmEditPosition(string idPosition, string namePosition, string descPosition)
        {
            InitializeComponent();
            txbIdPosition.Text = idPosition;
            txbNamePosition.Text = namePosition;
            txbDescription.Text = descPosition;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbIdPosition.Text;
            string name = txbNamePosition.Text;
            string desc = txbDescription.Text;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên chức vụ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc sẽ cập nhật lại thông tin bậc lương không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PositionDAO.Instance.UpdatePosition(id, name, desc))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else return;
        }
    }
}
