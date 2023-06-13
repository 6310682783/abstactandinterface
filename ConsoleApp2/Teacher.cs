using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Teacher : Occupation
    {
        public Teacher(string _name, double _saraly, string _gender)
        {
            name = _name;
            saraly = _saraly;
            gender = _gender; 
        }

        //method

        public void Whoami() {
            Console.WriteLine($"{name} is a teacher");
        }
        public override double Gettax()
        {
            return (saraly*4)/100;
        }
    }
}
