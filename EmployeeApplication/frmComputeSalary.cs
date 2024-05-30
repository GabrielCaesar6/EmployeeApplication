
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
       

        public frmComputeSalary()
        {
            InitializeComponent();
        }
        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            double ratePerHour = Convert.ToDouble(txtRatePerHour.Text);
            int hoursWorked = Convert.ToInt32(txtHoursWorked.Text);

      
            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);


            employee.computeSalary(hoursWorked, ratePerHour);
   

            txtBasicSalary.Text = employee.getSalary().ToString("N"); 


            lblFirstName.Text = firstName;
            lblLastName.Text = lastName;

        }

    }
}
