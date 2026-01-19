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

        public override string ToString()
        {
            return string.Format("commission-based salaried employee {0}\n {1}:{2:C}; ", base.ToString(), "base salary", baseSalary);

        }


        public override Dictionary<int, string> GetEditableFields()
        {
            var fields = base.GetEditableFields();
            fields.Add(3, "Base Salary");
            return fields;
        }

        public override void Update(int option, string newValue)
        {
            if(option == 5)
            {
                if (!decimal.TryParse(newValue, out baseSalary) || baseSalary <= 0)
                    throw new Exception("Enter a valid base salary");
                this.setBaseSalary(baseSalary);
            }
            base.Update(option, newValue);
        }

    }
}
