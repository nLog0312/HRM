using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class RewardDTO
    {
        private string id;
        private string idEmployee;
        private string nameEmployee;
        private string reason;
        private string description;

        public RewardDTO(string id, string idEmployee, string nameEmployee, string reason, string description)
        {
            this.id = id;
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.reason = reason;
            this.description = description;
        }

        public string Id { get => id; set => id = value; }
        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
        public string Reason { get => reason; set => reason = value; }
        public string Description { get => description; set => description = value; }

        public RewardDTO(DataRow row)
        {
            this.id = row["id"].ToString();
            this.idEmployee = row["idEmployee"].ToString();
            this.nameEmployee = row["nameEmployee"].ToString();
            this.reason = row["reason"].ToString();
            this.description = row["description"].ToString();
        }
    }
}
