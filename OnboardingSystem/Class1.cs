using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSystem
{
    internal class Class1:Employee
    {
        void Data()
        {
            List<Employee> emp = new List<Employee>();
            emp[0] = new Employee()
            {
                EmployeeId= 991,
                EmployeeName="Phil",
                EmployeeAge=34,
                Address="Springer Street",
                PhoneNumber=945638262,
                EmailId = "philips@del.com",
                JoiningDate = "16-10-2014",
                SkillSet = {"Java","C#","MongoDB"}
            };
            emp[1] = new Employee()
            {
                EmployeeId = 992,
                EmployeeName = "Hill",
                EmployeeAge = 24,
                Address = "Green Glen Layout",
                PhoneNumber = 9463764262,
                EmailId = "hilaryclinton@red.com",
                JoiningDate = "8-10-2020",
                SkillSet = { "Selenium", "C#" }
            };
            emp[2] = new Employee()
            {
                EmployeeId = 993,
                EmployeeName = "Billie",
                EmployeeAge = 27,
                Address = "Hawkins",
                PhoneNumber = 9463756382,
                EmailId = "demegorgans@st.com",
                JoiningDate = "27-2-2017",
                SkillSet = { "C", "C++" }
            };
            emp[3] = new Employee()
            {
                EmployeeId=994,
                EmployeeName = "Edward",
                EmployeeAge = 32,
                Address = "Forks",
                PhoneNumber = 8163756382,
                EmailId = "twilight@mayor.com",
                JoiningDate = "2-12-2014",
                SkillSet = { "Python", "Java" }
            };

            emp[4] = new Employee()
            {
                EmployeeId = 995,
                EmployeeName = "Peeta",
                EmployeeAge = 22,
                Address = "Panem",
                PhoneNumber = 9863756382,
                EmailId = "hunger@games.com",
                JoiningDate = "22-09-2021",
                SkillSet = { "Java" }
            };

            emp[5] = new Employee()
            {
                EmployeeId = 996,
                EmployeeName = "Gunther",
                EmployeeAge = 35,
                Address = "Central Perk",
                PhoneNumber = 9863756452,
                EmailId = "friends@ph.com",
                JoiningDate = "12-12-2012",
                SkillSet = { "C#","AWS" }
            };

            emp[6] = new Employee()
            {
                EmployeeId = 997,
                EmployeeName = "Ronald",
                EmployeeAge = 26,
                Address = "Wizarding World",
                PhoneNumber = 6745756454,
                EmailId = "luna@hogwarts.com",
                JoiningDate = "31-07-2018",
                SkillSet = { "MongoDB", "Python" }
            };

            emp[7] = new Employee()
            {
                EmployeeId = 998,
                EmployeeName = "Four",
                EmployeeAge = 34,
                Address = "Divergent Alley",
                PhoneNumber = 7645756454,
                EmailId = "Four@suz.com",
                JoiningDate = "12-07-2012",
                SkillSet = { "C#", "C++","Azure" }
            };

            emp[8] = new Employee()
            {
                EmployeeId = 999,
                EmployeeName = "Newt",
                EmployeeAge = 29,
                Address = "Diagon Alley",
                PhoneNumber = 7645345054,
                EmailId = "NewtScamandar@fb.com",
                JoiningDate = "16-05-2013",
                SkillSet = { "Python", "C", "Selenium" }
            };

            emp[9] = new Employee()
            {
                EmployeeId = 1000,
                EmployeeName = "Sheldon",
                EmployeeAge = 21,
                Address = "Big Bang Street",
                PhoneNumber = 8945345054,
                EmailId = "sheldon@bbt.com",
                JoiningDate = "03-01-2022",
                SkillSet = {"C"}
            };



        }
    }
}
