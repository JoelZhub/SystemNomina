using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Models
{
    public class EmployeeSalaried : Employee
    {
        private decimal WeeklySalary;

        public EmployeeSalaried(string firstName, string partenalSurname, string numberSecuritySocial , decimal weeklySalary) :
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

        public override string ToString()
        {
            return  string.Format("Employee for salaried: {0} \n {1}: {2:C}", base.ToString(), "Salaried", WeeklySalary);
        }

        public override Dictionary<int, string> GetEditableFields()
        {
            var fields = base.GetEditableFields();
            fields.Add(3, "Weekly Salary");
            return fields;
        }

        public override void Update(int option, string newValue)
        {
            switch (option)
            {
                case 1:
                    this.setFirstName(newValue);
                    break;
                case 2:
                    this.setPartenalSurname(newValue);
                       break;
                case 3:
                    if (!decimal.TryParse(newValue, out decimal salary) || salary <= 0)
                        throw new Exception("Invalid salary");

                    this.setWeeklySalary(salary);
                    break;
                default: throw new Exception("This option is not valid for this type of employee");

            }
        }
    }

}
