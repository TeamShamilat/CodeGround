/*
    Key points: 
    1. Interface can contain declarations of method, properties, indexers, and events.
    2. It is used to achieve multiple inheritance which can't be achieved by class.
    3. Its implementation must be provided by class.
    4. Interface is used to achieve fully abstraction
    5. Interface cannot include private, protected, or internal members. All the members are public by default.
    6. It is used to achieve loose coupling.
    7. A class can only use one abstract class.
    8. A class can use multiple interface.
  
*/

namespace CsharpPlay.Akhtar.Concepts
{

    interface IPolygon
    {
        int calculateArea(int a, int b);     //Method signature
    }

    public class Rectangle : IPolygon
    {
        public int calculateArea(int a, int b)  //Method implementation here
        {  

            int area = a * b;
            return area;
        }
        public partial class AbstractVsInterfaceTest
        {
            [Theory]
            [InlineData(2, 4, 8)]
            [InlineData(12, 2, 24)]
            [InlineData(10, 10, 100)]
            public void Tests(int a, int b, int expected)
            {
                Rectangle rectangle = new Rectangle();
                int actual = rectangle.calculateArea(a, b);
                Assert.Equal(actual, expected);
            }
        }
    }
}