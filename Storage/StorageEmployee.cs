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
        static private List<Employee> _employees;
        public StorageEmployee()
        {
            _employees = new List<Employee>();
        }
        static public bool AddEmployee(Employee employee)
        {
            if (_employees.Count() == 0) return false;
            else _employees.Add(employee); return true;
        }
        static public List<Employee> employees()  => _employees;
        
    }
}
