using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class EmployeeAccess
    {
        public static int Count = 1000;
        public Employee AddEmployeeDetails()
        {
            Employee emp = new Employee();
            try
            {
                Count += 1;
                emp.EmployeeId = Count;
                Console.WriteLine("\nEnter Employee Name:");
                emp.EmployeeName = Console.ReadLine();
                //Console.WriteLine("Enter Employee Age:");
                //emp.EmployeeAge = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter Address:");
                //emp.Address = Console.ReadLine();
                //Console.WriteLine("Enter Phone Number:");
                //emp.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                //Console.WriteLine("Enter Email ID:");
                //emp.EmailId = Console.ReadLine();
                //Console.WriteLine("Enter Joining Date:");
                //emp.JoiningDate = Console.ReadLine();
                Console.WriteLine("Enter the no. of skills you have:");
                int n=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter all your skills:");
                for (int i=0;i<n;i++)
                {
                    emp.SkillSet.Add(Console.ReadLine());
                }

                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return emp;
        }

        public char CheckOffering()
        {
            char offering='0';
            try
            {
                Console.WriteLine("\n1.Cloud Engineering \n2.Core Technology Operations \n3.Core Industry Solutions " +
               "\n4.Application Modernisation \n5.Operations Transformations");
                Console.Write("\nEnter the subdomain of the employee:");
                offering = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
            return offering;
        }


        public void PrintDetails(Employee empObj)
        {
            try
            {
                Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", empObj.EmployeeId, empObj.EmployeeName, empObj.EmployeeAge, empObj.Address,
                empObj.PhoneNumber, empObj.EmailId, empObj.JoiningDate);
                Console.Write("Skills: ");
                foreach (string item in empObj.SkillSet)
                {
                    Console.Write("{0} ",item);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }


        public Employee Search(Employee emp,int id)
        {
            Employee temp = null;
            try
            {
                if (emp.EmployeeId == id)
                {
                    temp = emp;
                    Console.Clear();
                    Console.WriteLine("Employee Found in {0}!!", emp.EmployeeRole);
                    PrintDetails(emp);
                }
                Console.WriteLine("Employee Not Found!!");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return temp;
        }

        public void Update(Employee emp)
        {
            Console.WriteLine("Enter the");   
        }
    }

}
