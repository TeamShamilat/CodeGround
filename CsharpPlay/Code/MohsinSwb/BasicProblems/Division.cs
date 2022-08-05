namespace CsharpPlay.MohsinSwb.BasicProblems
{
    public partial class Division

    {
       public int GetDivision()
       {
        int num = 36 / 6;
        return num;
       }
        [Fact]

        public void DivisionTest()
       
        {
            int expected =6;
         Division division = new Division();
         int actual =division.GetDivision();
        Assert.Equal(expected,actual);
        }
    }
}
