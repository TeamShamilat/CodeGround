//3.Write a program to print the result of dividing two numbers. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlay.Code.Danyal.Dividing;

public partial class Dividing
{
    static public int DividingTests(int first, int second)
    {
      return first / second;
    }
    [Theory]
    [InlineData(5,5,1)]
    [InlineData(12,6,2)]
    [InlineData(30,10,3)]
    [InlineData(36,6,6)]
    [InlineData(42,7,6)]

    public void FindDividingTests(int first,int second,int demand)
    {
        int actual = Dividing.DividingTests(first, second);
        Assert.Equal(demand, actual);
    }
}

