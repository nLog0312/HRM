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
    public partial class frmAddPosition : Form
    {
        public frmAddPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int countPosition = int.Parse(PositionDAO.Instance.CountPosition().ToString()) + 1;
            string idPosition = "PO" + countPosition.ToString();
            string namePosition = txbNamePosition.Text;
            string description = txbDescription.Text;

            if (string.IsNullOrEmpty(namePosition))
            {
                MessageBox.Show("Tên phòng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PositionDAO.Instance.InsertPosition(idPosition, namePosition, description))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbNamePosition.Text = string.Empty;
                    txbDescription.Text = string.Empty;
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
            txbNamePosition.Focus();
        }
    }
}
