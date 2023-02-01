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

        public List<string> GetSkills()
        {
            List<string> temp = new List<string>();
            foreach (string item in empObj.SkillSet)
            {
                if (Skills.Contains(item))
                {
                    temp.Add(item);
                }
            }
            return temp;

        }

    }
}
