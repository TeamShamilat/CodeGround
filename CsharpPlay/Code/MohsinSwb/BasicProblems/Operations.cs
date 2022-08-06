namespace CsharpPlay.MohsinSwb.BasicProblems
{
    public partial class Operations
    {
     public static int Add(int one,int two)
        {
            return one + two;
        }
         public static int Sub(int one,int two)
        {
            return one - two;
        }
        public static int Mul(int one,int two)
        {
            return one * two;
        }
         public static int Div(int one,int two)
        {
            return one / two;
        }
        public static int Mod(int one,int two)
        {
            return one % two;
        }

        [Theory]
        [InlineData (23,7,30)]

        public void AddTest(int one,int two,int expected)
        {
           int actual = Operations.Add(one,two);
           Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData (23,3,20)]

        public void SubTest(int one,int two,int expected)
        {
           int actual = Operations.Sub(one,two);
           Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData (6,6,36)]

        public void MulTest(int one,int two,int expected)
        {
           int actual = Operations.Mul(one,two);
           Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData (48,6,8)]

        public void DivTest(int one,int two,int expected)
        {
           int actual = Operations.Div(one,two);
           Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData (31,3,1)]

        public void ModTest(int one,int two,int expected)
        {
           int actual = Operations.Mod(one,two);
           Assert.Equal(expected,actual);
        }


    }
}