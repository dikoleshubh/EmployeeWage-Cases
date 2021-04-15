using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Wage
    {
        public static void EmpWage()
        {
            int p = 1, n ,a , empwage;
            
            int empRatePerHour = 20;
            int empDaysPerMonth = 20 , days =1;
            for (n = 1; n >= 0; n++)
            {
                if( n == 10)
                {
                    Console.WriteLine("Value of N =" + n);
                    continue;
                }
                Random random = new Random();
                a = random.Next(0, 1);
                if(a == 1)
                {
                    
                    days++;
                    
                    if(days == 20)
                    {
                        empwage = empRatePerHour * 8*days;
                        Console.WriteLine("Days of Employee" +days);
                        Console.WriteLine("Empoyee Wage=" +empwage);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {

                    continue;
                }

                            }
        }
    }
}
