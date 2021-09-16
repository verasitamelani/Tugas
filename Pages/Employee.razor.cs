using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using latihanblazor.Models;

namespace latihanblazor.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync(){
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeID=1,
                FirstName= "Veronika",
                LastName = "Melani",
                Email = "veronikaverasita@gmail.com",
                DateOfBirth = new DateTime(2001, 05, 3),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,
                DepartmentName="IT"},
                PhotoPath = "image/vera.jpg"
            };

              Employee e2 = new Employee{
                EmployeeID=2,
                FirstName= "Fransiska",
                LastName = "Lidianti",
                Email = "vivilidianti@gmail.com",
                DateOfBirth = new DateTime(1990, 6, 18),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,
                DepartmentName="HR"},
                PhotoPath = "image/vivi.jpg"
            };

            Employee e3 = new Employee{
                EmployeeID=3,
                FirstName= "Jihan",
                LastName = "Rastri",
                Email = "jihanrastri@gmail.com",
                DateOfBirth = new DateTime(1999, 8, 20),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,
                DepartmentName="IT"},
                PhotoPath = "image/jihan.jpg"
            };


            Employees = new List<Employee>{e1,e2,e3};
        }
    }
}
