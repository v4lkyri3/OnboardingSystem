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

        public CoreTechnologyOps(Employee emp)
        {
            empObj = emp;
        }
        public void GetSkills()
        {

        }
    }
}
