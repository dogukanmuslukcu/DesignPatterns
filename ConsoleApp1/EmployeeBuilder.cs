using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class EmployeeBuilder
    {
        private Employee employee { get; set; }
        public EmployeeBuilder()
        {
            employee = new Employee();
        }
        public EmployeeBuilder SetFullName(string fullName)
        {
            var arr = fullName.Split(' ');
            employee.FirstName = arr[0];
            employee.LastName = arr[1];
            return this;
        }
        public EmployeeBuilder SetEmailAddress(string emailAdress)
        {
            employee.EmailAddress = emailAdress;
            return this;
        }
        public EmployeeBuilder SetUserName(string userName)
        {
            employee.UserName = userName;
            return this;
        }
        public Employee BuildEmployee() => employee;
        
    }
}
