using System;
using System.Collections.Generic;
using System.Text;
using SystemNomina.Storage;

namespace SystemNomina.Models
{
    public class Reports
    {

        private DateTime creationDate;
        private DateTime endDate;
        private Employee employee;
        private List<Reports> reports = new List<Reports>();

        public Reports(DateTime creationDate, DateTime endDate, Employee employee)
        {
            this.creationDate = creationDate;
            this.endDate = endDate;
            this.employee = employee;
        }
        public void createReport()
        {
            if (StorageEmployee.employees().Count > 0) StorageEmployee.employees().ForEach(e => reports.Add(new Reports(DateTime.Now, creationDate.AddDays(7), e)));
            else Console.WriteLine("There are no registered employees, so the report cannot be generated.");
            
        }
        public void PrintReport()
        {
            reports.ForEach(r => Console.WriteLine($" Report Week: {r.creationDate} - {r.endDate} \n " +
                $" Employee report: {r.employee.GetType()} \n {r.employee.ToString()}" ));
        }
    }
}
