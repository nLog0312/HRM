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

namespace HumanResourceManagement.ChildForms
{
    public partial class frmRate : Form
    {
        public frmRate()
        {
            InitializeComponent();
            LoadTheme();
            LoadReward();
            LoadDiscipline();
        }

        private void LoadTheme()
        {
            panelTitleBarReward.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBarReward.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            panelTitleBarDiscipline.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBarDiscipline.Controls)
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

        private void LoadReward()
        {
            try
            {
                if (int.Parse(RewardDAO.Instance.CountReward().ToString()) == 0)
                {
                    lblNonReward.Visible = true;
                    dgvReward.Visible = false;
                    return;
                }
                lblNonReward.Visible = false;
                List<RewardDTO> rewards = RewardDAO.Instance.LoadReward();

                dgvReward.DataSource = rewards;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDiscipline()
        {
            try
            {
                if (int.Parse(DisciplineDAO.Instance.CountDiscipline().ToString()) == 0)
                {
                    lblNonDiscipline.Visible = true;
                    dgvDiscipline.Visible = false;
                    return;
                }
                lblNonDiscipline.Visible = false;
                List<DisciplineDTO> disciplines = DisciplineDAO.Instance.LoadDiscipline();

                dgvDiscipline.DataSource = disciplines;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddReward_Click(object sender, EventArgs e)
        {
            ChildForms.Rate_Child.frmAddReward frmAddReward = new Rate_Child.frmAddReward();
            frmAddReward.ShowDialog();
            LoadReward();
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            ChildForms.Rate_Child.frmAddDiscipline frmAddDiscipline = new Rate_Child.frmAddDiscipline();
            frmAddDiscipline.ShowDialog();
            LoadDiscipline();
        }

        private void btnEditReward_Click(object sender, EventArgs e)
        {
            if (dgvReward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn một dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idReward = dgvReward.SelectedRows[0].Cells["idReward"].Value.ToString();
            string idEmployee = dgvReward.SelectedRows[0].Cells["idEmployeeReward"].Value.ToString();
            string reason = dgvReward.SelectedRows[0].Cells["reasonReward"].Value.ToString();
            string desc = dgvReward.SelectedRows[0].Cells["descriptionReward"].Value.ToString();

            ChildForms.Rate_Child.frmEditReward frmEditReward = new Rate_Child.frmEditReward(idReward, idEmployee, reason, desc);
            frmEditReward.ShowDialog();
            LoadReward();
        }

        private void btnEditDiscipline_Click(object sender, EventArgs e)
        {
            if (dgvDiscipline.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn một dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idDiscipline = dgvDiscipline.SelectedRows[0].Cells["idDiscipline"].Value.ToString();
            string idEmployee = dgvDiscipline.SelectedRows[0].Cells["idEmployeeDiscipline"].Value.ToString();
            string reason = dgvDiscipline.SelectedRows[0].Cells["reasonDiscipline"].Value.ToString();
            string desc = dgvDiscipline.SelectedRows[0].Cells["descDiscipline"].Value.ToString();
            string dateStart = dgvDiscipline.SelectedRows[0].Cells["dateStart"].Value.ToString();
            string dateEnd = dgvDiscipline.SelectedRows[0].Cells["dateEnd"].Value.ToString();

            ChildForms.Rate_Child.frmEditDiscipline frmEditDiscipline = new Rate_Child.frmEditDiscipline(idDiscipline, idEmployee, reason, desc, dateStart, dateEnd);
            frmEditDiscipline.ShowDialog();
            LoadDiscipline();
            
        }

        private void btnDeleteReward_Click(object sender, EventArgs e)
        {
            if (dgvReward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn 1 dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvReward.SelectedRows[0].Cells["idReward"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá quyết định số " + id + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RewardDAO.Instance.DeleteReward_Discipline(id))
                {
                    MessageBox.Show("Xoá quyết định" + id + "thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReward();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if (dgvReward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn 1 dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string id = dgvDiscipline.SelectedRows[0].Cells["idDiscipline"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá quyết định số " + id + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RewardDAO.Instance.DeleteReward_Discipline(id))
                {
                    MessageBox.Show("Xoá quyết định" + id + "thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDiscipline();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
