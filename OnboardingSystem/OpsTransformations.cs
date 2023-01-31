using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class OpsTransformations:Employee,ISkills
    {
        public Employee empObj;

        public OpsTransformations(Employee emp)
        {
            empObj = emp;
        }
        public void GetSkills()
        {

        }
    }
}
