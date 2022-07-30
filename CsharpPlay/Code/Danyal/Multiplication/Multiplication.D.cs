using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlay.Code.Danyal.Multiplicast;

public partial class Multiplication
{
    static public int Sum(int first , int second)
    {
        return first * second;
    }

    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(4, 5, 20)]
    [InlineData(5, 6, 30)]
    [InlineData(6, 7, 42)]
    [InlineData(10, 10, 100)]
    [InlineData(5, 10, 50)]
    [InlineData(2, 2, 4)]

    public void FindSumtests(int first, int second, int demand)
    {
        int actual = Multiplication.Sum(first, second);
        Assert.Equal(demand, actual);
    }
}
