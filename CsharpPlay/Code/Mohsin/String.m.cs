namespace CsharpPlay.Mohsin
{
    public partial class CodeMohsinString
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
            string actual = CodeMohsinString.ToUpperCase(input);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Danyal", "DANYAL")]
        [InlineData("sAna", "SANA")]
        [InlineData("mohsin", "MOHSIN")]
        [InlineData("Jibran", "JIBRAN")]
        public void ToUpperCaseTheoryTests(string input, string expected)
        {
            string actual = CodeMohsinString.ToUpperCase(input);
            Assert.Equal(expected, actual);
        }
 
        [Fact]
        public void ToUpperCaseFactAsTheory()
        {
            var input = "Danyal";
            var expected = "DANYAL";

            string actual = CodeMohsinString.ToUpperCase(input);
            Assert.Equal(expected, actual);

            input = "sAna";
            expected = "SANA";

            actual = CodeMohsinString.ToUpperCase(input);
            Assert.Equal(expected, actual);

            input = "mohsin";
            expected = "MOHSIN";

            actual = CodeMohsinString.ToUpperCase(input);
            Assert.Equal(expected, actual);

            input = "Jibran";
            expected = "JIBRAN";

            actual = CodeMohsinString.ToUpperCase(input);
            Assert.Equal(expected, actual);
        }
    }
}