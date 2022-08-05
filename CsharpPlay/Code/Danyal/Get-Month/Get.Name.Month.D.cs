//Write a function getDay(int day) that converts int day to day name.
//examples: 

//getDay(1)->Monday
//getDay(0)->Sunday
//getDay(3)->Wednesday
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlay.Code.Danyal.Get_Day;

public partial class Mathematics
{
    static public string getDay( int day)
    {
        string[] days = { "Sunday","Monday", "Wednesday", "Thursday", "Friday", "Saturday"};

        return days[day];


        ///int  days = Convert.ToInt32(Console.ReadLine());
        

    }
    
}



