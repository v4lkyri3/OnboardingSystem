using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class CloudEngineering:Employee,ISkills
    {
        //Hello Team
        public Employee empObj;
        public void GetSkills()
        {
            
        }

        public CloudEngineering(Employee employeeObj)
        {
            empObj = employeeObj;
        }

        public void PrintCloudEmployee()
        {
    
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",empObj.EmployeeId, empObj.EmployeeName, empObj.EmployeeAge, empObj.Address,
                empObj.PhoneNumber, empObj.EmailId, empObj.JoiningDate);
        }
    }
}
