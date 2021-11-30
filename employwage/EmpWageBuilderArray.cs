using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace employwage
{
    public class EmpWageBuilderArray
    {
        // Declare Constant
        public const int Full_Time = 1;
        public const int Part_Time = 2;

        private int numofCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int Emp_rate_per_Hrs, int Max_Working_Hrs, int Max_Working_Days)
        {
            companyEmpWageArray[this.numofCompany] = new CompanyEmpWage(company, Emp_rate_per_Hrs, Max_Working_Hrs, Max_Working_Days);
            numofCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
            }
        }
        // Create a Method
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            // Variable declaration
            int No_of_Working_Days = 0;
            int empHrs = 0;
            int workingHrs = 0;
            while (No_of_Working_Days <= companyEmpWage.Max_Working_Days && workingHrs < companyEmpWage.Max_Working_Hrs)
            {
                No_of_Working_Days++;
                Random r = new Random();
                int check = r.Next(1, 4);
                switch (check)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                workingHrs += empHrs;
                Console.WriteLine("Days: " + No_of_Working_Days + " Emp Hrs: " + empHrs);
                Console.ReadLine();
            }
            //Calculate Total Employee Wage
            return empHrs * companyEmpWage.Emp_rate_per_Hrs;
            
        }
        

    }
}