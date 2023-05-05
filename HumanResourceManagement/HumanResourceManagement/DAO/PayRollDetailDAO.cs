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
    public class PayRollDetailDAO
    {
        private static PayRollDetailDAO instance;

        public static PayRollDetailDAO Instance
        {
            get { if (instance == null) instance = new PayRollDetailDAO(); return PayRollDetailDAO.instance; }
            private set { PayRollDetailDAO.instance = value; }
        }

        private PayRollDetailDAO() { }

        public List<PayRollDetailDTO> LoadPayRollDetail(string idPayRoll)
        {
            List<PayRollDetailDTO> payRollDetails = new List<PayRollDetailDTO>();

            string query = string.Format(
                "EXECUTE Proc_GetPayRollById @IdPayRoll = '{0}'",
                idPayRoll
            );
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                PayRollDetailDTO payRollDetail = new PayRollDetailDTO(row);
                payRollDetails.Add(payRollDetail);
            }

            return payRollDetails;
        }

        public List<PayRollDetailDTO> SearchPayRollByName(string id, string name)
        {
            List<PayRollDetailDTO> payRollDetails = new List<PayRollDetailDTO>();

            string query = string.Format("EXECUTE PROC_GetPayRollLikeName @IdPayRoll = '{0}', @NameEmployee = N'{1}'", id, name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                PayRollDetailDTO payRoll = new PayRollDetailDTO(row);
                payRollDetails.Add(payRoll);
            }

            return payRollDetails;
        }

        public bool InsertPayRollDetail(string idPayRoll, string idEmployee, string idTimeSheet, float salary, string nameEmployee, int total)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE Proc_InsertPayRoll @IdPayRoll = '{0}', @IdTimeSheet = '{2}', @Salary = {3}, @IdEmployee = '{1}', @NameEmployee = N'{4}', @Total = {5}",
                    idPayRoll, idEmployee, idTimeSheet, salary, nameEmployee, total
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

        public bool UpdatePayRollDetail(string idPayRoll, string idEmployee, float salary, int total)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE Proc_UpdatePayRollDetail @IdPayRoll = '{0}', @IdEmployee = '{1}', @Salary = {2}, @Total = {3}",
                    idPayRoll, idEmployee, salary, total
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
    }
}
