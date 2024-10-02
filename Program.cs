using Newtonsoft.Json;

namespace PetShopApp
{
    // Pet class definition
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
    }

    class Program
    {
        // JSON file path for storing pets data
        private const string JsonFilePath = @"C:\Users\nathan\Documents\STY-1991\pets.json";

        static void Main(string[] args)
        {
            // Load pets from the JSON file
            List<Pet> pets = LoadPets();

            while (true)
            {
                Console.Clear();

                // Display the main menu with a visually appealing design
                Console.WriteLine("\n┌──────────────────────────┐");
                Console.WriteLine("│      Pet Shop Menu       │");
                Console.WriteLine("└──────────────────────────┘\n");
                Console.WriteLine("\t1. Add Pet");
                Console.WriteLine("\t2. Remove Pet");
                Console.WriteLine("\t3. List Pets");
                Console.WriteLine("\t4. Exit");

                Console.Write("\nEnter your choice (1-4): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPet(pets);
                        break;
                    case 2:
                        RemovePet(pets);
                        break;
                    case 3:
                        ListPets(pets);
                        break;
                    case 4:
                        SavePets(pets);
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Function to add a pet to the list
        static void AddPet(List<Pet> pets)
        {
            Console.WriteLine("\n\n────────────────────────────");
            Console.WriteLine("Add a Pet");
            Console.WriteLine("────────────────────────────\n");

            Pet pet = new Pet();

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

        // Function to remove a pet from the list
        static void RemovePet(List<Pet> pets)
        {
            Console.WriteLine("\n\n────────────────────────────");
            Console.WriteLine("Remove a Pet");
            Console.WriteLine("────────────────────────────\n");

            Console.Write("Enter the pet name to remove: ");

            string petName = Console.ReadLine();

            // The "p =>" in this line is a lambda expression, where "p" represents a Pet object from the "pets" list, and the expression after "=>" is a condition that each Pet object should meet. In this case, it checks if the Pet object's Name property matches the petName.
            Pet petToRemove = pets.Find(p => p.Name == petName);

            // The "!= null" in this line checks if the petToRemove variable is not null, meaning a Pet object matching the given petName was found in the list. If petToRemove is null, it means no matching Pet object was found.
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

        // Function to display the list of pets
        static void ListPets(List<Pet> pets)
        {
            Console.WriteLine("\n\n────────────────────────────");
            Console.WriteLine("List of Pets");
            Console.WriteLine("────────────────────────────\n");

            int number = 1;
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"{number}. Name: {pet.Name}\tSpecies: {pet.Species}\tAge: {pet.Age}\tPrice: {pet.Price}\tColor: {pet.Color}");

                number++;
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadLine();
        }

        // Function to load pets from the JSON file
        static List<Pet> LoadPets()
        {
            List<Pet> pets;

            if (File.Exists(JsonFilePath))
            {
                // This line creates a new StreamReader object called "file" that opens the specified JsonFilePath for reading.
                // The "using" statement ensures that the StreamWriter is properly disposed of once it goes out of scope, closing the file and releasing any resources associated with it.
                using (StreamReader file = File.OpenText(JsonFilePath))
                {
                    // These lines create a new JsonSerializer object and then use the Deserialize method to convert the JSON data read from the "file" StreamReader object into a List<Pet> object.
                    // The deserialized List<Pet> object is then assigned to the "pets" variable, effectively loading the pet data from the JSON file.
                    JsonSerializer serializer = new JsonSerializer();
                    pets = (List<Pet>)serializer.Deserialize(file, typeof(List<Pet>));
                }
            }
            else
            {
                pets = new List<Pet>();
            }

            return pets;
        }

        // Function to save pets to the JSON file
        static void SavePets(List<Pet> pets)
        {
            // This line creates a new StreamWriter object called "file" that opens the specified JsonFilePath for writing.
            // The "using" statement ensures that the StreamWriter is properly disposed of once it goes out of scope, closing the file and releasing any resources associated with it.
            using (StreamWriter file = File.CreateText(JsonFilePath))
            {
                // These lines create a new JsonSerializer object and then use the Serialize method to convert the "pets" list into a JSON formatted string, which is then written to the "file" StreamWriter object, effectively saving the pet data to the JSON file.
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, pets);
            }
        }
    }
}
