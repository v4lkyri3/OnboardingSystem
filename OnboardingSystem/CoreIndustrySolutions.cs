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

        public CoreIndustrySolutions(Employee emp)
        {
            empObj = emp;
        }
        public void GetSkills()
        {

        }
    }
}
