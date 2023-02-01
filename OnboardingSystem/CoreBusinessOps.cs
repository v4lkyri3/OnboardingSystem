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
        
        EmployeeAccess employeeAccess = new EmployeeAccess();

        public void AddEmployee()
        {
            try
            {
                Employee emp = employeeAccess.AddEmployeeDetails();
                Offering = employeeAccess.CheckOffering();

                switch (Offering)
                {
                    case '1':
                        CloudEngineering cloudObj = new CloudEngineering(emp);
                        CloudEngineeringsList.Add(cloudObj);
                        break;
                    case '2':
                        CoreTechnologyOps coreTechObj = new CoreTechnologyOps(emp);
                        CoreTechnologyOpsList.Add(coreTechObj);
                        break;
                    case '3':
                        CoreIndustrySolutions coreIndustryObj = new CoreIndustrySolutions(emp);
                        CoreIndustrySolutionsList.Add(coreIndustryObj);
                        break;
                    case '4':
                        ApplicationModernisation appModObj = new ApplicationModernisation(emp);
                        ApplicationModernisationList.Add(appModObj);
                        break;
                    case '5':
                        OpsTransformations opsTransObj = new OpsTransformations(emp);
                        OpsTransformationsList.Add(opsTransObj);
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

        public void PrintDetails()
        {


            Offering = employeeAccess.CheckOffering();

            switch (Offering)
            {
                case '1':
                    foreach (CloudEngineering item in CloudEngineeringsList)
                    {
                        //item.PrintCloudEmployee();
                        employeeAccess.PrintDetails(item.empObj);
                    }
                    break;
                case '2':
                    foreach (CoreTechnologyOps item in CoreTechnologyOpsList)
                    {
                        employeeAccess.PrintDetails(item.empObj);
                    }
                    break;
                case '3':
                    foreach (CoreIndustrySolutions item in CoreIndustrySolutionsList)
                    {
                        employeeAccess.PrintDetails(item.empObj);
                    }
                    break;
                case '4':
                    foreach (ApplicationModernisation item in ApplicationModernisationList)
                    {
                        employeeAccess.PrintDetails(item.empObj);
                    }
                    break;
                case '5':
                    foreach (OpsTransformations item in OpsTransformationsList)
                    {
                        employeeAccess.PrintDetails(item.empObj);
                    }
                    break;
                    
            }
            
        }

        public void UpdateEmployee()
        {
            Offering = employeeAccess.CheckOffering();

            switch (Offering)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
            }
            Console.WriteLine("Enter the Employee ID to update:");
            int empID = Convert.ToInt32(Console.ReadLine()); 
        }
        public void GetSkillsReq()
        {
            Offering = employeeAccess.CheckOffering();
            switch (Offering)
            {
                case '1':
                    foreach (string item in CloudEngineering.Skills)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case '2':
                    foreach (string item in CoreTechnologyOps.Skills)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case '3':
                    foreach (string item in CoreIndustrySolutions.Skills)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case '4':
                    foreach (string item in ApplicationModernisation.Skills)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case '5':
                    foreach (string item in OpsTransformations.Skills)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
        }
    }
}
