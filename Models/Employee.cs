using System;
using System.Collections.Generic;
using System.Text;
namespace SystemNomina.Models
{
    public abstract class Employee
    {
        private string firstName;
        private string partenalSurname;
        private string numberSecuritySocial;
 
        public Employee(string firstName, string partenalSurname, string numberSecuritySocial) { 
                   this.firstName = firstName;
                   this.partenalSurname = partenalSurname;
                   this.numberSecuritySocial = numberSecuritySocial;
        }

        public string getFirstName() =>  this.firstName;
        public void setFirstName(string firstName) {
                if(firstName != null) this.firstName = firstName;
        }
        public string getPartenalSurname() => this.partenalSurname;
        public void setPartenalSurname(string paternalSurname) {
                if(paternalSurname != null) this.partenalSurname =paternalSurname;
  
        }

        public string getNumberSecuritySocial() => this.numberSecuritySocial;
        public void setNumberSecuritySocial(string numberSecuritySocial) { 
                if(numberSecuritySocial != null) this.numberSecuritySocial = numberSecuritySocial;
        }
        public abstract decimal CalculateSalary();

        public override string ToString()
        {
            return $"FirstName: {this.firstName} \n " +
                $"Paternal Surname: {this.partenalSurname} \n" +
                $"Number Security Social: {this.numberSecuritySocial} ";
        }

        public abstract void Update(int option, string newValue);


    }
}
