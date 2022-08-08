
/*7.Write a program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 


        Test Data:
        Input the first number: 25
        Input the second number: 4
        Expected Output:
        25 + 4 = 29
        25 - 4 = 21
        25 x 4 = 100
        25 / 4 = 6
        25 mod 4 = 1  */



namespace CsharpPlay.Code.Mohsin.oparter2;
public class Oparter
{
    [Fact]
    public void AllOperater()
    {
        var result1 = 25 + 4;
        var result2 = 25 - 4;
        var result3 = 25 * 4;
        var result4 = 25 / 4;
        var result5 = 25 % 4;

        Assert.Equal(29, result1);
        Assert.Equal(21, result2);
        Assert.Equal(100, result3);
        Assert.Equal(6, result4);
        Assert.Equal(1, result5);
    }
}
