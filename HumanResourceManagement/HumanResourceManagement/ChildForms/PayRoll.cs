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
    public partial class frmPayRoll : Form
    {
        public frmPayRoll()
        {
            InitializeComponent();
            LoadTheme();
            LoadPayRoll();
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

        void LoadPayRoll()
        {
            try
            {
                List<PayRollDTO> payRolls = PayRollDAO.Instance.LoadPayRoll();

                dgvPayRoll.DataSource = payRolls;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvPayRoll.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn một kỳ công trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPayRoll.SelectedRows[0];
            string idPayRoll = row.Cells["idPayRoll"].Value.ToString();

            ChildForms.PayRoll_Child.frmPayRollDetail frmPayRollDetail = new ChildForms.PayRoll_Child.frmPayRollDetail(idPayRoll);
            frmPayRollDetail.ShowDialog();
            if (PayRollDAO.Instance.UpdatePayRoll(idPayRoll))
            {
                LoadPayRoll();
                return;
            }
        }
    }
}
