using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample_Staticconstructor
{
    internal class employee
    {
        //instance variables
        int eno;
        string ename;
        int esal;
        //static variable
        static string CompanyName;
        static employee()//static constructor.
        {//static constructor is used to assign the data to static variables
            CompanyName = "Microsoft";
            //eno = 100;//Don't assign normal variables inside static constructor.it will throw compiletime error.
        }
        public employee(int empno, string empname, int empsal)
        {//non static  constructor is used to assign the data to instance variables
            eno = empno;
            ename = empname;
            esal = empsal;
           
        }
        public void displayempinfo()
        {
            Console.WriteLine("emp no is:" + eno);
            Console.WriteLine("emp name is:" + ename);
            Console.WriteLine("salry is:" + esal);
            Console.WriteLine("companny name is:" + CompanyName);
        }
    }
}
