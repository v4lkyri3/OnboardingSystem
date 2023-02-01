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




        //Ask for Offering Details
        public char CheckOffering()
        {
            char offering = '0';
            try
            {
                Console.WriteLine("\n1.Cloud Engineering \n2.Core Technology Operations \n3.Core Industry Solutions " +
               "\n4.Application Modernisation \n5.Operations Transformations");
                Console.Write("\nEnter the subdomain:");
                offering = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            return offering;
        }




        //Add details to Employee
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




        //Print Employee Details
        public void PrintDetails(Employee empObj)
        {
            try
            {
                Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", empObj.EmployeeId, empObj.EmployeeName, empObj.EmployeeAge, empObj.Address,
                empObj.PhoneNumber, empObj.EmailId, empObj.JoiningDate,empObj);
                Console.Write("Skills: ");
                foreach (string item in empObj.SkillSet)
                {
                    Console.Write("{0} ",item);
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }




        //Searching Employee Details by ID
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
                    return temp;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return temp;
        }


        //Updating Employee Details
        public Employee Update(Employee emp)
        {
            char ch;
            try
            {
                Console.WriteLine("Enter the details to be updated:");
                Console.WriteLine("1.Address\n2.Phone Number\n3.Email ID");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch == '1')
                {
                    Console.WriteLine("Enter new Address:");
                    emp.Address = Console.ReadLine();
                }
                else if (ch == '2')
                {
                    Console.WriteLine("Enter the new Phone Number:");
                    emp.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                }
                else if (ch == '3')
                {
                    Console.WriteLine("Enter the new Email ID:");
                    emp.EmailId = Console.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return emp;
        }
    }

}
