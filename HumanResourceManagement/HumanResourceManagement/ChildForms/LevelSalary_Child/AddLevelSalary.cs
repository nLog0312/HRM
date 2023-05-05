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
    public partial class frmAddLevelSalary : Form
    {
        public frmAddLevelSalary()
        {
            InitializeComponent();
        }

        private void txbLevelSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbLevelSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                txbLevelSalary.Text = txbLevelSalary.Text.Remove(txbLevelSalary.Text.Length - 1);
            }
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
            int countLevelSalary = int.Parse(LevelSalaryDAO.Instance.CountLevelSalary().ToString());
            int levelSalary = countLevelSalary + 1;
            string basicSalary = txbBasicSalary.Text;
            string coefficientsSalary = txbCoefficientsSalary.Text;

            if (txbBasicSalary.Text == string.Empty || txbCoefficientsSalary.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (LevelSalaryDAO.Instance.InsertLevelSalary(levelSalary, basicSalary, coefficientsSalary))
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
    }
}
