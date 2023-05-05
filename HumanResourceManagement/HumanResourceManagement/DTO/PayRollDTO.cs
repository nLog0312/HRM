using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class PayRollDTO
    {
        private string idPayRoll;
        private int month;
        private int year;
        private string date;
        private bool status;

        public PayRollDTO(string idPayRoll, int month, int year, string date, bool status)
        {
            this.idPayRoll = idPayRoll;
            this.month = month;
            this.year = year;
            this.date = date;
            this.status = status;
        }

        public string IdPayRoll { get => idPayRoll; set => idPayRoll = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public string Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }

        public PayRollDTO(DataRow row)
        {
            this.idPayRoll = row["idPayRoll"].ToString();
            this.month = (int)row["month"];
            this.year = (int)row["year"];
            this.date = row["date"].ToString().Substring(0, 11);
            this.status = (bool)row["status"];
        }
    }
}
