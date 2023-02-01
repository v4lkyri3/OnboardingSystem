﻿using System;
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
            try
            {
                char ch;
                char choice = 'y';
                CoreBusinessOps cboObj = new CoreBusinessOps();
                while (choice == 'y')
                {

                    Console.WriteLine("1.Enter Employee \n2.Print Details \n3.Check Skillset \n4.Search Employee \n5.Delete Employee\n6.Update Employee");
                    Console.Write("\nEnter your Choice:");
                    ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            cboObj.AddEmployee();
                            break;
                        case '2':
                            cboObj.PrintDetails();
                            break;
                        case '3':
                            cboObj.GetSkillsReq();
                            break;

                        case '4':
                            Employee emp;
                            Console.WriteLine("Enter the employee ID to search");
                            int id = Convert.ToInt32(Console.ReadLine());
                            emp = cboObj.SearchEmployee(id);
                            break;
                        case '5':
                            Console.WriteLine("Enter the employee ID to Delete");
                            int uid = Convert.ToInt32(Console.ReadLine());
                            cboObj.DeleteEmployee(uid);
                            break;

                    }
                    Console.WriteLine("\nDo you wish to continue?(y/n)");
                    choice = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
