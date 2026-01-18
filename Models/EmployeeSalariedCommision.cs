using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Models
{
    public class EmployeeSalariedCommision : EmployeeCommision
    {
        private decimal baseSalary;

        public EmployeeSalariedCommision(string firstName, string partenalSurname, string numberSecuritySocial, 
            decimal grossSales, decimal commissionFee, decimal baseSalary) :
            base(firstName, partenalSurname, numberSecuritySocial, grossSales, commissionFee)
        {
            this.baseSalary = baseSalary;
        }
        public decimal getBaseSalary() => this.baseSalary;

        public void setBaseSalary(decimal baseSalary) {
            if (baseSalary > 0) this.baseSalary = baseSalary;
        }

        public override decimal CalculateSalary() => base.CalculateSalary() + this.baseSalary + (this.baseSalary + 0.10m);
        
    }
}
