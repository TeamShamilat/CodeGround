// 1. Write a program to print Hello and your name in a separate line.  
namespace CsharpPlay.Exercises.BasicProblems;

public partial class Basic
{
    static public void PrintHello()
    {
        Console.WriteLine("Alexandra Abramov");
    }

    [Fact]
    public void PrintHelloTest()
    {
        Basic.PrintHello();
    }
}