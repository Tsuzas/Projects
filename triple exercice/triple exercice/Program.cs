using Microsoft.VisualBasic;
using System.ComponentModel.Design;

bool accessKey = false;
int accessNumber = 0;
do
{
    Console.WriteLine("Please give me an integer with a value between 5 and 10.");
    string number = Console.ReadLine();
    accessNumber = int.Parse(number);

    if (accessNumber >= 5 & accessNumber <= 10)
    {
        accessKey = true;
    }   
    else
    {
        Console.WriteLine("Try again you ");
    }
} while (accessKey == false);

    Console.WriteLine("Integer correct, granting access ...");

do
{
    Console.WriteLine("What is your current rank withtin our company?");
    string accessKeyRank = Console.ReadLine();
    accessKeyRank.ToLower().Trim();

    switch (accessKeyRank)
    {
        case "administrator":
            Console.WriteLine("Your input value Administrator has been accepted.");
            accessKey = false;
            break;
        case "manager":
            Console.WriteLine("Your input value Manager has been accepted.");
            accessKey = false;
            break;
        case "user":
            Console.WriteLine("Your input value User has been accepted.");
            accessKey = false;
            break;
        default:
            Console.WriteLine("The role entered was not valid. Enter your role name as 'Administrator' 'Manager' 'User'");
            break;
    }
}
while (accessKey == true);
    Console.WriteLine("Welcome to the company. 'Dramatic music ensues'");

do
{
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    int stringsCount = myStrings.Length;

    string myString = "";
    int periodLocation = 0;

    for (int i = 0; i < stringsCount; i++)
    {
        myString = myStrings[i];
        periodLocation = myString.IndexOf(".");

        string mySentence;

        // extract sentences from each string and display them one at a time
        while (periodLocation != -1)
        {

            // first sentence is the string value to the left of the period location
            mySentence = myString.Remove(periodLocation);

            // the remainder of myString is the string value to the right of the location
            myString = myString.Substring(periodLocation + 1);

            // remove any leading white-space from myString
            myString = myString.TrimStart();

            // update the comma location and increment the counter
            periodLocation = myString.IndexOf(".");

            Console.WriteLine(mySentence);
        }

        mySentence = myString.Trim();
        Console.WriteLine(mySentence);
    }
    accessKey = true; 
}
while (accessKey == false);