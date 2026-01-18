using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Models
{
    public class EmployeeHours : Employee
    {
        private double hoursWork { get; set; }
        private decimal salaryHours { get; set; }

        public double getHoursWork() => this.hoursWork;

        public void setHoursWork(double hoursWord) {
              if(hoursWork > 0) this.hoursWork = hoursWord;
        }
        public decimal getSalaryHours() => this.salaryHours;

        public void setSalaryHours(decimal salaryHours) { 
                if(salaryHours > 0) this.salaryHours = salaryHours;
                
        }


        public EmployeeHours(string firstName, string partenalSurname, long numberSecuritySocial, 
            double hoursWork, decimal salaryHours) :
            base(firstName, partenalSurname, numberSecuritySocial)
        {
            this.hoursWork = hoursWork;
            this.salaryHours = salaryHours;
        }

        public override decimal CalculateSalary()
        {
            if (this.hoursWork <= 40) return this.salaryHours * (decimal)this.hoursWork;
            else return (this.salaryHours * (decimal)this.hoursWork) + (this.salaryHours * 1.5m * (decimal)(this.hoursWork - 40));
        }
    }
}
