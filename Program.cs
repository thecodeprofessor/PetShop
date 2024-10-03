using Newtonsoft.Json;

namespace PetShopApp
{
    // Pet class definition
    public class Pet
    {
        public string Name;
        public string Species;
        public int Age;
        public double Price;
        public string Color;
    }

    class Program
    {
        public static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;

        static List<Pet> pets = new List<Pet>();

        static void Main(string[] args)
        {
            LoadPets();

            while (true)
            {
                DisplayMenu();
            }
        }

        public static void DisplayMenu()
        {
            Console.Clear();

            Console.WriteLine("\n----------------------------");
            Console.WriteLine("       Pet Shop Menu");
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("\t1. Add Pet");
            Console.WriteLine("\t2. Remove Pet");
            Console.WriteLine("\t3. List Pets");
            Console.WriteLine("\t4. Save and Exit");

            Console.Write("\nEnter your choice (1-4): ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddPet();
                    break;
                case 2:
                    RemovePet();
                    break;
                case 3:
                    ListPets();
                    break;
                case 4:
                    SavePets();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again. Press any key to return to the main menu...");
                    Console.ReadLine();
                    break;
            }
        }

        // Method to add a pet to the list
        public static void AddPet()
        {
            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("Add a Pet");
            Console.WriteLine("----------------------------\n");

            var pet = new Pet();

            Console.Write("Enter pet name: ");
            pet.Name = Console.ReadLine();

            Console.Write("Enter pet species: ");
            pet.Species = Console.ReadLine();

            Console.Write("Enter pet age: ");
            pet.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter pet price: ");
            pet.Price = double.Parse(Console.ReadLine());

            Console.Write("Enter pet color: ");
            pet.Color = Console.ReadLine();

            pets.Add(pet);
            Console.WriteLine("\nPet added successfully.");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadLine();
        }

        // Method to remove a pet from the list
        public static void RemovePet()
        {
            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("Remove a Pet");
            Console.WriteLine("----------------------------\n");

            Console.Write("Enter the pet name to remove: ");

            string petName = Console.ReadLine();

            var petToRemove = pets.Find(pet => pet.Name == petName);

            if (petToRemove != null)
            {
                pets.Remove(petToRemove);
                Console.WriteLine("Pet removed successfully.");
            }
            else
            {
                Console.WriteLine("Pet not found.");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadLine();
        }


        public static void ListPets()
        {
            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("List of Pets");
            Console.WriteLine("----------------------------\n");

            var number = 1;
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"{number}. Name: {pet.Name}\tSpecies: {pet.Species}\tAge: {pet.Age}\tPrice: {pet.Price}\tColor: {pet.Color}");

                number++;
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadLine();
        }

        public static void LoadPets()
        {
            string filePath = Path.Combine(projectDirectory, "pets.json");

            try
            {
                string contents = File.ReadAllText(filePath);

                pets = JsonConvert.DeserializeObject<List<Pet>>(contents);
            }
            catch
            {
                pets = new List<Pet>();
            }

        }

        static void SavePets()
        {
            string filePath = Path.Combine(projectDirectory, "pets.json");

            string contents = JsonConvert.SerializeObject(pets, Formatting.Indented);
            File.WriteAllText(filePath, contents);
        }
    }
}
