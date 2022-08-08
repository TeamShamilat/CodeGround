
//3.Write a program to print the result of dividing two numbers. 

namespace CsharpPlay.Code.Mohsin.dividing_program;

public class Dividing

{
    static public int Div(int first, int second)
    {
        return first / second;
    }

    [Fact]
    public void DivTest()
    {
        int expected = 2;
        int actual = Dividing.Div(14, 7);
        Assert.Equal(expected, actual);

        expected = 5;
        actual = Dividing.Div(20, 4);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(30, 5,6)]
    [InlineData(25, 5, 5)]
    [InlineData(49, 7, 7)]
    [InlineData(12, 3, 4)]
    [InlineData(9, 3, 3)]
    [InlineData(36, 4, 9)]
    [InlineData(45, 15, 3)]
    [InlineData(28, 7, 4)]
    public void DivTestTheory(int first, int second, int expected)
    {
        int actual = Dividing.Div(first, second);
        Assert.Equal(expected, actual);
    }
}


