using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contoso.com";

GetCorporate();
Console.WriteLine();
GetExternal();
void GetCorporate()
{
    Console.WriteLine($"Corporate E-mails: ");
    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        string firstName = corporate[i, 0];
        string twoLetters = firstName.Substring(0, 2);
        string lastName = corporate[i, 1];
        Console.WriteLine(twoLetters + lastName + "@" + internalDomain);
    }
}

void GetExternal()
{
    Console.WriteLine("External Emails: ");
    for (int i = 0; i < external.GetLength(0); i++)
    {
        string firstName = external[i, 0];
        string twoLetters = firstName.Substring(0, 2);
        string lastName = external[i, 1];
        Console.WriteLine(twoLetters + lastName + "@" + externalDomain);
    }
}
