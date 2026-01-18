using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using SystemNomina.Storage;

namespace SystemNomina.Models
{
    public class Reports
    {

        private DateTime creationDate = DateTime.Now;
        private DateTime endDate = DateTime.Now.AddDays(7);
        private decimal totalPay => StorageEmployee.employees().Sum(e => e.CalculateSalary());
         
        public void createReport()
        {
            Console.WriteLine($"Weekly Report from {creationDate}  to {endDate} \n\n ");
            StorageEmployee.employees().ForEach(e => Console.WriteLine(e.ToString()));
            Console.WriteLine(string.Format("total to pay: {0:C} \n", totalPay));

        }

    }
}
