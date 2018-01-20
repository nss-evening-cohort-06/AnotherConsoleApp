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
                if (child.Name == "Suzy")
                {
                    continue; //this stops this iteration
                    //break; //this ends the entire loop 
                }
                Console.WriteLine($"The kid's name is {child.Name}, and she is {(child.Sick == true ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }



            //var suzy = new Child { Name = "Suzy", Sick = false };
            //var ralph = new Child { Name = "Ralph", Sick = false };

            //children.Add(suzy);
            //children.Add(ralph);


            //KINDLE class stuff

            var kindles = new List<Kindle>
            {
                new Kindle { BatteryPercent = .87, NumberOfBooks = 24 },
                new Kindle { BatteryPercent = .12, NumberOfBooks = 24 },
                new Kindle { BatteryPercent = .50, NumberOfBooks = 24 }
            };

            foreach (var kindle in kindles)
            {
                Console.WriteLine(kindle.KindleStatus()); 
            }



            string input = Console.ReadLine();
            string output = ""; 

            for (var i = 0; i < input.Length; i++)
            {
                output += input[i].ToString().ToUpper(); 
                output += new String(input[i], i);
                output += (i != input.Length - 1) ? "-" : ""; 
            }
            Console.WriteLine(output);

            var hello = Console.ReadLine();


        }
    }
}
