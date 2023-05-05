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

namespace HumanResourceManagement.ChildForms.LevelSalary_Child
{
    public partial class frmEditLevelSalary : Form
    {
        public frmEditLevelSalary(string levelSalary, string basicSalary, string coefficientsSalary)
        {
            InitializeComponent();
            txbLevelSalary.Text = levelSalary;
            txbBasicSalary.Text = basicSalary;
            txbCoefficientsSalary.Text = coefficientsSalary;
        }

        private void txbBasicSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbBasicSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                txbBasicSalary.Text = txbBasicSalary.Text.Remove(txbBasicSalary.Text.Length - 1);
            }
        }

        private void txbCoefficientsSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbCoefficientsSalary.Text, "[^0-9 .]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                txbCoefficientsSalary.Text = txbCoefficientsSalary.Text.Remove(txbCoefficientsSalary.Text.Length - 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int levelSalary = int.Parse(txbLevelSalary.Text);
            string basicSalary = txbBasicSalary.Text;
            string coefficientsSalary = txbCoefficientsSalary.Text;

            if (string.IsNullOrEmpty(basicSalary))
            {
                MessageBox.Show("Lương cơ bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (string.IsNullOrEmpty(coefficientsSalary))
                {
                    MessageBox.Show("Hệ số lương không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc sẽ cập nhật lại thông tin bậc lương không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (LevelSalaryDAO.Instance.UpdateLevelSalary(levelSalary, basicSalary, coefficientsSalary))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else return;
                }
            }
        }
    }
}
