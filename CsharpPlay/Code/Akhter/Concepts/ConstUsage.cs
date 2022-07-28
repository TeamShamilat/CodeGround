namespace CsharpPlay.Akhtar.Concepts
{
    public partial class ConstUsage
    {
        public const string name = "Faisal";
        public string gender = "m";
    }

    public partial class ConstUsageTests
    {
        [Fact]
        public void Tests()
        {
            string _ = "";
            /*
                I have not created instance of the class.
                constand are class level not instance level.
            */

            // string gender = ConstUsage.gender; // can't access because it is instance level
            _ = ConstUsage.name;
            string expected = "Faisal";
            Assert.Equal(expected, _);

            ConstUsage constUsage = new ConstUsage();
            _ = constUsage.gender; // now I access because it is instance level
            // _ = constUsage.name; // can't access because it is class level
        }
    }
}