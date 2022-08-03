//7.Write a program to print on screen the output of adding,
//subtracting, multiplying and dividing of two numbers which
//will be entered by the user. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace CsharpPlay.Code.Danyal.Calculator;

    public partial class CalculatorTests
    {
    public static int Add(int first, int second)
    {
        return first + second;

    }


    public static int Subtruction(int first, int second)
    {
        return first - second;

    }
    public static int Multiplication(int first, int second)
    {
        return second * first;
    }

    static public int DividingTests(int first, int second)
    {
        return first / second;
    }

    static public int ModolusTests(int first ,int second)
    {
        return (first % second);
    }

    [Theory]
    [InlineData(25, 4, 29)]
    public void FindAddTests(int first, int second, int expected)
    {

        int actual = CalculatorTests.Add(first, second);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25, 4, 21)]
    public void FindSubructionTests(int first, int second,int expected)
    {
        int actual = Subtruction(first, second);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25,4,100)]
    public void FindMultiplicationTests(int first,int second,int expected)
    {
        int actual = Multiplication(first, second);
         Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25,4,6)]
    public void FindDividingTests(int first, int second,int expected)
    {
        int actual = DividingTests(first, second);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25,4,1)]
    public void FindModulasTests(int first, int second , int expacted)
    {
        int actual = ModolusTests(first, second);
        Assert.Equal(expacted, actual);
    }

}




