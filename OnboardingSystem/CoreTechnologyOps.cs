﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class CoreTechnologyOps:Employee,ISkills
    {
        public Employee empObj;

        public CoreTechnologyOps(Employee emp)
        {
            empObj = emp;
        }
        public void PrintCTSEmployee()
        {

            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", empObj.EmployeeId, empObj.EmployeeName, empObj.EmployeeAge, empObj.Address,
                empObj.PhoneNumber, empObj.EmailId, empObj.JoiningDate);
        }
        public void GetSkills()
        {

        }
    }
}
