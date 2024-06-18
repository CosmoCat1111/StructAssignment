using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main()
        {
            Number num = new Number(); //creates object from the class
            num.Amount = 123.45m; //gives property a value
            Console.WriteLine("Amount:  " + num.Amount);
            Console.ReadLine();
        }
    }
}
