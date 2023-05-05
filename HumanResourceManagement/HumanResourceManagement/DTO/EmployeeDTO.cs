using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class EmployeeDTO
    {
        private string idEmployee;
        private string nameEmployee;
        private string dateEmployee;
        private bool sexEmployee;
        private string folkEmployee;
        private string phoneEmployee;
        private string addressEmployee;
        private string idDepartment;
        private string idPosition;
        private int levelSalary;

        public EmployeeDTO(
            string idEmployee,
            string nameEmployee,
            string dateEmployee,
            bool sexEmployee,
            string folkEmployee,
            string phoneEmployee,
            string addressEmployee,
            string idDepartment,
            string idPosition,
            int levelSalary
        )
        {
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.dateEmployee = dateEmployee;
            this.sexEmployee = sexEmployee;
            this.folkEmployee = folkEmployee;
            this.phoneEmployee = phoneEmployee;
            this.addressEmployee = addressEmployee;
            this.idDepartment = idDepartment;
            this.idPosition = idPosition;
            this.levelSalary = levelSalary;
        }

        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
        public string DateEmployee { get => dateEmployee; set => dateEmployee = value; }
        public bool SexEmployee { get => sexEmployee; set => sexEmployee = value; }
        public string FolkEmployee { get => folkEmployee; set => folkEmployee = value; }
        public string PhoneEmployee { get => phoneEmployee; set => phoneEmployee = value; }
        public string AddressEmployee { get => addressEmployee; set => addressEmployee = value; }
        public string IdDepartment { get => idDepartment; set => idDepartment = value; }
        public string IdPosition { get => idPosition; set => idPosition = value; }
        public int LevelSalary { get => levelSalary; set => levelSalary = value; }

        public EmployeeDTO(DataRow row)
        {
            this.idEmployee = row["idEmployee"].ToString();
            this.nameEmployee = row["nameEmployee"].ToString();
            this.dateEmployee = row["date"].ToString().Substring(0, 10);
            this.sexEmployee = (bool)row["sex"];
            this.folkEmployee = row["folk"].ToString();
            this.phoneEmployee = row["phoneNumber"].ToString();
            this.addressEmployee = row["address"].ToString();
            this.idDepartment = row["nameDepartment"].ToString();
            this.idPosition = row["namePosition"].ToString();
            this.levelSalary = (int)row["levelSalary"];
        }
    }
}
