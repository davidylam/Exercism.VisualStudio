using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Year
{

    public static bool IsLeap(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            return true;
        }

        return false;
    }
    /*
    public static bool IsLeap(int year)
    {
        bool leapYear = false;
        bool DivisibleBy4 = year % 4 == 0;
        bool DivisibleBy100 = year % 100 == 0;
        bool DivisibleBy400 = year % 400 == 0;

        if (DivisibleBy400)
        {
            leapYear = true;
        }
        else if (DivisibleBy4 && DivisibleBy100) {
            leapYear = false;
        }
        else{ 
            if ( DivisibleBy4)
            {
                leapYear = true;
            }
            else
            {
                leapYear =  false;
            }
        }
        return leapYear;
    }
    */
}
