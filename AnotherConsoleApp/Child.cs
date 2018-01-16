using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherConsoleApp
{
    class Child
    {
        public string Name { get; set; }
        public bool Sick { get; set; }

        public string ForgeASickNote()
        {
            return (Sick) ? $"Please excuse {Name} from class today because they are very sick." : $"{Name} is good to go.";            
        }

    }
}
