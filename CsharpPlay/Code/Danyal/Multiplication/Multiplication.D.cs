///6.Write a program to print the output of multiplication of three numbers which will be entered by the user. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlay.Code.Danyal.Multiplication;

public partial class Multiplication
{
    static public int MultiplicationTests(int first , int second,int third )
    {
        return first * second *third;
    }

    [Theory]
    [InlineData(2,3,6,36)]
  

    public void FindMulatiplication(int first, int second, int third,int demand)
    {
        int actual = Multiplication.MultiplicationTests(first, second,third);
        Assert.Equal(demand, actual);
    }
}
