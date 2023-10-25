using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1+roll2+roll3;

if((roll1==roll2) || (roll2==roll3) || (roll3==roll1))
{
    if((roll1==roll2) && (roll2==roll3))
    {
        Console.WriteLine("You rolled tripples; +6 bonus");
    total +=6;
    }
    else{
        Console.WriteLine("You rolled double; +2 bonus");
        total +=2;
    }
}

Console.WriteLine(total);