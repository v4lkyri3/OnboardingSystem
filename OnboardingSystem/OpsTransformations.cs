using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class OpsTransformations:Employee,ISkills
    {
        public Employee empObj;
        public static List<string> Skills = new List<string>()
            {
                "Alteryx","Opentext","Aris","Celonis","Transformation Program Management"
            };

        public OpsTransformations(Employee emp)
        {
            empObj = emp;
            empObj.EmployeeRole = "Operation Transformations";
        }

        public void GetSkills()
        {
            Console.WriteLine("The Skillset you would require in this offering:");
            foreach (string item in SkillSet)
            {
                Console.WriteLine(item);
            }

        }
    }
}
