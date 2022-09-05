/*
    Key points: 
    1. Ref and Out keywords are used to passed arguments into  method.
    2. Both indicate that an parameter is passed by reference not by value.
    3. In case of Ref the parameter or argument must be initialized first before it is passed to ref.
    4. In case of Out it is not compulsory to initialize a parameter or argument before it is passed to an out.
    5. In case of Ref passing a parameter value by Ref is useful when the called method is also needed to modify the pass parameter.
    6. In case of Out declaring a parameter to an out method is useful when multiple values need to be returned from a method.
    7. Method overloading is not possible when one method take param as ref and other one out.
	


*/

namespace CsharpPlay.Akhter.Concepts
{

    public partial class RefVsOut
    {
        public static int IncreaseNumber(ref int i)
        {
            i++;   // It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.
            return i;
        }

        public static int GetNextNumber(out int x){
           // x++;  Use of unassigned out parameter 'x'
           x = 1; //it must be initilize in case of out 
            return x;
        }
    }

    public partial class RefVsOutTests
    {
        [Fact]
        public void Tests()
        {
            int expected = 2;
            //int no;   //Use of unassigned local variable 'no'.In case of Ref it must be initialize
            int no = 1;
            int actual = RefVsOut.IncreaseNumber(ref no);
            Assert.Equal(expected, actual);

            //using of out keyword

            int expectedOut = 1;
            int valueOut;  //There is no need of initilize variable in case of Out.
            int actualOut = RefVsOut.GetNextNumber(out valueOut);
            Assert.Equal(expectedOut,actualOut);


        }
    }
}
