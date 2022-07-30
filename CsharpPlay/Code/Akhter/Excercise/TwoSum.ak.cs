namespace CsharpPlay.Akhtar;

public partial class Excercises_Basic
{
    static public int Sum(int first, int second)
    {
        return first + second;
    }

    [Theory]
    [InlineData(4, 5, 9)]
    [InlineData(5, 5, 10)]
    [InlineData(8, 12, 20)]
    [InlineData(12, 12, 24)]
    public void FindMaxTests(int first, int second, int expected)
    {
        int actual = Excercises_Basic.Sum(first, second);
        Assert.Equal(expected, actual);
    }
}