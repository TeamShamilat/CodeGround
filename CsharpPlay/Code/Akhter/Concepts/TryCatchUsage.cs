/*
    Key points: 
    1. Sometimes our application crashes due to unexpected errors and exceptions that occur during the program execution.
    2. Handling exceptions,C# provide try-catch block.
    3. Exceptions are problems in our application that are predictable while errors are not.
    4. A try-catch consists of a try block followed by one or more catch clauses.
    5. The finally block will always be executed whether an exception raised or not.    
 
*/

namespace CsharpPlay.Akhtar.Concepts;

public partial class TryCatchUsage
{
    public static string OutOfRange()
    {
        try
        {
            var counter = new int[5];           // put the code here that may raise exceptions.
            counter[12] = 10;
        }
        catch (IndexOutOfRangeException ex)
        {
            return ex.Message;                    // handle exception here.
        }
        return "null";
    }

}
public partial class TryCatchUsageTest
{
    [Fact]
    public void Tests()
    {
        string expected = "Index was outside the bounds of the array.";
        string actual = TryCatchUsage.OutOfRange();
        Assert.Equal(expected, actual);
    }

}