/*
    Key points: 
    1. In C#, generic means not specific to a particular data type.
    2. C# allows to define generic classes,interfaces,method and property without the specific data type.
    3. A generic type is declared with special syntax like TypeName<T> where T is a type parameter.
    4. A generic class increases the reusability.
    5. A generic class can be a base class to other generic or non-generic classes or abstract classes.

  
*/

namespace CsharpPlay.Akhtar.Concepts
{

    public partial class GenericUsage<T>
    {
        public T Add(T input){
            return input;
        }
    }
    public partial class GenericUsageTest
    {

    
        [Fact]
        public void Tests()
        {
            GenericUsage<int> list = new GenericUsage<int>();
           var expected =  list.Add(3);
           var actual = 3;
           Assert.Equal(expected,actual);
           
        // Declare a list of type string.
        var actualS = "john";
        GenericUsage<string> list2 = new GenericUsage<string>();
        var exptectedS = list2.Add("john");
        Assert.Equal(actualS,exptectedS);
        }
    }
}
