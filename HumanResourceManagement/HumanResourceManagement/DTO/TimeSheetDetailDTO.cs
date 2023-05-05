using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class TimeSheetDetailDTO
    {
        private string idTimeSheet;
        private string idEmployee;
        private string nameEmployee;
        private int workDay;
        private int excused;
        private int unExcused;
        private int total;

        public TimeSheetDetailDTO(string idTimeSheet, string idEmployee, string nameEmployee, int workDay, int excused, int unExcused, int total)
        {
            this.idTimeSheet = idTimeSheet;
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.workDay = workDay;
            this.excused = excused;
            this.unExcused = unExcused;
            this.total = total;
        }

        public string IdTimeSheet { get => idTimeSheet; set => idTimeSheet = value; }
        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
        public int WorkDay { get => workDay; set => workDay = value; }
        public int Excused { get => excused; set => excused = value; }
        public int UnExcused { get => unExcused; set => unExcused = value; }
        public int Total { get => total; set => total = value; }

        public TimeSheetDetailDTO(DataRow row)
        {
            this.idTimeSheet = row["idTimeSheet"].ToString();
            this.idEmployee = row["idEmployee"].ToString();
            this.nameEmployee = row["nameEmployee"].ToString();
            this.workDay = (int)row["workDay"];
            this.excused = (int)row["excused"];
            this.unExcused = (int)row["unExcused"];
            this.total = (int)row["total"];
        }
    }
}
