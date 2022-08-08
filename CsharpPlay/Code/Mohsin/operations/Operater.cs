/*   4.Write a program to print the result of the specified operations. 

       Test data:
       -1 + 4 * 6
       (35 + 5) % 7
       14 + -4 * 6 / 11
       2 + 15 / 6 * 1 - 7 % 2
       Expected Output:
       23
       5
       12
       3   */

namespace CsharpPlay.Code.Mohsin.operations;

public class MaxOperater
{
    [Fact]
    public void DoOperation()
    {
        var result1 = -1 + 4 * 6;
        var result2 = (35 + 5) % 7;
        var result3 = 14 + -4 * 6 / 11;
        var result4 = 2 + 15 / 6 * 1 - 7 % 2;

        Assert.Equal(23, result1);
        Assert.Equal(5, result2);
        Assert.Equal(12, result3);
        Assert.Equal(3, result4);
    }
}
