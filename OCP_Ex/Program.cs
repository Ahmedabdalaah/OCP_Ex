// See https://aka.ms/new-console-template for more information
using OCP_Ex;

Food food = new Food();
food.id = "1";
food.name = "apple";
food.price = 120;
Drink drink = new Drink();
drink.id = "1";
drink.name = "tea";
drink.price = 100;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"The tax of {food.name} is {food.CalculateTax(food.price)}");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"The tax of {drink.name} is {drink.CalculateTax(drink.price)}");
Console.ReadKey();
