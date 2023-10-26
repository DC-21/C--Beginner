string me = "me nah lie";
char[] newMessage = me.ToCharArray();
Array.Reverse(newMessage);
int dr = 0;

foreach(char letter in newMessage){if(letter=='i') {dr++;}}

string new_message = new String(newMessage);
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {dr} times");