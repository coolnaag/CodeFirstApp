using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//Provides attribute classes to define metadata for ASP.NET MVC and ASP.NET data controls.
namespace CodeFirstApp
{
    public class Employee
    {
        public Employee ()
        {
        }
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
    }
}
