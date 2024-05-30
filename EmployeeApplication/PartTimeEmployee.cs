using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class PartTimeEmployee :EmployeeInterface.IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string jobTitle;
        private double basicSalary;

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            firstName = FName;
            lastName = LName;
            department = dept;
            jobTitle = job;
            basicSalary = 0.0;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Department { get => department; set => department = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basicSalary = hoursWorked * ratePerHour;
        }


        public double getSalary()
        {
            return basicSalary;
        }

        public void employee(string firstname, string lastname) { 
            firstName = firstname;
            lastName = lastname;
        }

       public string getFirstName()
        {
            return firstName;
        }
        public string getLastName() { 
            return lastName;
        }
    }
}
