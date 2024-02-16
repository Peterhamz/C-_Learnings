// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

int totalScore = 0;

start:
Console.WriteLine("1 - small, 2-medium, 3-large");
int UserChoice = int.Parse(Console.ReadLine());

switch (UserChoice)
{
    case 1:
        totalScore += 1; 
        break;
    case 2:
        totalScore += 2;
        break;
    case 3:
        totalScore += 3;
        break;
    case 4:
        default: Console.WriteLine("Your choice {0} is invalid", UserChoice );
        break;
}

Buy_Coffee:
Console.WriteLine("Do you want to buy another coffee?");
string choice = Console.ReadLine();

switch (choice.ToUpper())
{
    case "YES":
        goto start;
    case "NO":
        break;
    default: Console.WriteLine("Your Choice {0} is invalid... please enter a correct choice", choice);
        goto Buy_Coffee;

}

Console.WriteLine("Thank you for Shoping with us");
Console.WriteLine("Your Bill ammount = {0}", totalScore);