
using Task2.Domain;
using Task2.Domain.Models;
using Task2.Domain.Enums;

PetStore<Cat> CatStore = new PetStore<Cat>(new List<Cat>
{
    new Cat ("Molly", PetType.Cat, 5, true, 7),
    new Cat ("Cookie", PetType.Cat, 2, false, 5),
});

PetStore<Dog> DogStore = new PetStore<Dog>(new List<Dog>
{
    new Dog ("Lana", PetType.Dog, 3, "chicken fillet"),
    new Dog ("Kaiser", PetType.Dog, 6, "pork steak"),
});

PetStore<Fish> FishStore = new PetStore<Fish>(new List<Fish>
{
    new Fish ("Sky", PetType.Fish, 1, "blue", "small"),
    new Fish ("Nemo", PetType.Fish, 2, "gold", "medium"),
});

Console.WriteLine("Buying a cat in the Cat store.");
CatStore.BuyPet("Molly");

Console.WriteLine("Buying a dog in the Dog store.");
DogStore.BuyPet("Cookie");
DogStore.BuyPet("Kaiser");

Console.WriteLine("Remaining cats in the store:");
CatStore.PrintPets();

Console.WriteLine("Remaining dogs in the store:");
DogStore.PrintPets();

Console.WriteLine("Remaining fishes in the store:");
FishStore.PrintPets();


