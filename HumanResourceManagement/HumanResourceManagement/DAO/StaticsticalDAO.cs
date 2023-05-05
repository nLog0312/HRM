using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement.DAO
{
    public class StaticsticalDAO
    {
        private static StaticsticalDAO instance;

        public static StaticsticalDAO Instance
        {
            get { if (instance == null) instance = new StaticsticalDAO(); return instance; }
            private set { StaticsticalDAO.instance = value; }
        }

        private StaticsticalDAO() { }

        public bool InsertStaticstical(int month, int year, bool type)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE InsertStaticstical @Month = {0}, @Year = {1}, @Type = {2}",
                    month, year, type
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public object CountStaticsticalIn(int month, int year)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE CountStaticsticalIn @Month = {0}, @Year = {1}",
                    month, year
                );
                object result = DataProvider.Instance.ExecuteScalar(query);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return 0;
            }
        }

        public object CountStaticsticalLeave(int month, int year)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE CountStaticsticalLeave @Month = {0}, @Year = {1}",
                    month, year
                );
                object result = DataProvider.Instance.ExecuteScalar(query);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return 0;
            }
        }
    }
}
