/*
5. Write a program to swap two numbers. 
*/


namespace CsharpPlay.mohsinSwb.BasicProblems

{
    public partial class Swapping

    {
      static public (int one,int two) swap(int oneNum,int twoNum)

      {
         int tempVal = oneNum;
         oneNum = twoNum;
         twoNum = tempVal;

         return (oneNum,twoNum);
      }

      [Theory]
      [InlineData(10, 15)]
      [InlineData(18, 30)]
      [InlineData(50, 16)]
      public void SwappingTest(int oneNum,int twoNum)
      {
         var actual = Swapping.swap(oneNum,twoNum);
         Assert.Equal((twoNum,oneNum),actual);
      }
    }
}