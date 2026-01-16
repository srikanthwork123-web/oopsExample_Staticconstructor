using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample_Staticconstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {//when you create object for one class.first your class load .in that time if any static constructor is there it will call firsttime.
            employee emp1 = new employee(121, "rama", 1000);//this is emp1 object
            emp1.displayempinfo();
            employee emp2 = new employee(122, "raju", 2000);//this is emp2 object
            emp2.displayempinfo();
            Console.ReadLine();
        }
    }
}
