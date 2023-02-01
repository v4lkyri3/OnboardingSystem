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

        //Adding Employee
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
                Console.WriteLine("\nEmployee Added with ID :{0}",emp.EmployeeId);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

        //Printing  Employee
        public void PrintDetails()
        {

            try
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
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }


        //Searching Employee
        public Employee SearchEmployee(int id)
        {
            Employee empObj = new Employee();
            try
            {
                foreach (CloudEngineering item in CloudEngineeringsList)
                {
                    empObj = employeeAccess.Search(item.empObj, id);
                    if (empObj != null)
                        return empObj;
                }
                foreach (CoreIndustrySolutions item in CoreIndustrySolutionsList)
                {
                    empObj = employeeAccess.Search(item.empObj, id);
                    if (empObj != null)
                        return empObj;
                }
                foreach (CoreTechnologyOps item in CoreTechnologyOpsList)
                {
                    empObj = employeeAccess.Search(item.empObj, id);
                    if (empObj != null)
                        return empObj;
                }
                foreach (ApplicationModernisation item in ApplicationModernisationList)
                {
                    empObj = employeeAccess.Search(item.empObj, id);
                    if (empObj != null)
                        return empObj;
                }
                foreach (OpsTransformations item in OpsTransformationsList)
                {
                    empObj = employeeAccess.Search(item.empObj, id);
                    if (empObj != null)
                        return empObj;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            if(empObj==null)
                Console.WriteLine("Employee not Found!!");
            return empObj;
        }




        //Deleting Employee
        public void DeleteEmployee(int id)
        {
            try
            {
                Employee eobj;
                eobj = SearchEmployee(id);
                if(CloudEngineeringsList.Contains(eobj))
                {
                    
                }

                else if (CoreTechnologyOpsList.Contains(eobj))
                {

                }

                else if (CoreIndustrySolutionsList.Contains(eobj))
                {

                }
                
                else if (ApplicationModernisationList.Contains(eobj))
                {

                }

                else if (OpsTransformationsList.Contains(eobj))
                {

                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }



        //Get Common Skills

        public void CommonSkills(int eid)
        {
            Employee emp;
            string[] skills = new string[20];
            try
            {
                Offering = employeeAccess.CheckOffering();
                switch (Offering)
                {
                    case '1':
                        foreach (CloudEngineering item in CloudEngineeringsList)
                        {
                            emp = employeeAccess.Search(item.empObj, eid);
                            if (emp != null)
                                item.GetSkills().CopyTo(skills);
                        }
                        break;
                    case '2':
                        foreach (CoreTechnologyOps item in CoreTechnologyOpsList)
                        {
                            emp = employeeAccess.Search(item.empObj, eid);
                            if (emp != null)
                                item.GetSkills().CopyTo(skills);
                        }
                        break;
                    case '3':
                        foreach (CoreIndustrySolutions item in CoreIndustrySolutionsList)
                        {
                            emp = employeeAccess.Search(item.empObj, eid);
                            if (emp != null)
                                item.GetSkills().CopyTo(skills);
                        }
                        break;
                    case '4':
                        foreach (ApplicationModernisation item in ApplicationModernisationList)
                        {
                            emp = employeeAccess.Search(item.empObj, eid);
                            if (emp != null)
                                item.GetSkills().CopyTo(skills);
                        }
                        break;
                    case '5':
                        foreach (OpsTransformations item in OpsTransformationsList)
                        {
                            emp = employeeAccess.Search(item.empObj, eid);
                            if (emp != null)
                                item.GetSkills().CopyTo(skills);
                        }
                        break;
                }
                if (skills.Length > 0 && skills!=null)
                {
                    Console.WriteLine("\nCommon Skills are:");
                    foreach (string item in skills)
                    {
                        Console.Write("{0}  ", item);
                    }
                }
                else
                {
                    Console.WriteLine("\nNo common Skills!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\nEnter correct Sub-Domain of the Employee");
                CommonSkills(eid);
            }
        }



        //Get Required Skills
        public void GetSkillsReq()
        {
            try
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
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }


        //Load Predefined Data
        public void Load()
        {
            Class1 c1 = new Class1();
            c1.Data();
            CloudEngineering ce;
            CoreTechnologyOps cto;
            CoreIndustrySolutions cis;
            ApplicationModernisation ami;
            OpsTransformations opt;

            CloudEngineeringsList.Add(ce = new CloudEngineering(c1.emp1));
            CloudEngineeringsList.Add(ce = new CloudEngineering(c1.emp2));
            CoreTechnologyOpsList.Add(cto = new CoreTechnologyOps(c1.emp3));
            CoreTechnologyOpsList.Add(cto = new CoreTechnologyOps(c1.emp4));
            CoreIndustrySolutionsList.Add(cis = new CoreIndustrySolutions(c1.emp5));
            CoreIndustrySolutionsList.Add(cis = new CoreIndustrySolutions(c1.emp6));
            ApplicationModernisationList.Add(ami = new ApplicationModernisation(c1.emp7));
            ApplicationModernisationList.Add(ami = new ApplicationModernisation(c1.emp8));
            OpsTransformationsList.Add(opt = new OpsTransformations(c1.emp9));
            OpsTransformationsList.Add(opt = new OpsTransformations(c1.emp10));

        }
    }
}
