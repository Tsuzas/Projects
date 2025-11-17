using System.Formats.Asn1;

Random random = new Random();
Random randomEnemy = new Random();
bool Answer = false;

Console.WriteLine("Would you like to play? (Y/N)");
var resposta = Console.Read();
resposta.ToLower().Trim();

if (ShouldPlay(resposta))
{
    PlayGame();
}
else if (ShouldPlay(resposta))
{
    Console.WriteLine("Okidoki byebye");
}

    void PlayGame()
    {
        var play = true;

        while (play)
        {

            int target = randomEnemy.Next(0, 10);
            Console.WriteLine($"Roll a number greater than {target} to win!");
            int roll = random.Next(0, 10);
            Console.WriteLine($"You rolled a {roll}");
            Console.WriteLine(WinOrLose(target, roll));
            Console.WriteLine("\nPlay again? (Y/N)");

            play = ShouldPlay(resposta);
        }
    }


bool ShouldPlay(string resposta)
{
    Console.WriteLine(resposta);

    if (resposta == null)
    {
        Console.WriteLine("Choose Something Y/N");
    }
    else if (resposta != null)
    {
        if (resposta == "Y")
        {
            return Answer = true;
        }
        else if (resposta == "N")   
        {
            return Answer = false;
        }
    }
    return Answer;
}

string WinOrLose(int target, int roll)
{
    if (target > roll)
    {
        Console.WriteLine("You loose");
    }
    else 
    { 
        Console.WriteLine("You win");
    }
    return null;
}
