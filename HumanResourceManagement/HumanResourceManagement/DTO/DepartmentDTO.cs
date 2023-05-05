using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class DepartmentDTO
    {

        private string idDepartment;
        private string nameDepartment;
        private int quantityEmployee;

        public string IdDepartment { get => idDepartment; set => idDepartment = value; }
        public string NameDepartment { get => nameDepartment; set => nameDepartment = value; }
        public int QuantityEmployee { get => quantityEmployee; set => quantityEmployee = value; }

        public DepartmentDTO(string idDepartment, string nameDepartment, int quantityEmployee)
        {
            this.IdDepartment = idDepartment;
            this.NameDepartment = nameDepartment;
            this.quantityEmployee = quantityEmployee;
        }

        public DepartmentDTO(DataRow row)
        {
            this.IdDepartment = row["idDepartment"].ToString();
            this.NameDepartment = row["nameDepartment"].ToString();
            this.QuantityEmployee = int.Parse(row["quantityEmployee"].ToString());
        }
    }
}
