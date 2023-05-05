using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class LevelSalaryDTO
    {
        private int levelSalary;
        private int basicSalary;
        private double coefficientsSalary;
        private double totalSalary;

        public LevelSalaryDTO(int levelSalary, int basicSalary, double coefficientsSalary, double totalSalary)
        {
            this.levelSalary = levelSalary;
            this.basicSalary = basicSalary;
            this.coefficientsSalary = coefficientsSalary;
            this.totalSalary = totalSalary;
        }

        public int LevelSalary { get => levelSalary; set => levelSalary = value; }
        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double CoefficientsSalary { get => coefficientsSalary; set => coefficientsSalary = value; }
        public double TotalSalary { get => totalSalary; set => totalSalary = value; }

        public LevelSalaryDTO(DataRow row)
        {
            this.levelSalary = (int)row["levelSalary"];
            this.basicSalary = int.Parse(row["basicSalary"].ToString());
            this.coefficientsSalary = double.Parse(row["coefficientsSalary"].ToString());
            this.totalSalary = Math.Round(basicSalary * coefficientsSalary);
        }
    }
}
