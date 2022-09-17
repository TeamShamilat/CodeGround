namespace SOLID_Principles;
/*
Key points:
1.  When we have a base class and child class relationships i.e.
    inheritance relationships, then, if we can successfully replace the
    object/instance of a parent class with an object/instance of the child class,
    without affecting the behavior of the base class instance, then it is said to be in Liskov Substitution Principle.


*/

//Without using the Liskov Substitution Principle :

public class Apple
{
    public virtual string GetColor()
    {
        return "Red";
    }
}
public class Orange : Apple
{

    public override string GetColor()
    {
        return "Orange";
    }
}

// Using the Liskov Substitution Principle
/*We need a generic base class such as Fruit which is going to be the base class for both Apple and Orange.
 Now you can replace the Fruit class object with its subtypes either Apple and Orage and it will behave correctly*/
public abstract class Fruit
{
    public abstract string GetColor();
}
public class Apples : Fruit
{
    public override string GetColor()
    {
        return "Red";
    }
}
public class Oranges : Fruit
{
    public override string GetColor()
    {
        return "Orange";
    }
}
public class LiskovSubstitutionPrinciple
{
    /* when we call the GetColor i.e. apple.GetColor(),
    then we are getting the color of the Orange not the color of Apple. That means once the child object is replaced i.e.
    Apple storing the Orange object, the behavior is also changed. This is against the LSP Principle */

    [Fact]
    public void WithoutLSPTest()
    {
        Apple apple = new Orange();
        var color = apple.GetColor();
        Assert.DoesNotMatch(color, "Apple");
    }
    [Fact]
    public void LiskovSubstitutionPrincipleTest()
    {
            Fruit fruit = new Oranges();
            var orange = fruit.GetColor();
            fruit = new Apples();
            var apple = fruit.GetColor();
            Assert.Equal("Red",apple);
    }

}