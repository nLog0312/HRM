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
    public class RewardDAO
    {
        private static RewardDAO instance;

        public static RewardDAO Instance
        {
            get { if (instance == null) instance = new RewardDAO(); return instance; }
            private set { RewardDAO.instance = value; }
        }

        private RewardDAO() { }

        public List<RewardDTO> LoadReward()
        {
            List<RewardDTO> rewards = new List<RewardDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE GetReward");

            foreach (DataRow row in data.Rows)
            {
                RewardDTO reward = new RewardDTO(row);
                rewards.Add(reward);
            }

            return rewards;
        }

        public object CountReward()
        {
            try
            {
                object result = DataProvider.Instance.ExecuteScalar("EXECUTE CountReward");
                return result;
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return 0;
            }
        }

        public bool InsertReward(string id, string idEmployee, string nameEmployee, string reason, string desc)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE InsertReward @Id = '{0}', @IdEmployee = '{1}', @NameEmployee = N'{2}', @Reason = N'{3}', @Description = N'{4}'",
                    id, idEmployee, nameEmployee, reason, desc
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

        public bool UpdateReward(string id, string idEmployee, string nameEmployee, string reason, string desc)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE UpdateReward @Id = '{0}', @IdEmployee = '{1}', @NameEmployee = N'{2}', @Reason = N'{3}', @Description = N'{4}'",
                    id, idEmployee, nameEmployee, reason, desc
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

        public bool DeleteReward_Discipline(string id)
        {
            try
            {
                string query = string.Format("EXECUTE DeleteReward_Discipline @Id = '{0}'", id);
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
