/* 6. Write a program to print the output of multiplication of three numbers which will be entered by the user. 

        Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36   */

namespace CsharpPlay.Code.Mohsin.multiplytion;
public class Multiply
{
    static public int Mul(int first, int second, int thir)
    {
        return first * second * thir;
    }

    [Fact]
    public void MulTest()
    {
        int expected = 36;
        int actual = Multiply.Mul(2, 3, 6);
        Assert.Equal(expected, actual);
    }
}
