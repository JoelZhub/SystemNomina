using System;
using System.Collections.Generic;
using System.Text;
using SystemNomina.Models;
using SystemNomina.Storage;

namespace SystemNomina.Services
{
    /* Service de empleados -> 
     * se llama el storage para almacenar los empleados en memoria
     * 
     * nota: desde mi punto de vista y entendimiento no es valido que el view conozca la pila de memoria
     * eso es como decirle que tenga acceso a la BD del sistema.
     */

    public class ServicesEmployee
    {

        
        static public void addEmployee(Employee employee)
        {
            var em = FindsNss(employee.getNumberSecuritySocial());
            if (em != null ) throw new Exception("This employee already exists");
            StorageEmployee.AddEmployee(employee);
        }
        static public void calculateSalaried()
        {
            var em = StorageEmployee.employees();
            if (em.Count() > 0)
            {
                em.ForEach(e => e.CalculateSalary());
                Console.WriteLine("Calculation performed successfully");
            }
            else Console.WriteLine("No registered employees were found.");
        }

        static public void createReport()
        {
            Reports reports = new Reports();
            reports.createReport();
         }

        static public Employee FindsNss(string nss)  => StorageEmployee.employees().Find(e => e.getNumberSecuritySocial() == nss);

        static public void changeEmployee(string nss, int option, string newVa)
        {
            var employee = FindsNss(nss);
            if (employee == null) {
                throw new Exception("\n Employee not found");
            }
            employee.Update(option, newVa);

        }



}
}
