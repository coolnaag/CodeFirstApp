using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            Employee emp = new Employee() { EmpID = 1, EmpName = "CAI", Address = "Bangalore",  Address1 = "bbbb" };
          //  context.Entry(emp).Reload();
            context.Employees.Add(emp);
            context.SaveChanges();  
        }
    }
}
