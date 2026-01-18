using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Models
{
    public class EmployeeSalaried : Employee
    {
        private decimal WeeklySalary;

        public EmployeeSalaried(string firstName, string partenalSurname, long numberSecuritySocial , decimal weeklySalary) :
            base(firstName, partenalSurname, numberSecuritySocial)
        {
            this.WeeklySalary = weeklySalary;
        }

        public decimal getWeeklySalary() => this.WeeklySalary;
        
        public void setWeeklySalary(decimal WeeklySalary) { 
            if (WeeklySalary > 0) this.WeeklySalary = WeeklySalary;
        }

        public override decimal CalculateSalary()
        {
            return WeeklySalary;
        }
    }
}
