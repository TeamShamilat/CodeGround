/*
    Key points: 
    1. The variables are declared using var keyword are statically typed.
    2. The variables are declared using dynamic keyword are dynamically typed.
    3. Using of var keyword compiler check variable type at compile time.
    4. Using of dynamic keyword compiler check variable type at run time.
    5. In case of var, variable must be initialized.
    6. In case of using dynamic, variable does not required initialzation.
 
*/

namespace CsharpPlay.Akhtar.Concepts;
public partial class VarVsDynamic
{
    [Fact]
    public void Tests()
    {
       var userList = new List<dynamic> {
        new List<string> {"20", "Asif", "Mardan"},
        new List<int> {20, 50, 60, 80}
       };

        Console.WriteLine(userList[0][1]);
    }

}