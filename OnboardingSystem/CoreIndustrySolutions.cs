using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class CoreIndustrySolutions:Employee,ISkills
    {
        public Employee empObj;
        public static List<string> Skills = new List<string>()
            {
                "Java EE","Scada","Oracle Cerner","Epic","Majesco"
            };

        public CoreIndustrySolutions(Employee emp)
        {
            empObj = emp;
            empObj.EmployeeRole = "Core Industry Solutions";

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
