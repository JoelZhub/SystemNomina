using System;
using System.Collections.Generic;
using System.Text;
using SystemNomina.Models;

namespace SystemNomina.Storage
{

    /*almacenamiento en memoria de los empleados ->  esta clase se usa para almacenar el empleado creado en la collections 
     * la misma se consulta en sus service correspondiente
     */

    public class StorageEmployee
    {
        static private List<Employee> _employees = new List<Employee>();
        static public void AddEmployee(Employee employee)
        {
            if (_employees.Count() > 0)
            {
                var existing = _employees.FirstOrDefault(e => e.getNumberSecuritySocial() == employee.getNumberSecuritySocial());
                if (existing != null) throw new Exception("An unexpected error occurred while adding the employee. Please try again later.") ;
            }
            _employees.Add(employee);
        }
        static public List<Employee> employees()  => _employees;
        
    }
}
