using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement.DAO
{
    public class UserLoginDAO
    {

        public static int Width = 200;
        public static int Height = 150;
        private UserLoginDAO() { }

        private static UserLoginDAO instance;

        public static UserLoginDAO Instance
        {
            get { if (instance == null) instance = new UserLoginDAO(); return instance; }
            private set { instance = value; }
        }

        public List<UserDTO> LoadUser()
        {
            List<UserDTO> users = new List<UserDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE PROC_ShowtAccount");

            foreach (DataRow row in data.Rows)
            {
                UserDTO user = new UserDTO(row);
                users.Add(user);
            }

            return users;
        }

        public bool Login(string userName, string password)
        {
            string query = "EXECUTE PROC_GetAccount @UserName , @Password ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, password});

            return result.Rows.Count > 0;
        }

        public int GetRole(string userName)
        {
            string query = "EXECUTE PROC_GetRole @UserName ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return (int)result.Rows[0][0];
        }

        public bool InsertAccount(string userName, string password, string descAccount)
        {
            string query = "EXECUTE PROC_InsertAccount @UserName , @Password , @DescAccount ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, password, descAccount });

            return result > 0;
        }

        public bool UpdateAccount(string userName, string password, string descAccount)
        {
            string query = "EXECUTE PROC_UpdateAccount @UserName , @Password , @DescAccount ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, password, descAccount });

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = "EXECUTE PROC_DeleteAccount @UserName ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });

            return result > 0;
        }
    }
}
