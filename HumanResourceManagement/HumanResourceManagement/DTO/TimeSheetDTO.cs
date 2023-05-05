using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class TimeSheetDTO
    {
        private string idTimeSheet;
        private int month;
        private int year;
        private string date;
        private float dayOfMonth;
        private bool status;

        public TimeSheetDTO(string idTimeSheet, int month, int year, string date, float dayOfMonth, bool status)
        {
            this.idTimeSheet = idTimeSheet;
            this.month = month;
            this.year = year;
            this.date = date;
            this.dayOfMonth = dayOfMonth;
            this.status = status;
        }

        public string IdTimeSheet { get => idTimeSheet; set => idTimeSheet = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public string Date { get => date; set => date = value; }
        public float DayOfMonth { get => dayOfMonth; set => dayOfMonth = value; }
        public bool Status { get => status; set => status = value; }

        public TimeSheetDTO(DataRow row)
        {
            this.idTimeSheet = row["idTimeSheet"].ToString();
            this.month = (int)row["month"];
            this.year = (int)row["year"];
            this.date = row["date"].ToString().Substring(0, 11);
            this.dayOfMonth = (float)Convert.ToDouble(row["dayOfMonth"].ToString());
            this.status = (bool)row["status"];
        }
    }
}
