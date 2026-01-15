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
        {
            employee emp1 = new employee(121, "rama", 1000);//this is emp1 object
            emp1.displayempinfo();
            employee emp2 = new employee(122, "raju", 2000);//this is emp2 object
            emp2.displayempinfo();
            Console.ReadLine();
        }
    }
}
