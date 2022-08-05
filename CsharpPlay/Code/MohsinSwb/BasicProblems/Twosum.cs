namespace CsharpPlay.MohsinSwb.Twosum

{
    public partial class Twosum
    {
         public int GetSum()
        {
            int num = 12 + 8;
             return num;
        }

        [Fact]
        
        public void SumTest()
        {
            int expected =20;
            Twosum twosum =new Twosum();
            int actual = twosum.GetSum();
            Assert.Equal(expected, actual);
        }

    }
}
