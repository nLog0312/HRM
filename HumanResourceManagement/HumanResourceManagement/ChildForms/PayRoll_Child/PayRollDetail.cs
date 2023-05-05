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

namespace HumanResourceManagement.ChildForms.PayRoll_Child
{
    public partial class frmPayRollDetail : Form
    {
        public frmPayRollDetail(string idPayRoll)
        {
            InitializeComponent();
            LoadPayRollDetail(idPayRoll);
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string idPayRoll = dgvPayRollDetail.Rows[0].Cells["idPayRoll"].Value.ToString();
            if (SearchPayRollByName(idPayRoll, txbSearch.Text).Count <= 0)
            {
                MessageBox.Show("Không có nhân viên trùng tên tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSearch.Text = string.Empty;
                return;
            }


            dgvPayRollDetail.DataSource = SearchPayRollByName(idPayRoll, txbSearch.Text);
        }

        List<PayRollDetailDTO> SearchPayRollByName(string id, string name)
        {
            List<PayRollDetailDTO> payRollDetails = PayRollDetailDAO.Instance.SearchPayRollByName(id, name);

            return payRollDetails;
        }

        void LoadPayRollDetail(string idPayRoll)
        {
            try
            {
                List<PayRollDetailDTO> payRollDetails = PayRollDetailDAO.Instance.LoadPayRollDetail(idPayRoll);

                dgvPayRollDetail.DataSource = payRollDetails;
                dgvPayRollDetail.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
