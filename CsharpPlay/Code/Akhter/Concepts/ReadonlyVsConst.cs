/*
    Key points: 
    1. 	readonly is a constant defined at runtime.
    2.  const is used to create a constant at compile time.
    3.  readonly fields cannot be define inside a method.
    4.  const fields can be declared inside a method.
     

*/

namespace CsharpPlay.Akhter.Concepts
{

    public partial class ReadonlyVsConst
    {
        public readonly string FullName;
        const string ProductName = "Visual C#";
        public ReadonlyVsConst(string fName, string lName)
        {
            FullName = string.Concat(fName, lName);
            //  ProductName = fName;  The left-hand side of an assignment must be a variable, property or indexer
        }

        // void ChangeFullName(){   // A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer
        //     FullName = "Jhon Smith"; 
        // }

    }

    public partial class ReadonlyVsConstTest
    {
        [Theory]
        [InlineData("ali", " khan", "ali khan")]
        [InlineData("john", " smith", "john smith")]
        [InlineData("smith", " tom", "smith tom")]
        [InlineData("sett", " pat", "sett pat")]
        [InlineData("abbie", " kan", "abbie kan")]
        public void Tests(string fName, string lName, string expected)
        {
            ReadonlyVsConst read = new ReadonlyVsConst(fName, lName);
            Assert.Equal(expected, read.FullName);
        }
    }
}
