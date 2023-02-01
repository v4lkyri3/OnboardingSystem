using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class CoreTechnologyOps:Employee,ISkills
    {
        public Employee empObj;
        public static List<string> Skills = new List<string>()
            {
                "Java",".NET","Angular","Spring Framework","SQL","Postman"
            };
        public CoreTechnologyOps(Employee emp)
        {
            empObj = emp;
            empObj.EmployeeRole = "Core Technology Operations";

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
