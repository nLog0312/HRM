using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class DisciplineDTO
    {
        private string id;
        private string idEmployee;
        private string nameEmployee;
        private string dateStart;
        private string dateEnd;
        private string reason;
        private string description;

        public DisciplineDTO(string id, string idEmployee, string nameEmployee, string dateStart, string dateEnd, string reason, string description)
        {
            this.id = id;
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.reason = reason;
            this.description = description;
        }

        public string Id { get => id; set => id = value; }
        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
        public string DateStart { get => dateStart; set => dateStart = value; }
        public string DateEnd { get => dateEnd; set => dateEnd = value; }
        public string Reason { get => reason; set => reason = value; }
        public string Description { get => description; set => description = value; }

        public DisciplineDTO(DataRow row)
        {
            this.id = row["id"].ToString();
            this.idEmployee = row["idEmployee"].ToString();
            this.nameEmployee = row["nameEmployee"].ToString();
            this.dateStart = row["dateStart"].ToString().Substring(0, 11);
            this.dateEnd = row["dateEnd"].ToString().Substring(0, 11);
            this.reason = row["reason"].ToString();
            this.description = row["description"].ToString();
        }
    }
}
