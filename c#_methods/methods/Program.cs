using System.Collections;
using System.Diagnostics;

//using the random method
Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);
Console.WriteLine(dice.Next(8,11));


//method overloading
int number = 7;
string name = "chola";

//The first WriteLine() method uses a method signature that accepts an int parameter.
//The second WriteLine() method uses a method signature that accepts zero input parameters.
//The third WriteLine() method uses a method signature that accepts a string parameter.

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(name);

Random troi = new Random();
int roll1 = troi.Next();
int roll2 = troi.Next(10);
int roll3 = troi.Next(20,30);

Console.WriteLine($"first roll: {roll1}");
Console.WriteLine($"second roll: {roll2}");
Console.WriteLine($"third roll: {roll3}");