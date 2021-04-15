using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ArrayEmpWage
    {
        private ArrayEmpWage[] companyEmpWageArray;
        public void EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new ArrayEmpWage[5];
        }
        // 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        return totalEmployeeHour* companyEmpWage.empRatePerHour;
    }
}
