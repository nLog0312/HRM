using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DAO
{
    public class LevelSalaryDAO
    {
        private static LevelSalaryDAO instance;

        public static LevelSalaryDAO Instance
        {
            get { if (instance == null) instance = new LevelSalaryDAO(); return instance; }
            private set { LevelSalaryDAO.instance = value; }
        }

        private LevelSalaryDAO() { }

        public List<LevelSalaryDTO> LoadLevelSalary()
        {
            List<LevelSalaryDTO> levelSalaries = new List<LevelSalaryDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE PROC_GetLevelSalary");

            foreach (DataRow row in data.Rows)
            {
                LevelSalaryDTO levelSalary = new LevelSalaryDTO(row);
                levelSalaries.Add(levelSalary);
            }

            return levelSalaries;
        }

        public object CountLevelSalary()
        {
            try
            {
                string query = "EXECUTE PROC_CountLevelSalary";
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }
        }
        public bool InsertLevelSalary(int levelSalary, string basicSalary, string coefficientsSalary)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_InsertLevelSalary @levelSalary = {0}, @basicSalary = {1}, @coefficientsSalary = {2}",
                    levelSalary,basicSalary, coefficientsSalary
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateLevelSalary(int levelSalary, string basicSalary, string coefficientsSalary)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_UpdateLevelSalary @levelSalary = {0}, @basicSalary = {1}, @coefficientsSalary = {2}",
                    levelSalary, basicSalary, coefficientsSalary
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteLevelSalary(int levelSalary)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_DeleteLevelSalary @levelSalary = {0}",
                    levelSalary
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
