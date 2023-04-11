
using Task2.Domain.Models;

namespace Task2.Domain
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets = new List<T>();
       
        public PetStore( List<T> pets)
        {
            Pets = pets;
        }

        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine($"{pet.Type} {pet.Name}");
            }
        }

        public void BuyPet(string name)
        {
            Pet pet = Pets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());

            if (pet != null)
            {
                Console.WriteLine($"You bought {pet.Name} the {pet.Type}!");
                Pets.Remove((T) pet);
            }
            else
            {
                Console.WriteLine($"There is no pet named {name} in this store.");
            }
        }

    }
}
