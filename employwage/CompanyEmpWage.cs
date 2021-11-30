using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employwage
{
    class CompanyEmpWage
    {
        public string company;
        public int Emp_rate_per_Hrs;
        public int Max_Working_Hrs;
        public int Max_Working_Days;
        public int TotalempWage;

        //Create a Constructor
        public CompanyEmpWage(string company, int Emp_rate_per_Hrs, int Max_Working_Hrs, int Max_Working_Days)
        {
            this.company = company;
            this.Emp_rate_per_Hrs = Emp_rate_per_Hrs;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
        }

        public void setTotalEmpWage(int TotalempWage)
        {
            this.TotalempWage = TotalempWage;
        }

        public string tostring()
        {
            return "Total Emp Wage For Company: " + this.company + " is " + this.TotalempWage;
        }

    }
}
