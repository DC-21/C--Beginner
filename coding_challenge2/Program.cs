using System;
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if(daysUntilExpiration<=10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if(daysUntilExpiration<=5){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.Renew now and save 10%!");
    discountPercentage = 10;
}
if(daysUntilExpiration==1){
    Console.WriteLine("Your subscription expires within a day! Renew now and save 20%!");
    discountPercentage = 20;
}
if(discountPercentage>0){
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}