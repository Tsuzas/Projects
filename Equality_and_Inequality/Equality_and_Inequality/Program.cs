/*
 * This code bases on permission and levels
 * 
 * Permissions are Admin or Manager
 * 
 * Levels go from  to 55
 * 
 * enjoy
*/

string permission = "";
int level = 0;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}

if (permission.Contains("Manager"))
{
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
