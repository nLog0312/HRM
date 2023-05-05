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
    public class DisciplineDAO
    {
        private static DisciplineDAO instance;

        public static DisciplineDAO Instance
        {
            get { if (instance == null) instance = new DisciplineDAO(); return instance; }
            private set { DisciplineDAO.instance = value; }
        }

        private DisciplineDAO() { }

        public List<DisciplineDTO> LoadDiscipline()
        {
            List<DisciplineDTO> disciplines = new List<DisciplineDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE GetDiscipline");

            foreach (DataRow row in data.Rows)
            {
                DisciplineDTO discipline = new DisciplineDTO(row);
                disciplines.Add(discipline);
            }

            return disciplines;
        }

        public object CountDiscipline()
        {
            try
            {
                object result = DataProvider.Instance.ExecuteScalar("EXECUTE CountDiscipline");
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return 0;
            }
        }

        public bool InsertDiscipline(string id, string idEmployee, string nameEmployee, string reason, string desc, string dateStart, string dateEnd)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE InsertDiscipline @Id = '{0}', @IdEmployee = '{1}', @NameEmployee = N'{2}', @Reason = N'{3}', @Description = N'{4}', @DateStart = '{5}', @DateEnd = '{6}'",
                    id, idEmployee, nameEmployee, reason, desc, dateStart, dateEnd
                );
                int result = DataProvider.Instance.ExecuteNonQuery( query );

                return result > 0;

            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
                return false;
            }
        }

        public bool UpdateDiscipline(string id, string idEmployee, string nameEmployee, string reason, string desc, string dateStart, string dateEnd)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE UpdateDiscipline @Id = '{0}', @IdEmployee = '{1}', @NameEmployee = N'{2}', @Reason = N'{3}', @Description = N'{4}', @DateStart = '{5}', @DateEnd = '{6}'",
                    id, idEmployee, nameEmployee, reason, desc, dateStart, dateEnd
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
