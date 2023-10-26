//strings
string[] myName = {"chola","chama","chansa"};

foreach(string name in myName)
{
    Console.WriteLine(name);
};

//integers
int[] inventory = {12,13,14,15,16,17,18,19,20};
int sum = 0;
int bin = 0;
foreach(int item in inventory)
{
    sum+=item;
    bin++;
    Console.WriteLine($"bin {bin} = {item} items running  (Running total: {sum})");
};
Console.WriteLine($"we have {sum} items in inventory");