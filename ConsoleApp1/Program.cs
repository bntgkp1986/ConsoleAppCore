using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParentClass
    { 
    
    }

    public class DerivedClass
    {
        string name;
        public DerivedClass(string name)
        {
            this.name = name;
            Console.WriteLine("Ctor - " + this.name);
        }

        public void Print()
        {
            Console.WriteLine(this.name);
        }
    }
     
    class Program
    {
        
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass("Brajesh Tripathi");
            obj.Print();
            Console.ReadLine();
        }
    }
}
