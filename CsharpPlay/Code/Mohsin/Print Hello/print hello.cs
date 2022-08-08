/* 1. Write a program to print Hello and your name in a separate line. 
   
        Expected Output:
        Hello: Alexandra Abramov  */

namespace CsharpPlay.Code.Mohsin.Print_Hello;

public partial class Hello 
{
    static public void PrintHello()
    {
        Console.WriteLine("Alexandra Abramov");
    }

    [Fact]
    public void PrintHelloTest()
    {
        Hello.PrintHello();
    }
}

