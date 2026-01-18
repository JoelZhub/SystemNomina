using System;
using System.Collections.Generic;
using System.Text;
using SystemNomina.Models;
using SystemNomina.Services;
using SystemNomina.Storage;

namespace SystemNomina.View
{
    public class Dashboard
    {
        public void menu()
        {
          int opt;
            do {

             Console.WriteLine("Payroll System \n \n" +
              "1-Register employees \n\n " +
              "2-Calculate employee pay \n\n " +
              "3-Generar Reportes \n\n" +
              "4-Close \n\n ");

        
                Console.WriteLine("Enter a option: ");
                opt = validateOption(Convert.ToInt32(Console.ReadLine()));

                switch (opt)
                {
                    case 1:
                        registerEmployee();
                        break;

                    case 2:
                        ServicesEmployee.calculateSalaried();
                        Console.Clear();
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.Clear();
                        break;

                }

            } while (opt != 4);

     
        }


        private void registerEmployee()
        {
           
            Console.WriteLine("Please indicate the type of employee to register.");
            Console.WriteLine("1-Salaried employee \n\n 2-Hourly employee\n\n " +
                "3-Commission-based employee\n\n  4-Salaried commission-based employee\n\n ");
                
            int opt = validateOption(Convert.ToInt32(Console.ReadLine())) ;

            Console.WriteLine("Enter the employee's firstName");
            string firstName = Console.ReadLine()!.Trim();
            Console.WriteLine("Enter the employee's paternalSurname");
            string paternalSurname = Console.ReadLine()!.Trim();
            Console.WriteLine("Enter the employee's social security number");
            string nss  = Console.ReadLine()!.Trim();

            decimal salary = 0;
            decimal fee = 0;
            decimal grossS = 0;

            switch (opt)
            {
                case 1:
                    Console.WriteLine("Enter the employee's weekly salary");
                    salary = validateMoney();
                    ServicesEmployee.addEmployee(new EmployeeSalaried(firstName, paternalSurname, nss, salary));
                    Console.Clear();
                    break;
                 case 2:
                    
                    Console.WriteLine("Enter the number of hours the employee works");
                    double hours = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the employee's hourly wage");
                    salary = validateMoney();

                    ServicesEmployee.addEmployee(new EmployeeHours(firstName, paternalSurname, nss, hours, salary));
                    break;

                case 3:
                    Console.WriteLine("Enter the employee's gross sales");
                    grossS = validateMoney();

                    Console.WriteLine("Enter the employee commission rate");
                    fee = validateMoney();

                    ServicesEmployee.addEmployee(new EmployeeCommision(firstName, paternalSurname, nss, grossS, fee));

                    break;

                case 4:

                    Console.WriteLine("Enter the employee's base salary");
                    salary = validateMoney();

                    Console.WriteLine("Enter the employee's gross sales");
                    grossS = validateMoney();

                    Console.WriteLine("Enter the employee commission rate");
                    fee = validateMoney();
                    ServicesEmployee.addEmployee(new EmployeeSalariedCommision(firstName, paternalSurname, nss, grossS, fee, salary));
                    break;

            }


        }



        private decimal validateMoney()
        {
            string salary;
            decimal m;
            do salary = Console.ReadLine()!;
            while (!decimal.TryParse(salary, out m));
            return m;
        }

        private int validateOption(int opt)
        { 
            while (opt > 4 || opt <= 0) {
                Console.WriteLine("Please enter a valid option, corresponding to the menu ");
                opt = Convert.ToInt32(Console.ReadLine());
            }
            return opt;
        }

    }
}
