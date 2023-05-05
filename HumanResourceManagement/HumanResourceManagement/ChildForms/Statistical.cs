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
    public partial class frmStatistical : Form
    {
        public frmStatistical()
        {
            InitializeComponent();
            LoadQuantityEmployee();
            LoadBirthDay();
            LoadChart();
        }

        void LoadQuantityEmployee()
        {
            string quantity = EmployeeDAO.Instance.CountEmployee().ToString();
            lblTotal.Text = quantity;
            lblTitleNew.Text = "Số Nhân Viên Mới Tháng " + DateTime.Now.Month.ToString();
            lblTitleLeave.Text = "Số Nhân Viên Nghỉ Tháng " + DateTime.Now.Month.ToString();

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string employeeIn = StaticsticalDAO.Instance.CountStaticsticalIn(month, year).ToString();
            lblNew.Text = employeeIn;
            string employeeLeave = StaticsticalDAO.Instance.CountStaticsticalLeave(month, year).ToString();
            lblLeave.Text = employeeLeave;
        }
        
        void LoadBirthDay()
        {
            DateTime dateTimeNow = DateTime.Now;
            try
            {
                List<EmployeeDTO> employees = EmployeeDAO.Instance.LoadEmployee();

                foreach (EmployeeDTO employee in employees)
                {
                    DateTime date = DateTime.Parse(employee.DateEmployee);
                    if ((date.Day - dateTimeNow.Day) <= 7 && (date.Month == dateTimeNow.Month))
                    {
                        string item = string.Format(
                            "{0}, ngày sinh {1}",
                            employee.NameEmployee, employee.DateEmployee
                        );
                        lvBirthDay.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadChart()
        {
            int quantityMale = int.Parse(EmployeeDAO.Instance.CountEmployeeMale().ToString());
            int quantityFemale = int.Parse(EmployeeDAO.Instance.CountEmployeeFemale().ToString());
            int quantity = int.Parse(lblTotal.Text);
            chart1.Titles.Add("Thống Kê Nhân Viên Theo Giới Tính");

            //chart1.Series["Sex"].Points.AddXY("Nam", Math.Round((1.0 * quantityMale / quantity * 100), 2));
            //chart1.Series["Sex"].Points.AddXY("Nữ", Math.Round((1.0 * quantityFemale / quantity * 100), 2));

            chart1.Series["Sex"].Points.Add(Math.Round((1.0 * quantityMale / quantity * 100), 2));
            chart1.Series["Sex"].Points[0].AxisLabel = "Nam";
            chart1.Series["Sex"].Points[0].LegendText = "Nam";
            chart1.Series["Sex"].Points[0].Label = Math.Round((1.0 * quantityMale / quantity * 100), 2) + "%";

            chart1.Series["Sex"].Points.Add(Math.Round((1.0 * quantityFemale / quantity * 100), 2));
            chart1.Series["Sex"].Points[1].AxisLabel = "Nữ";
            chart1.Series["Sex"].Points[1].LegendText = "Nữ";
            chart1.Series["Sex"].Points[1].Label = Math.Round((1.0 * quantityFemale / quantity * 100), 2) + "%";
        }
    }
}
