namespace CsharpPlay.Danyal
{
    public partial class CodeDanyalString
    {
        static public string ToUpperCase(string s)
        {
            return s.ToUpper();
        }
    }

    public partial class CodeDanyalStringTests
    {
        [Fact]
        public void ToUpperCaseFactTests()
        {
            string input = "Danyal";
            string expected = "DANYAL";
            string actual = CodeDanyalString.ToUpperCase(input);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Danyal", "DANYAL")]
        [InlineData("sAna", "SANA")]
        [InlineData("mohsin", "MOHSIN")]
        public void ToUpperCaseTheoryTests(string input, string expected)
        {
            string actual = CodeDanyalString.ToUpperCase(input);
            Assert.Equal(expected, actual);
        }
    }
}