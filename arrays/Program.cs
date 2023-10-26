using System;
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0]="001a";
fraudulentOrderIDs[1]="002b";
fraudulentOrderIDs[2]="003c";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

//reassign values
fraudulentOrderIDs[0]="2100DiCE";
Console.WriteLine($"Reassigned value: {fraudulentOrderIDs[0]}");