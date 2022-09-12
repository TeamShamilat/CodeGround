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

namespace CsharpPlay.Code.Danyal.ExecrciesSolution;

public partial class ExerciserBasic
{
    static public string GetDay(int day)
    {
        string[] days = { "Sunday", "Monday", "Wednesday", "Thursday", "Friday", "Saturday" };
        if(day < 0 || day > days.Length)
        {
            return string.Empty;
        }

        return days[day];
    }

    [Theory]
    [InlineData(0, "Sunday")]
    [InlineData(1, "Monday")]
    [InlineData(-10, "")]
    [InlineData(12, "")]
    [InlineData(5, "Saturday")]
    static public void GetDayTests(int day, string expected)
    {
        var actual = ExerciserBasic.GetDay(day);

        Assert.Equal(actual, expected);
    }
}
