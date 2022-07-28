/*
    Key points: 
    1. Static classes cannot have instance constructors.
    2. Access modifiers are not allowed on static constructors.
*/



namespace CsharpPlay.Akhtar.Concepts
{
    static public partial class StaticMyth
    {
        public const string name = "Faisal";
        public static string gender = "Male";
        static StaticMyth()
        {
            gender = "m";
        }
    }

    public partial class StaticMythTests
    {
         [Fact]
        public void Tests()
        {
            string _ = "";
            string expected = "=";

            _ = StaticMyth.name;
            expected = "Faisal";
            Assert.Equal(expected, _);

            _ = StaticMyth.gender;
            expected = "m";
            Assert.Equal(expected, _);
        }
    }
}