using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student : Occupation
    {
        //prop
        private string name { get; set; }

        private double saraly { get; set; }

        private string gender { get; set; }

        //const
        public Student(string name, double saraly, string gender)
        {
            this.name = name;
            this.saraly = saraly;
            this.gender = gender;
        }

        //method

        public override double Gettax()
        {
            return (saraly * 0) / 100;
        }
    }
}
