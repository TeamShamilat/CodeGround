/*
    Key points: 
    1. The variables are declared using var keyword are statically typed.
    2. The variables are declared using dynamic keyword are dynamically typed.
    3. Using of var keyword compiler check variable type at compile time.
    4. Using of dynamic keyword compiler check variable type at run time.
    5. In case of var, variable must be initialized.
    6. In case of using dynamic, variable does not required initialzation.
 
*/

namespace CsharpPlay.Akhtar.Concepts
{
    public partial class VarVsDynamic
    {
        dynamic Gpa = 0;   // dyanmic appear within class ,method etc.
        // var  vGpa = 3.5;   // var may only appear within a local variable declaration

        public dynamic GetGpa()
        {
            Gpa = 4.0;
            // var marks = 33;        // It means if we assign the integer value at time of declaration then further we can not assign string, double etc. 
            //  marks = "Pass";   // Cannot implicitly convert type 'string' to 'int'

            Gpa = 3.5;    // In case of dynamic type there are no such types of restrictions.
            return Gpa;
        }

        /*
            We can’t create a method with var as return type
            and also We can’t use the var keyword as a parameter for any method.

        */
        // public var SetGpa(var gpa){    
        //     return gpa;
        // }


        public dynamic SetGpa(dynamic gpa)    //We can use dynamic type as parameter for method.Also as a return type is dynamic
        {
            return gpa;
        }
    }

    public partial class VarVsDynamicTest
    {
        [Theory]
        [InlineData(3.5)]

        public void Test(dynamic expected)
        {
            dynamic dGpa = new VarVsDynamic();
            Assert.Equal(expected, dGpa.GetGpa());
        }

    }
}