using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int  EmployeeAge { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string  EmailId { get; set; }
        public string JoiningDate { get; set; }
        public string EmployeeRole { get; set; }
        public ArrayList SkillSet { get; set; }



        //public void AddEmployeeDetails()
        //{
        //    Console.WriteLine("Enter Employee Id:");
        //    EmployeeId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Employee Name:");
        //    EmployeeName = Console.ReadLine();
        //    Console.WriteLine("Enter Employee Age:");
        //    EmployeeAge = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Address:");
        //    Address = Console.ReadLine();
        //    Console.WriteLine("Enter Phone Number:");
        //    PhoneNumber = Convert.ToInt64(Console.ReadLine());
        //    Console.WriteLine("Enter Email ID:");
        //    EmailId = Console.ReadLine();
        //    Console.WriteLine("Enter Joining Date:");
        //    JoiningDate = Console.ReadLine();
        //}
    }


}
