using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Preson
    {
        public Preson() 
        {
            
        }
        public Preson(string name, ushort age)
        { 
            Name = name;
            Age = age;
        }

        public string Name { set; get; }

        public ushort Age { set; get; }
        public void SayName()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
        }
    }
}
