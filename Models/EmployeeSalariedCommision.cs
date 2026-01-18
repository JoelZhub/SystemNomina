using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Models
{
    public class EmployeeSalariedCommision : Employee
    {

        private decimal grossSales;
        private  decimal commissionFee;
        private decimal baseSalary;

        public EmployeeSalariedCommision(string  firstName, string partenalSurname, 
            long numberSecuritySocial, decimal grossSales, decimal commissionFee, decimal baseSalary) :
            base(firstName, partenalSurname, numberSecuritySocial)
        {
            this.grossSales = grossSales;
            this.commissionFee = commissionFee;
            this.baseSalary = baseSalary;
        }

        public decimal getGrossSales() => this.grossSales;
        public void setGrossSales(decimal grossSales) {
            if (grossSales > 0) this.grossSales = grossSales;
        }

        public decimal getCommissionFee() => this.commissionFee;

        public void setCommissionFee(decimal commissionFee) {
            if(commissionFee > 0) this.commissionFee = commissionFee;
        }

        public decimal getBaseSalary() => this.baseSalary;

        public void setBaseSalary(decimal baseSalary) {
            if (baseSalary > 0) this.baseSalary = baseSalary;
        }

        public override decimal CalculateSalary() => (this.grossSales * commissionFee) + this.baseSalary + (this.baseSalary * 0.10m);
        
    }
}
