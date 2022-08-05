namespace CsharpPlay.MohsinSwb.BasicProblems
{
    public partial class Operations
    {
     public static int Add(int one,int two)
        {
            return one + two;
        }

        [Theory]
        [InlineData (23,7,30)]

        public void AddTest(int one,int two,int expected)
        {
           int actual = Operations.Add(one,two);
           Assert.Equal(expected,actual);
        }
        

         public static int Sub(int one,int two)
        {
            return one - two;
        }

        [Theory]
        [InlineData (23,3,20)]

        public void SubTest(int one,int two,int expected)
        {
           int actual = Operations.Sub(one,two);
           Assert.Equal(expected,actual);
        }

    }
}