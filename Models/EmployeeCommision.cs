using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Models
{
    public class EmployeeCommision : Employee
    {

        private decimal grossSales;

        private decimal commissionFee;


        public EmployeeCommision(string firstName, string partenalSurname, string numberSecuritySocial,
            decimal grossSales, decimal commissionFee ) :
            base(firstName, partenalSurname, numberSecuritySocial)
        {
            this.grossSales = grossSales;
            this.commissionFee = commissionFee;

        }

        public decimal getGrossSales() => this.grossSales;
        public void setGrossSales(decimal grossSales) { if (grossSales > 0) this.grossSales = grossSales; }

        public decimal getCommissionFee() => this.commissionFee;
        public void setCommissionFee(decimal commissionFee) { if (commissionFee > 0) this.commissionFee = commissionFee; }

        public override decimal CalculateSalary() => grossSales * commissionFee;
     
    }
}
