using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{


    class CompanyEmpWage
    {

        public string companyname;
        public int emprateperhour;
        public int numofworkingdays;
        public int maxhourspermonth;
        public int totalempwage;

        public CompanyEmpWage(string companyName, int emprateperhour, int numofworkingdays, int maxhourspermonth)
        {
            this.companyname = companyName;
            this.numofworkingdays = numofworkingdays;
            this.emprateperhour = emprateperhour;
            this.maxhourspermonth = maxhourspermonth;

        }
        public void setTotalEmpWage(int totalempwage)
        {
            this.totalempwage = totalempwage;

        }
        public string toString()
        {
            return "Employee's wage for Working in " + this.companyname + " is " + this.totalempwage;
        }
    }
}

