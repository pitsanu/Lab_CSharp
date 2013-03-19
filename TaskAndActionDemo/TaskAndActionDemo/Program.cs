using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskAndActionDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            ChildClass obj = new ChildClass();
            obj.Act(new object());
            Console.WriteLine("Program Main");
            Console.Read();
        }
    }
}
