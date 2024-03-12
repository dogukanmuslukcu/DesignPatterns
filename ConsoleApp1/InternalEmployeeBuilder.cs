﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class InternalEmployeeBuilder : EmployeeBuilderMethot2
    {
       
        public override void SetEmailAddress(string emailAddress)
        {
            //dogukanmuslukcu@gmail.com
            var arr = emailAddress.Split('@');
            //endswith @company.com.tr
            Employee.EmailAddress = $"{arr[0]}@company.com.tr";

        }

        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[] { ' ', '_','.'});
            Employee.FirstName = arr[0];
            Employee.LastName = arr[1];
        }

        public override void SetUserName(string userName)
        {
            Employee.UserName = userName;

        }
    }
}
