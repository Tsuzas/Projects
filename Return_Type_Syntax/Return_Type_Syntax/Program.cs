



using System.Security.Principal;

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}
if (TotalMeetsMinimun())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{

    return items[itemIndex] * (1 - discounts[itemIndex]);
}
bool TotalMeetsMinimun()
{
    return total >= minimumSpend;
}
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

//----------------------------------------------------------------------------------------------------//

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}
double  VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
//----------------------------------------------------------------------------------------------------//
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

string sentence = "there are snakes at the zoo";

Console.WriteLine(sentence);
Console.WriteLine(ReverseSentence(input));
string ReverseSentence(string input)
{
    string result = "";
    string[] words = sentence.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
