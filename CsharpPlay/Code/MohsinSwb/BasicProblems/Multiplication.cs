/*
6. Write a program to print the output of multiplication of three numbers which will be entered by the user. 
*/

namespace CsharpPlay.MohsinSwb.BasicProblems
{
    public partial class Multiplication
    {
       static public int Multiply(int one,int two,int three)
       {
        return one * two * three;
       }

       [Theory]
       [InlineData (2, 5, 5,50)]

       public void MultiplicationTests(int one,int two,int three,int demand )
       {
       int actual = Multiplication.Multiply(one,two,three);
       Assert.Equal(demand,actual);
       }
    }
}