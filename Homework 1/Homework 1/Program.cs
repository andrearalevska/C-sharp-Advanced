using Homework1.Domain.Models;

Cat cat = new Cat("Mimi", "white", 2, "sardines");
cat.PrintAnimal();
cat.Eat("tuna fish");

Dog dog = new Dog("Thor", "brown", 6, "ball");
dog.PrintAnimal();
dog.Bark();
