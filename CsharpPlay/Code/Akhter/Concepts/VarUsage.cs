/*
    Key points: 
    1. The contextual keyword 'var' may only appear within a local variable declaration.
    2. Don’t use var for simple local variable types that are known to you.
    3. Use of var when you’re not sure what type of data will be stored in a variable.
    4. A var variable must be initialized at the time of declaration.

*/

namespace CsharpPlay.Akhtar.Concepts
{

    public partial class VarUsage
    {
        public int CountryCodes()
        {
            var CountryCode = 20;     // Only accept int value 
                                      // CountryCode  = "Ali";   // Cannot implicitly convert type 'string' to 'int'  
            return CountryCode;
        }

        //   public string GetCountry(var country)  // It Cannot be used as parameter/return type.
        // {
        //         var c = country;
        //         return c;
        // }
    }

    public partial class VarUsageTests
    {
        [Fact]
        public void Tests()
        {
            var objUsage = new VarUsage();
            var CountryCode = objUsage.CountryCodes();
            var expected = 20;
            Assert.Equal(expected, CountryCode);

            // var country = objUsage.GetCountry("Pakistan");

        }
    }
}