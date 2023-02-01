using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            char choice='y';
            CoreBusinessOps cboObj = new CoreBusinessOps();
            while (choice == 'y')
            {
               
                Console.WriteLine("1.Enter Employee \n2.Print Details \n3.Check Skillset \n4.Search Employee \n5.Update Employee\n6.Delete Employee");
                Console.Write("\nEnter your Choice:");
                ch = Convert.ToChar(Console.ReadLine());
                switch(ch)
                    {
                     case '1':
                        cboObj.AddEmployee();
                           break;
                     case '2':
                        cboObj.PrintDetails();
                        Console.WriteLine("Employee Printed");
                            break;
                     case '3':
                        cboObj.GetSkillsReq();
                        break;

                    case '4':
                        cboObj.SearchEmployee();
                        break;

                    case '5':
                        cboObj.UpdateEmployee();
                        break;
                    
                    }
                Console.WriteLine("Do you wish to continue?(y/n)");
                choice = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            }    
        }
    }
}
