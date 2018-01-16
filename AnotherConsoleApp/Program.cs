using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new List<Child>
            {
                new Child { Name = "Suzy", Sick = false },
                new Child { Name = "Ralph", Sick = false } 
            };

            foreach (var child in children)
            {
                Console.WriteLine($"The kid's name is {child.Name}, and she is {(child.Sick == true ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }



            //var suzy = new Child { Name = "Suzy", Sick = false };
            //var ralph = new Child { Name = "Ralph", Sick = false };

            //children.Add(suzy);
            //children.Add(ralph);



            var lineRead = Console.ReadLine(); 



            
        }
    }
}
