using System;
Random random = new Random();
string[] orderIds = new string[5];
//loop through each blank order
for(int i=0; i<orderIds.Length; i++)
{
      // Get a random value that equates to ASCII letters A through E
      int prefixValue = random.Next(65,70);
      //convert random value into char then string
      string prefix = Convert.ToChar(prefixValue).ToString();
       // Create a random number, pad with zeroes
       string suffix = random.Next(1,3000).ToString("000");
       //combine prefix and suffix
       orderIds[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIds)
{
    Console.WriteLine(orderID);
}
