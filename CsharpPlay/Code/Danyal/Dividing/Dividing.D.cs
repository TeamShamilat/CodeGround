///3.Write a program to print the result of dividing two numbers. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlay.Code.Danyal.Dividing;

public partial class Dividing
{
    static public int DividingTest(int first, int second)
    {
        return first / second;
    }
    [Theory]
    [InlineData(5,5,1)]
    [InlineData(10,5,2)]
    [InlineData(12,6,2)]
    [InlineData(200,40,5)]
    [InlineData(10,10,1)]

    public void FindDividingTest(int first,int second, int demand)
    {
        int actual = Dividing.DividingTest(first, second);
        Assert.Equal(demand, actual);
    }
}

