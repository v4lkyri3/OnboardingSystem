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

        public ApplicationModernisation(Employee emp)
        {
            empObj = emp;
        }
        public void GetSkills()
        {

        }

    }
}
