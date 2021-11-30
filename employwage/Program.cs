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
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMART", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("RELIANCE", 10, 4, 2);
            empWageBuilder.addCompanyEmpWage("none", 0, 1, 0);
            empWageBuilder.computeEmpWage();

        }
    }
}
