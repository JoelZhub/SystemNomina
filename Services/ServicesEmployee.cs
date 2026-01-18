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
        static public bool addEmployee(Employee employee)
        {
            if (employee == null) return false;
            return StorageEmployee.AddEmployee(employee);
        }




    }
}
