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
                Console.WriteLine("Enter Employee Name:");
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
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return emp;
        }

        public char CheckOffering()
        {
            
            Console.WriteLine("\n1.Cloud Engineering \n2.Core Technology Operations \n3.Core Industry Solutions " +
                "\n4.Application Modernisation \n5.Operations Transformations");
            Console.Write("\nEnter the subdomain of the employee:");
            char offering = Convert.ToChar(Console.ReadLine());
            return offering;
        }


        public void PrintDetails(Employee empObj)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", empObj.EmployeeId, empObj.EmployeeName, empObj.EmployeeAge, empObj.Address,
                empObj.PhoneNumber, empObj.EmailId, empObj.JoiningDate);
        }


        public int Search(Employee emp,int id)
        {

            if (emp.EmployeeId == id)
            {
                Console.WriteLine("Employee Found in {0}!!", emp.EmployeeRole);
                PrintDetails(emp);
                return 1;
            }
            return 0;
        }
    }
}
