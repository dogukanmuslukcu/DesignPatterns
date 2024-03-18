using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class EmployeeBuilderMethot2 :IEmployeeBuilderMethot2
    {
        protected Employee Employee { get; set; }
        public EmployeeBuilderMethot2()
        {
            Employee = new Employee();
        }
        public abstract void SetFullName(string fullName);
        public abstract void SetEmailAddress(string emailAddress);
        public abstract void SetUserName(string userName);
        public Employee BuildEmployee() => Employee;
    }
}
