// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
string [] names = {"Ashik", "Masum", "Miraz", "Mood Swing"};
int [] numbers = {46, 3, 4, 1, 409, 46, 23, 12, 9, 64, 17, 2};
Console.WriteLine(names[3]);

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// foreach(string name in names )
// {
//     Console.WriteLine(name);
// }

Array.Sort(numbers);
foreach (int i in numbers)
{
    Console.WriteLine(i);
}