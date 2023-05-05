using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DAO
{
    public class TimeSheetDAO
    {
        private static TimeSheetDAO instance;

        public static TimeSheetDAO Instance 
        {
            get { if (instance == null) instance = new TimeSheetDAO(); return instance; }
            private set { TimeSheetDAO.instance = value; }
        }

        private TimeSheetDAO() { }

        public List<TimeSheetDTO> LoadTimeSheet()
        {
            List<TimeSheetDTO> timeSheets = new List<TimeSheetDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE PROC_GetTimeSheet");

            foreach (DataRow row in data.Rows)
            {
                TimeSheetDTO timeSheet = new TimeSheetDTO(row);
                timeSheets.Add(timeSheet);
            }

            return timeSheets;
        }

        public string GetIdTimeSheet(int month, int year)
        {
            string idTimeSheet;
            string query = string.Format("EXECUTE PROC_GetIdTimeSheet @Month = {0}, @Year = {1}", month, year);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count <=0 )
            {
                return "";
            }
            idTimeSheet = data.Rows[0]["idTimeSheet"].ToString();

            return idTimeSheet;
        }
        public bool InsertTimeSheet(string idTimeSheet, int month, int year, string date, int dayOfMonth, bool status)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_InsertTimeSheet @IdTimeSheet = '{0}', @Month = {1}, @Year = {2}, @Date = '{3}', @DayOfMonth = {4}, @Status = {5}",
                    idTimeSheet, month, year, date, dayOfMonth, status
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTimeSheet(string idTimeSheet)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_UpdateStatusTimeSheet @IdTimeSheet = '{0}'",
                    idTimeSheet
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
