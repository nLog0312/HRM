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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HumanResourceManagement.ChildForms
{
    public partial class frmUpdateLevelSalary : Form
    {
        public frmUpdateLevelSalary()
        {
            InitializeComponent();
            LoadTheme();
            LoadLevelSalary();
        }

        private void LoadTheme()
        {
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBar.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        

        void LoadLevelSalary()
        {
            try
            {
                List<LevelSalaryDTO> levelSalaries = LevelSalaryDAO.Instance.LoadLevelSalary();
                dgvLevelSalary.DataSource = levelSalaries;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LevelSalary_Child.frmAddLevelSalary frmAddLevelSalary = new LevelSalary_Child.frmAddLevelSalary();
            frmAddLevelSalary.ShowDialog();
            LoadLevelSalary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvLevelSalary.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa có bậc lương nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvLevelSalary.SelectedRows[0];
            string levelSalary = row.Cells[0].Value.ToString();
            string basicSalary = row.Cells[1].Value.ToString();
            string coefficientsSalary = row.Cells[2].Value.ToString();
            ChildForms.LevelSalary_Child.frmEditLevelSalary frmEditLevelSalary = new ChildForms.LevelSalary_Child.frmEditLevelSalary(levelSalary, basicSalary, coefficientsSalary);
            frmEditLevelSalary.ShowDialog();
            LoadLevelSalary();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLevelSalary.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bảng lương nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgvLevelSalary.SelectedRows[0];
            int levelSalary = int.Parse(row.Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá bảng lương này không? Sau khi xoá sẽ không thể khôi phục.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (LevelSalaryDAO.Instance.DeleteLevelSalary(levelSalary))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLevelSalary();
                }
                else MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else return;
        }
    }
}
