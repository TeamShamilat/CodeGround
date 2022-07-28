/*
    Key points: 
    1. Static classes cannot have instance constructors.
    2. Access modifiers are not allowed on static constructors.
    3.The constant 'gender' cannot be marked static.
    4.Static classes are sealed class and therefore, cannot be inherited.
    5.Static members of non-static classes are shared across all the instances of the class.
    6.Static methods can be overloaded but cannot be overridden.
    7.Static class contain only static variables,  methods,  properties, and static constructors.
*/



namespace CsharpPlay.Akhtar.Concepts
{
    static public partial class StaticMyth
    {
        public const string name = "Faisal";
        public static string gender = "Male";
      //  public static const string gender  //I have not use static with const b/c const by default is static
        static StaticMyth()
        {
            gender = "m";
        }
        

        /*
            Can declare static method in a static class
        */
         public static string GetFullName(string FName ,string LName){
            string FullName= string.Concat(FName,LName);
            return FullName;
        }

        /*

        /--Cannot declare instance members in a static class --/

        public string GetAuthors(){
            return null;
        }

        */
    }

    public partial class StaticMythTests
    {
         [Fact]
        public void Tests()
        {
            string _ = "";
            string expected = "=";

              //  StaticMyth sObj= new StaticMyth(); // We cannot create an instance of a static class.

            _ = StaticMyth.name;  //Static properties or variable can be accessed directly using a class name like StaticMyth.name
            expected = "Faisal";
            Assert.Equal(expected, _);

            _ = StaticMyth.gender;
            expected = "m";
            Assert.Equal(expected, _);

            expected="Kamal Shah";
            _=StaticMyth.GetFullName("Kamal"," Shah");
            Assert.Equal(expected,_);
        }
    }

    /*
    'ExtendMyth': cannot derive from static class 'StaticMyth'
    */
    // public class ExtendMyth:StaticMyth{

    // }
}