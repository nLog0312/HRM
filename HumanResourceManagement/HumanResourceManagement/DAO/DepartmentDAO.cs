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
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;

        public DepartmentDAO() { }

        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return instance; }
            private set { DepartmentDAO.instance = value; }
        }

        public List<DepartmentDTO> LoadDepartment()
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE PROC_GetDepartment");

            foreach (DataRow row in data.Rows)
            {
                DepartmentDTO department = new DepartmentDTO(row);
                departments.Add(department);
            }

            return departments;
        }

        public object CountDepartment()
        {
            try
            {
                string query = "EXECUTE PROC_CountDepartment";
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }
        }

        public bool InsertDepartment(string idDepartment, string nameDepartment)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_InsertDepartment @idDepartment = '{0}', @nameDepartment = N'{1}'",
                    idDepartment, nameDepartment
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDepartment(string idDepartment, string nameDepartment)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_UpdateDepartment @idDepartment = '{0}', @nameDepartment = N'{1}'",
                    idDepartment, nameDepartment
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDepartment(string idDepartment)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_DeleteDepartment @idDepartment = '{0}'",
                    idDepartment
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateQuantityDepartment(string idDepartment, int quantity)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_UpdateQuantityDepartment @idDepartment = '{0}', @Quantity = {1}",
                    idDepartment, quantity
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
