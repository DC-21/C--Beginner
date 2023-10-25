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