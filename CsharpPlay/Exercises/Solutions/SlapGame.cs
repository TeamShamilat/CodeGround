
// 7.1. Write a program to print a random value from the array for slap game. 
namespace CsharpPlay.Danyal;

public partial class SlapGame
{
    static Random rnd = new Random();
    public static (string slappy, string slapper) Play()
    {
        int index = rnd.Next(0, 6); // generate value between (0 - 5)
        string[] players = new string[] { "Danyal", "Mohsin", "Waqar", "Jibran", "Haris", "Ikhtisham" };

        var slappy = players[index];
        var slapper = players[index];

        while (slappy == slapper)
        {
            index = rnd.Next(0, 6);
            slapper = players[index];
        }

        return (slappy, slapper);
    }

    [Fact]
    public void ToUpperCaseFactTests()
    {
        var players = SlapGame.Play();
        Assert.NotEqual(players.slappy, players.slapper);

        players = SlapGame.Play();
        Assert.NotEqual(players.slappy, players.slapper);

        players = SlapGame.Play();
        Assert.NotEqual(players.slappy, players.slapper);

        players = SlapGame.Play();
        Assert.NotEqual(players.slappy, players.slapper);

        players = SlapGame.Play();
        Assert.NotEqual(players.slappy, players.slapper);
    }
}