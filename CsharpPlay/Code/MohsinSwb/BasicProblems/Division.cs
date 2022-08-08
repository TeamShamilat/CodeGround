/*
3. Write a program to print the result of dividing two numbers. 
*/

namespace CsharpPlay.MohsinSwb.BasicProblems;

public partial class ExerciserBasic
{
    static public int Division(int number, int divideBy)
    {
        return number / divideBy;
    }

    [Theory]
    [InlineData(36, 6, 6)]
    [InlineData(88, 11, 8)]
    [InlineData(90, 10, 9)]
    [InlineData(33, 3, 11)]
    [InlineData(64, 3, 21)]
    public void DivisionTest(int number, int divideBy, int expected)
    {
        int actual = ExerciserBasic.Division(number, divideBy);

        Assert.Equal(expected, actual);
    }
}
