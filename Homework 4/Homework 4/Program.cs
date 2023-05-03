using Homework4.Domain;
using Homework4.Domain.Models;

DataBase<Dog> dogsDb = new DataBase<Dog>();

Console.WriteLine("Enter dog name here:");
string nameInput= Console.ReadLine();

Console.WriteLine("Enter dog color here:");
string colorInput = Console.ReadLine();

Console.WriteLine("Enter dog age here:");
string notParsedInput = Console.ReadLine();
bool success = int.TryParse(notParsedInput, out int ageInput);

if (success)
{
    Dog firstDog = new Dog(nameInput, ageInput, colorInput);
    dogsDb.insertItem(firstDog);
}
else
{
    Console.WriteLine("Insert numbers only!");
}

Dog secondDog = new Dog("Lana", 3, "brown");
Dog thirdDog = new Dog("Kaiser", 6, "black");

dogsDb.insertItem(secondDog);
dogsDb.insertItem(thirdDog);

Console.WriteLine("Current results from Data Base:");
dogsDb.PrintAll();


