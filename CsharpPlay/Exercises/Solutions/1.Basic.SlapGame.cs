
// 7.1. Write a program to print a random value from the array for slap game. 
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