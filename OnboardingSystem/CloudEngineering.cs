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
                ".NET","Kafka","Python","Node","React","Azure","MongoDb","Angular"
            };
    public void GetSkills()
        {
            Console.WriteLine("The Skillset you would require in this offering:");
            foreach (string item in SkillSet)
            {
                Console.WriteLine(item);
            }

        }

        public CloudEngineering(Employee employeeObj)
        {
            empObj = employeeObj;
            empObj.EmployeeRole = "Cloud Engineering";
        }
    }
}
