﻿using System.ComponentModel.Design;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration >= 10)
{
Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration >= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save 10%!");

}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!\r\nRenew now and save 20%!");

}
else if (daysUntilExpiration > 0)
{
     Console.WriteLine("Your subscription has expired.");
    
}

