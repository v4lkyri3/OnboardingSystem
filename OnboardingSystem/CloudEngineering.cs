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
        public static List<string> Skills = new List<string>()
            {
                "C#","Kafka","Python","Node","React","Azure","MongoDb","Angular"
            };
        public List<string> GetSkills()
        {
            List<string> temp = new List<string>();
            foreach (string item in empObj.SkillSet)
            {
                if(Skills.Contains(item))
                {
                    temp.Add(item);
                }
            }
            return temp;

        }

        public CloudEngineering(Employee employeeObj)
        {
            empObj = employeeObj;
            empObj.EmployeeRole = "Cloud Engineering";
        }
    }
}
