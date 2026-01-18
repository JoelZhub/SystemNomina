using System;
using System.Collections.Generic;
using System.Text;
using SystemNomina.Models;

namespace SystemNomina.Services
{
    /* Service de empleados -> se validan los datos de entrada y
     * se llama el storage para almacenar los empleados en memoria */

    public class ServicesEmployee
    {
        private bool validateEmployee(Employee employee) {
            if (employee == null) return false;
            if(employee.getFirstName() == null || employee.getFirstName().Contains("\\d")) return false;
            if (employee.getPartenalSurname() == null || employee.getPartenalSurname().Contains("\\d")) return false;
            if(employee.getNumberSecuritySocial().ToString().Length < 11) return false;
            return true;
        }

        static public bool addEmployee(Employee employee)
        {
            return true;
        }
    }
}
