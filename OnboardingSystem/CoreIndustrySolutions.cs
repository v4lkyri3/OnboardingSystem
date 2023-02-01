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
