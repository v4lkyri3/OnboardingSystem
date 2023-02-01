using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class ApplicationModernisation:Employee,ISkills
    {
        public Employee empObj;
        public static List<string> Skills = new List<string>()
            {
                "Selenium","SalesForce","AWS","Java","GCP","Azure","Vmware","COBOL"
            };
        public ApplicationModernisation(Employee emp)
        {
            empObj = emp;
            empObj.EmployeeRole = "Application Modernisation";
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
