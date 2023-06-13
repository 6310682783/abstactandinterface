using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Occupation {
        //method
        public void Whoami() {
            Console.WriteLine("hello occupation");
        }
        public abstract double Gettax();

    }
    
      
    
}
