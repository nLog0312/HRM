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
    public class PositionDAO
    {
        private static  PositionDAO instance;

        public static PositionDAO Instance
        {
            get { if (instance == null) instance = new PositionDAO(); return instance; }
            private set { PositionDAO.instance = value; }
        }

        private PositionDAO() { }

        public List<PositionDTO> LoadPosition()
        {
            List<PositionDTO> positions = new List<PositionDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE PROC_GetPosition");

            foreach (DataRow row in data.Rows)
            {
                PositionDTO position = new PositionDTO(row);
                positions.Add(position);
            }

            return positions;
        }

        public object CountPosition()
        {
            try
            {
                string query = "EXECUTE PROC_GetCountPosition";
                object result = DataProvider.Instance.ExecuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }
        }
        public bool InsertPosition(string idPosition, string namePosition, string descriptionPosition)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_AddPosition @IdPosition = '{0}', @NamePosition = N'{1}', @DesPosition = N'{2}'",
                    idPosition, namePosition, descriptionPosition
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePosition(string idPosition, string namePosition, string descriptionPosition)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_UpdatePosition @IdPosition = '{0}', @NamePosition = N'{1}', @DesPosition = N'{2}'",
                    idPosition, namePosition, descriptionPosition
                );
                int result = DataProvider.Instance.ExecuteNonQuery(query);


                return result > 0;
            } catch
            {
                return false;
            }
        }

        public bool DeletePosition(string idPosition)
        {
            try
            {
                string query = string.Format(
                    "EXECUTE PROC_DeletePosition @IdPosition = '{0}'",
                    idPosition
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
