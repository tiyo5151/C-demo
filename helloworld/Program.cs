﻿// See https://aka.ms/new-console-template for more information
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
  if (i == 3)
  {
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

List<string> names = ["Scott", "Ana", "Felipe"];
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

names.Sort();
names.Add("David");
names.Add("Damian");
names.Add("maria");

for (int i = 0; i < names.Count; i++)
{
  Console.WriteLine($"Hello {names[i].ToUpper()}!");
}

// Console.WriteLine(names[0]);
// Console.WriteLine(names[2]);
// Console.WriteLine(names[^1]);

// foreach (var name in names[2..4])
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// var names2 = new string[] { "Scott", "Ana", "Felipe" };

// names2 = [..names2, "Damian"];

// foreach (var name in names2)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }

var numbs = new List<int> {23,674,789,23,21,34,62,99};

Console.WriteLine($"I found 99 at index {numbs.IndexOf(99)}");
numbs.Sort();
Console.WriteLine($"I found 99 at index {numbs.IndexOf(99)}");

// foreach (var n in numbs)
// {
//   Console.WriteLine(n);
// }