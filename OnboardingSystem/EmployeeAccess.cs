using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class EmployeeAccess
    {
        public Employee AddEmployeeDetails()
        {
            Employee emp = new Employee();
            try
            {
                
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
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return emp;
        }
    }
}
