// 2. Write a program to print the sum of two numbers. 
// int Sum(int first, int second)
namespace CsharpPlay.Exercises.BasicProblems;

public partial class Basic
{
    static public int Sum(int first, int second)
    {
        return first + second;
    }

    [Fact]
    public void SumTest()
    {
        int expected = 8;
        int actual = Basic.Sum(3, 5);
        Assert.Equal(expected, actual);

        expected = 30;
        actual = Basic.Sum(12, 18);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 5, 8)]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 1)]
    [InlineData(13, 15, 28)]
    [InlineData(113, 15, 128)]
    [InlineData(9, 8, 17)]
    [InlineData(35, 42, 77)]
    [InlineData(35, 62, 97)]
    public void SumTestTheory(int first, int second, int expected)
    {
        int actual = Basic.Sum(first, second);
        Assert.Equal(expected, actual);
    }
}