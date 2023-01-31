using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    public class CoreBusinessOps
    {
        List<CloudEngineering> CloudEngineeringsList = new List<CloudEngineering>();
        List<CoreIndustrySolutions> CoreIndustrySolutionsList = new List<CoreIndustrySolutions>();
        List<CoreTechnologyOps> CoreTechnologyOpsList = new List<CoreTechnologyOps>();
        List<ApplicationModernisation> ApplicationModernisationList = new List<ApplicationModernisation>();
        List<OpsTransformations> OpsTransformationsList = new List<OpsTransformations>();
        char Offering;        
        public void AddEmployee()
        {
            Employee emp = AddEmployeeDetails();
            Console.WriteLine("Enter the subdomain of the employee");
            Console.WriteLine("1.Cloud Engineering \n2.Core Technology Operations \n3.Core Industry Solutions " +
                "\n4.Application Modernisation \n5.Operations Transformations");
            Offering = Convert.ToChar(Console.ReadLine());
            switch(Offering)
            {
                case '1':
                    CloudEngineering cloudObj = new CloudEngineering();
                    cloudObj.AddCloudEmployee(emp);
                    CloudEngineeringsList.Add(cloudObj);
                    break;
                case '2':
                    CoreTechnologyOps coreTechObj = new CoreTechnologyOps();
                    coreTechObj.AddCTOEmployee();
                    CoreTechnologyOpsList.Add(coreTechObj);
                    break;
                case '3':
                    CoreIndustrySolutions coreIndustryObj = new CoreIndustrySolutions();
                    coreIndustryObj.AddCISEmployee();
                    CoreIndustrySolutionsList.Add(coreIndustryObj);
                    break;
                case '4':
                    ApplicationModernisation appModObj = new ApplicationModernisation();
                    appModObj.AddAppModEmployee();
                    ApplicationModernisationList.Add(appModObj);
                    break;
                case '5':
                    OpsTransformations opsTransObj = new OpsTransformations();
                    opsTransObj.AddOpsTransEmployee();
                    OpsTransformationsList.Add(opsTransObj);
                    break;
            }
            
        }

        public void PrintDetails()
        {
            Console.WriteLine("EmployeeID\tEmployee Name\tAge\tAddress\tPhone Number\tEmail ID\tJoining Date");
            foreach (CloudEngineering item in CloudEngineeringsList)
            {
                item.PrintCloudEmployee();
            }
        }

        public Employee AddEmployeeDetails()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee Id:");
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            emp.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age:");
            emp.EmployeeAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address:");
            emp.Address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            emp.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email ID:");
            emp.EmailId = Console.ReadLine();
            Console.WriteLine("Enter Joining Date:");
            emp.JoiningDate = Console.ReadLine();

            return emp;
        }
    }
}
