using System;
using System.Threading;

int monsterHP = 10;
int heroHP = 10;
Random attack = new Random();
int actionHero = 0;
int actionMonster = 0;

do
{
        actionHero = attack.Next(0, 6);
        if (actionHero == 0)
        { 
            Console.WriteLine("Hero tries to attack the monster but misses");
        }
        else
        { 
            monsterHP -= actionHero;
            Console.WriteLine($"Hero attacks the monster dealing {actionHero} damage to Monster who now has {monsterHP} Health Points.");
        }

         if (monsterHP <= 0) continue;

        actionMonster = attack.Next(0, 6);
        if (actionMonster == 0)
        {
            Console.WriteLine("Monster slashes at the Hero, but he swiftly dodges.");
        }
        else
        {
            heroHP -= actionMonster;
            Console.WriteLine($"Monster lunges at the Hero dealing {actionMonster} damage to Hero who now has {heroHP} Health Points.");
        }
} while (monsterHP >= 0 && heroHP >= 0);

Console.WriteLine(heroHP > monsterHP ? $"The monster loses his strenght and falls to the ground." : $"The hero loses his strenghts and faints");

