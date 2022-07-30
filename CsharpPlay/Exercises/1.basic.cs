
/*
1. Write a program to print Hello and your name in a separate line. 
   
        Expected Output:
        Hello: Alexandra Abramov 

2. Write a program to print the sum of two numbers. 

3. Write a program to print the result of dividing two numbers. 

4. Write a program to print the result of the specified operations. 
   
        Test data:
        -1 + 4 * 6
        ( 35+ 5 ) % 7
        14 + -4 * 6 / 11
        2 + 15 / 6 * 1 - 7 % 2
        Expected Output:
        23
        5
        12
        3

5. Write a program to swap two numbers. 
   
        Test Data:
        Input the First Number : 5
        Input the Second Number : 6
        Expected Output:
        After Swapping :
        First Number : 6
        Second Number : 5

6. Write a program to print the output of multiplication of three numbers which will be entered by the user. 


        Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36

7. Write a program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 


        Test Data:
        Input the first number: 25
        Input the second number: 4
        Expected Output:
        25 + 4 = 29
        25 - 4 = 21
        25 x 4 = 100
        25 / 4 = 6
        25 mod 4 = 1


7.1. Write a program to print a random value from the array for slap game.
 
 Test data:
 input: ["Danyal", "Mohsin", "Waqar", "Jibran", "Haris", "Ikhtisham"]
 Slapy: ??
 Slapper: ??
        
*/



namespace CsharpPlay.Danyal;

public partial class SlapGame
{

    static Random rnd = new Random();
    public static (int index, string value) GetRandomUser(string[] players)
    {
        int index = rnd.Next(0, 6); // generate value between (0 - 5)

        return (index, players[index]);
    }


    [Fact]
    public void ToUpperCaseFactTests()
    {
        string[] players = new string[] { "Danyal", "Mohsin", "Waqar", "Jibran", "Haris", "Ikhtisham" };

        var slappy = SlapGame.GetRandomUser(players);
        var slapper = SlapGame.GetRandomUser(players);

        while (slappy.index == slapper.index)
        {
            slapper = SlapGame.GetRandomUser(players);
        }

        string slappyValue = players[slappy.index];
        string slapperValue = players[slapper.index];

        Assert.Equal(slappy.value, slappyValue);
        Assert.Equal(slapper.value, slapperValue);
    }
}