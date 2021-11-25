using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employwage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart", 20, 50, 10);
            EmpWageBuilderObject Amazon = new EmpWageBuilderObject("Amazon", 10, 60, 20);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.ToString());
            Amazon.ComputeEmpWage();
            Console.WriteLine(Amazon.ToString());
            //Console.ReadLine();
        }
    }
}
