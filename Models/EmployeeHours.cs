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

        public EmployeeHours(string firstName, string partenalSurname, string numberSecuritySocial, 
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

        public override string ToString()
        {
            return string.Format("Employee for hours: {0}\n {1}:{2:C}; {3}:{4:C}; ", base.ToString(), "Hourly wage", salaryHours, "hours worked", hoursWork);
        }


        public override Dictionary<int, string> GetEditableFields()
        {
            var fields = base.GetEditableFields();
            fields.Add(3, "Hours Worked");
            fields.Add(4, "Hourly Wage");
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
                    if (!double.TryParse(newValue, out double hour) || hour <= 0)
                        throw new Exception("The number of working hours is not valid");
                    this.setHoursWork(hour);
                    break;
                case 4:
                    if (!decimal.TryParse(newValue, out decimal salary) || salary <= 0)
                        throw new Exception("The income salary is not valid");
                    this.setSalaryHours(salary);
                    break;
                default: throw new Exception("This option is not valid for this type of employee");
            }
        }
    }
}
