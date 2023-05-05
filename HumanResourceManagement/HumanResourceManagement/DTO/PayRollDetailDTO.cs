using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class PayRollDetailDTO
    {
        private string idPayRoll;
        private string idEmployee;
        private string idTimeSheet;
        private string nameEmployee;
        private int total;
        private string salary;

        public PayRollDetailDTO(string idPayRoll, string idEmployee, string idTimeSheet, string nameEmployee, int total, string salary)
        {
            this.idPayRoll = idPayRoll;
            this.idEmployee = idEmployee;
            this.idTimeSheet = idTimeSheet;
            this.nameEmployee = nameEmployee;
            this.total = total;
            this.salary = salary;
        }

        public string IdPayRoll { get => idPayRoll; set => idPayRoll = value; }
        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string IdTimeSheet { get => idTimeSheet; set => idTimeSheet = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
        public int Total { get => total; set => total = value; }
        public string Salary { get => salary; set => salary = value; }

        public PayRollDetailDTO(DataRow row)
        {
            this.idPayRoll = row["idPayRoll"].ToString();
            this.idEmployee = row["idEmployee"].ToString();
            this.idTimeSheet = row["idTimeSheet"].ToString();
            this.nameEmployee = row["nameEmployee"].ToString();
            this.total = int.Parse(row["total"].ToString());
            this.salary = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", float.Parse(row["salary"].ToString()));
        }
    }
}
