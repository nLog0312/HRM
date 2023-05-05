using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DAO
{
    public class PayRollDAO
    {
        private static PayRollDAO instance;

        public static PayRollDAO Instance
        {
            get { if (instance == null) instance = new PayRollDAO(); return PayRollDAO.instance; }
            private set { PayRollDAO.instance = value; }
        }

        private PayRollDAO() { }

        public List<PayRollDTO> LoadPayRoll()
        {
            List<PayRollDTO> payRolls = new List<PayRollDTO>();

            string query = "EXECUTE PROC_GetPayRoll";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PayRollDTO payRoll = new PayRollDTO(item);
                payRolls.Add(payRoll);
            }

            return payRolls;
        }

        public bool InsertPayRoll(string idPayRoll, int month, int year, string date)
        {
            string query = string.Format(
                "EXECUTE PROC_AddPayRoll @IdPayRoll = '{0}', @Month = {1}, @Year = {2}, @Date = '{3}'",
                idPayRoll, month, year, date
            );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePayRoll(string idPayRoll)
        {
            string query = string.Format("EXECUTE PROC_UpdatePayRoll @IdPayRoll = '{0}'", idPayRoll);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
