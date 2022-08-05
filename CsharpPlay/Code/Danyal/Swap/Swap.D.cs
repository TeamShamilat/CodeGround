///5.Write a program to swap two numbers. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlay.Code.Danyal.Swap;

public partial class SwapExample
{
    public static (int first, int second) Swap(int firstNum, int secondNum)
    {
        // Swapping
        int tempVal = firstNum;
        firstNum = secondNum;
        secondNum = tempVal;

        return (firstNum, secondNum);
    }

    [Theory]
    [InlineData(34, 50)]
    [InlineData(100, 200)]
    [InlineData(600, 800)]
    [InlineData(1254, 542)]
    public static void SwapTests(int firstNum, int secondNum)
    {
        // Swapping
        var actual = SwapExample.Swap(firstNum, secondNum);

        Assert.Equal((secondNum, firstNum), actual);
    }
}
