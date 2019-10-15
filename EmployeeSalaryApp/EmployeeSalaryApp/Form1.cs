using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class Form1 : Form
    {
        Salary salary = new Salary();
        public Form1()
        {
            InitializeComponent();
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            salary.EmployeeName = employeeNameTextBox.Text;
            salary.BasicSalary = Convert.ToInt32(basicSalayTextBox.Text);
            salary.HouseRent = Convert.ToInt32(houseRentTextBox.Text);
            salary.MedicalAllowance = Convert.ToInt32(medicalAllowanceTextBox.Text);

            MessageBox.Show(salary.EmployeeName + ", Your Salary is : "+salary.TotalSalary());
        }
    }
}
