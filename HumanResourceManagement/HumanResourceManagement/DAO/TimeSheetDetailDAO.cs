using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement.DAO
{
    public class TimeSheetDetailDAO
    {
        private static TimeSheetDetailDAO instance;

        public static TimeSheetDetailDAO Instance
        {
            get { if (instance == null) instance = new TimeSheetDetailDAO(); return instance; }
            private set { TimeSheetDetailDAO.instance = value; }
        }

        private TimeSheetDetailDAO() { }

        public List<TimeSheetDetailDTO> LoadTimeSheetDetail(string idTimeSheet)
        {
            List<TimeSheetDetailDTO> timeSheetDetails = new List<TimeSheetDetailDTO>();

            string query = string.Format(
                "EXECUTE PROC_GetTimeSheetById @IdTimeSheet = '{0}'",
                idTimeSheet
            );
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TimeSheetDetailDTO timeSheetDetail = new TimeSheetDetailDTO(row);
                timeSheetDetails.Add(timeSheetDetail);
            }

            return timeSheetDetails;
        }

        public List<TimeSheetDetailDTO> SearchTimeSheetByName(string id, string name)
        {
            List<TimeSheetDetailDTO> timeSheets = new List<TimeSheetDetailDTO>();

            string query = string.Format("EXECUTE PROC_GetTimeSheetLikeName @IdTimeSheet = '{0}', @NameEmployee = N'{1}'", id ,name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TimeSheetDetailDTO timeSheet = new TimeSheetDetailDTO(row);
                timeSheets.Add(timeSheet);
            }

            return timeSheets;
        }

        public bool InsertTimeSheetDetail(string idTimeSheet, string idEmployee, string nameEmployee, int workDay, int excused, int unExcused, int total)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_InsertTimeSheetById @IdTimeSheet = '{0}', @IdEmployee = '{1}', @NameEmployee = N'{2}', @WorkDay = {3}, @Excused = {4}, @UnExcused = {5}, @Total = {6}",
                    idTimeSheet, idEmployee, nameEmployee, workDay, excused, unExcused, total
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public bool UpdateTimeSheetDetail(string idTimeSheet, string idEmployee, int excused, int unExcused, int total)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_UpdateTimeSheetById @IdTimeSheet = '{0}', @IdEmployee = '{1}', @Excused = {2}, @UnExcused = {3}, @Total = {4}",
                    idTimeSheet, idEmployee, excused, unExcused, total
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public int GetTotalTimeSheet(string idTimeSheet, string idEmployee)
        {
            string query = string.Format("EXECUTE PROC_GetToTalTimeSheetById @IdTimeSheet = '{0}', @IdEmployee = '{1}'", idTimeSheet, idEmployee);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return (int)data.Rows[0][0];
        }

        public int GetWorkDayTimeSheet(string idTimeSheet, string idEmployee)
        {
            string query = string.Format("EXECUTE PROC_GetWorkDayTimeSheetById @IdTimeSheet = '{0}', @IdEmployee = '{1}'", idTimeSheet, idEmployee);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return (int)data.Rows[0][0];
        }
    }
}
