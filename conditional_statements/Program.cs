using Internal;
using System;

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1+roll2+roll3;
if((roll1==roll2) || (roll2==roll3) || (roll1==roll3)){
    Console.WriteLine("You win doubles, bonus 2");
    total += 2;
}

if((roll1==roll2) && (roll2==roll3))
{
    Console.WriteLine("You rolled Tripples; plus 6");
    total +=6;
}

if(total>=14){
    Console.WriteLine("you win");
}else{
    Console.WriteLine("you loose");
}
Console.WriteLine(total);