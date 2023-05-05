using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class UserDTO
    {
        private string userName;
        private string password;
        private int role;
        private string descAccount;

        public UserDTO(string userName, string password, int role, string descAccount)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
            this.descAccount = descAccount;
        }

        public string UserName { get => userName; set => userName = value; }
        public int Role { get => role; set => role = value; }
        public string Password { get => password; set => password = value; }
        public string DescAcount { get => descAccount; set => descAccount = value; }

        public UserDTO(DataRow row)
        {
            this.userName = row["userName"].ToString();
            this.password = row["password"].ToString();
            this.role = (int)row["role"];
            this.descAccount = row["descAccount"].ToString();
        }
    }
}
