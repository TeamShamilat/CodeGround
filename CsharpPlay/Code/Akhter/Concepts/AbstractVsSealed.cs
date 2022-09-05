/*
    Key points: 
    1. The abstract keyword are used to create classes and class members that are  must be implemented in a derived class.
    2. An abstract class cannot be instantiated.
    3. The sealed keyword enables you to prevent the inheritance of a class.
    4. A sealed class cannot be used as a base class.
    5. An abstract method is implicitly a virtual method.
    6. An abstract method in C# is internally a virtual method 
    7. An abstract inherited method can be overridden in a derived class
    8. An abstract class also have non abastract method.
*/

namespace CsharpPlay.Akhtar.Concepts
{

    public abstract class Shape
    {
        // public Shape()       An abstract class can have constructors as well. 
        // {
        //      Console.WriteLine("Shape Constructor");
        // }

        public abstract int GetArea(int n);

        // non-abstract method
        public double AreaOfCircle(int r)
        {
            return Math.PI * r * r;
        }

    }
    public class Square : Shape
    {
        public override int GetArea(int n)
        {
            return n * n;
        }
    }
    public sealed class Bird
    {
        public string MakeSound(string s)
        {
            return s;
        }
    }
    // public class Parrot:Bird{      //'Parrot': cannot derive from sealed type 'Bird'

    // }

    public partial class AbstractVsSealedTest
    {
        [Fact]
        public void Tests()
        {
            int _no;
            int _expected;
            int _actual;
            //  Shape s = new Shape();        // Cannot create an instance of the abstract type or interface 
            Square _s = new Square();
            _no = 12;
            _expected = 144;
            _actual = _s.GetArea(_no);
            Assert.Equal(_actual, _expected);
        }
    }
}