using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class EmployeeViewModel
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public static /*EmployeeViewModel*/ explicit operator EmployeeViewModel(Employee employee)
        {
            string[] Names=employee.FullName.Split(" ");
            return new EmployeeViewModel()
            {
                Fname = Names?.Length > 0 ? Names[0]:string.Empty,
                Lname = Names?.Length > 0 ? Names[0]:string.Empty,
                Email=employee.Email,
            };

        }
    }
}
