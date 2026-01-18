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

        public override string ToString()
        {
            return string.Format("Employee for commission: {0} \n {1}: {2:C}; \n {3} {4:C}",
                base.ToString(), "Gross Sales: ",  grossSales, "Commision rate: ", commissionFee );
        }

        public override void Update(int option, string newValue)
        {
            switch (option) {
                case 1:
                    setFirstName(newValue);
                    break;
                case 2:
                    setPartenalSurname(newValue);
                    break;
                case 3:
                    if (!decimal.TryParse(newValue, out decimal grossSales) || grossSales <= 0)
                        throw new Exception("Invalid gross sales amount");
                    setGrossSales(grossSales);
                    break;

                case 4:
                    if (!decimal.TryParse(newValue, out decimal commissionFee) || commissionFee <= 0)
                        throw new Exception("Invalid commission fee amount");
                    setCommissionFee(commissionFee);
                    break;

                default: throw new Exception("This option is not valid for this type of employee");
            }
        }
    }
}
