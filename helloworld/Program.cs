// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, Tiyo5151!");

string firstFriend = "Maria";
// firstFriend = firstFriend.TrimStart();
string secondFriend = "Scott";

string friends = $"My friends are {firstFriend} and {secondFriend}";

Console.WriteLine(friends);
// friends = friends.Replace("Scott", "Damian");
Console.WriteLine(friends.Contains("Scott"));
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.Length);
Console.WriteLine(friends.StartsWith("My "));
// Console.WriteLine($"My friends are " + firstFriend + " and " + secondFriend.Trim());

int a = 2147483647;
int b = 6;
// float c = checked(a + b);
int c = a + b;
Console.WriteLine(c);

decimal d = 42.1M;
decimal e = 24.1M;
decimal f = checked(d + e);
Console.WriteLine(f);
Console.WriteLine($"The answer for this is {f}");

// int aa = int.Parse(Console.ReadLine());
// int bb = int.Parse(Console.ReadLine());
// int cc = aa + bb;
// bool mytest = cc > 10;
// if (mytest)
// {
//     Console.WriteLine("The answer is greater than 10.");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10.");
// }

int ax = 5;
int bx = 3;
int cx = 4;
if ((ax + bx + cx > 10) && (ax == bx))
{
  Console.WriteLine("The answer is greater than 10");
  Console.WriteLine("And the first number is equal to the second");
}
else
{
  Console.WriteLine("The answer is not greater than 10");
  Console.WriteLine("Or the first number is not equal to the second");
}

int counter = 0;
do
{
  Console.WriteLine(counter);
  counter++;
}
while (counter < 5);

for (int i = 0; i < 5; i++)
{
  if (i == 3) {
  Console.WriteLine(i);
  }
}

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}