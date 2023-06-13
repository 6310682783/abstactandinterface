using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public abstract class Occupation {
        //prop
        protected string name { get; set; }

        protected double saraly { get; set; }

        protected string gender { get; set; }

        //method
        public void Whoami() {
            Console.WriteLine("hello occupation");
        }
        public abstract double Gettax();

    }
    
      
    
}
