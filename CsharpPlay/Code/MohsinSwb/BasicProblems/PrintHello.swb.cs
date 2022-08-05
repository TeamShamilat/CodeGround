namespace CsharpPlay.MohsinSwb.BasicProblems
{
    public partial class PrintHello
    {
           public string Getname(){
            string name = "Alexandra Abramov";
            return name;
        }
      
    }

    public partial class PrintHelloTests
    {
        [Fact]
        public void Tests()
        {
            string expected = "Alexandra Abramov";
            PrintHello printHello = new PrintHello();
            string actual = printHello.Getname();
            Assert.Equal(expected,actual);
            
        }
    }
}