using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    public class Salary
    {
        public string EmployeeName { set; get; }
        public int BasicSalary { set; get; }
        public int HouseRent { set; get; }
        public int MedicalAllowance { set; get; }

        public int TotalSalary()
        {
            return BasicSalary + ((BasicSalary * HouseRent) / 100) + ((BasicSalary * MedicalAllowance) / 100);
        }
    }
}
