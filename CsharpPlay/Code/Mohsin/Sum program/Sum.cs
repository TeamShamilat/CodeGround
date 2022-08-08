

/*  2. Write a program to print the sum of two numbers.   */

namespace CsharpPlay.Code.Mohsin.Sum_program;

public class Sum_num

{
    static public int Sum(int first, int second)
    {
        return first + second;
    }

    [Fact]
    public void SumTest()
    {
        int expected = 14;
        int actual = Sum_num.Sum(6, 8);
        Assert.Equal(expected, actual);

        expected = 19;
        actual = Sum_num.Sum(11, 8);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(30, 5, 35)]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 1)]
    [InlineData(13, 15, 28)]
    [InlineData(113, 15, 128)]
    [InlineData(9, 8, 17)]
    [InlineData(35, 42, 77)]
    [InlineData(35, 62, 97)]
    public void SumTestTheory(int first, int second, int expected)
    {
        int actual = Sum_num.Sum(first, second);
        Assert.Equal(expected, actual);
    }
}
