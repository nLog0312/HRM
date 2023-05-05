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
    public partial class frmUpdatePosition : Form
    {
        public frmUpdatePosition()
        {
            InitializeComponent();
            LoadTheme();
            LoadPosition();
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

        void LoadPosition()
        {
            try
            {
                List<PositionDTO> positions = PositionDAO.Instance.LoadPosition();

                dgvPosition.DataSource = positions;
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildForms.Position_Child.frmAddPosition frmAddPosition = new Position_Child.frmAddPosition();
            frmAddPosition.ShowDialog();
            LoadPosition();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa có chức vụ nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPosition.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string desc = row.Cells[2].Value.ToString();
            ChildForms.Position_Child.frmEditPosition frmEditPosition = new Position_Child.frmEditPosition(id, name, desc);
            frmEditPosition.ShowDialog();
            LoadPosition();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa có chức vụ nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPosition.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PositionDAO.Instance.DeletePosition(id))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPosition();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
        }
    }
}
