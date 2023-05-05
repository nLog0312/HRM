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
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { EmployeeDAO.instance = value; }
        }

        private EmployeeDAO() { }

        public List<EmployeeDTO> LoadEmployee()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE PROC_GetEmployee");

            foreach (DataRow row in data.Rows)
            {
                if (bool.Parse(row["leave"].ToString()))
                    continue;

                EmployeeDTO employee = new EmployeeDTO(row);
                employees.Add(employee);
            }

            return employees;
        }

        public List<EmployeeDTO> SearchEmployeeByName(string name)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            string query = string.Format("EXECUTE PROC_GetEmployeeLikeName @NameEmployee = N'{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                if (bool.Parse(row["leave"].ToString()))
                    continue;

                EmployeeDTO employee = new EmployeeDTO(row);
                employees.Add(employee);
            }

            return employees;
        }

        public object CountEmployee()
        {
            try
            {
                string query = "EXECUTE PROC_CountEmployee";
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            } catch
            {
                return 0;
            }
        }

        public bool InsertEmployee(string id, string name, string date, int sex, string folk, string phoneNumber, string address, string idDepartment, string idPosition, int levelSalary, int leave)
        {
            try
            {
                string query = "EXECUTE PROC_InsertEmployee @IdEmployee , @Name , @Date  , @Sex , @Folk , @PhoneNumber , @Address , @IdDepartment , @IdPosition , @LevelSalary , @Leave ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {id, name, date, sex, folk, phoneNumber, address, idDepartment, idPosition, levelSalary, leave});

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public bool UpdateEmployee(string id, string name, string date, int sex, string folk, string phoneNumber, string address, string idDepartment, string idPosition, int levelSalary, int leave)
        {
            try
            {
                string query = "EXECUTE PROC_UpdateEmployee @IdEmployee , @Name , @Date  , @Sex , @Folk , @PhoneNumber , @Address , @IdDepartment , @IdPosition , @LevelSalary , @Leave ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, date, sex, folk, phoneNumber, address, idDepartment, idPosition, levelSalary, leave });

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public bool SetEmployeeLeave(string id)
        {
            try
            {
                string query = "EXECUTE PROC_UpdateLeaveEmployee @IdEmployee ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public string GetNameEmployee(string id)
        {
            try
            {
                string query = string.Format("EXECUTE PROC_GetNameEmployee @IdEmployee = '{0}'", id);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                return data.Rows[0][0].ToString();
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return "";
            }
        }

        public float GetBassicSalaryByID(string id)
        {
            try
            {
                string query = string.Format("EXECUTE PROC_GetBassicSalaryByID @IdEmployee = '{0}'", id);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                float basicSalary = float.Parse(data.Rows[0][0].ToString());

                return basicSalary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return 0;
            }
        }

        public float GetCoefficientSalaryByID(string id)
        {
            try
            {
                string query = string.Format("EXECUTE PROC_GetCoefficientSalarySalaryByID @IdEmployee = '{0}'", id);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                float coefficientsSalary = float.Parse(data.Rows[0][0].ToString());

                return coefficientsSalary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return 0;
            }
        }

        public object CountEmployeeMale()
        {
            try
            {
                string query = "EXECUTE PROC_CountEmployeeMale";
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }
        }

        public object CountEmployeeFemale()
        {
            try
            {
                string query = "EXECUTE PROC_CountEmployeeFemale";
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }
        }

        public object CountByDepartment(string idDepartment)
        {
            try
            {
                string query = string.Format("EXECUTE PROC_CountByDepartment @IdDepartment = {0}", idDepartment);
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
