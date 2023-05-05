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

namespace HumanResourceManagement.ChildFormPosition
{
    public partial class frmAddPosition : Form
    {
        public frmAddPosition()
        {
            InitializeComponent();
        }

        void RefreshInput()
        {
            txbIdPosition.Text = string.Empty;
            txbNamePosition.Text = string.Empty;
            txbDescription.Text = string.Empty;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string countPosition = PositionDAO.Instance.CountPosition().ToString();
            string id = "PO" + (int.Parse(countPosition) + 1).ToString();

            string name = txbNamePosition.Text;
            string description = txbDescription.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên chức vụ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PositionDAO.Instance.InsertPosition(id, name, description))
                {
                    MessageBox.Show("Thêm chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshInput();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txbNamePosition.Focus();
        }
    }
}
