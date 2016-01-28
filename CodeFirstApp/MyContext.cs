using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstApp
{
    public class MyContext:DbContext
    {
        public MyContext()
            : base("MydbConn")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
            //More options for the database Initializer:
            //Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());
            //Database.SetInitializer<MyContext>(null);
//hi
        }
        public DbSet<Employee> Employees { get; set; } 

    }
}
