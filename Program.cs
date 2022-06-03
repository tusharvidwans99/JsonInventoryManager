namespace JsonInventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReadJson read = new ReadJson();

            TypesOfInventary inventory = new TypesOfInventary();

            inventory = read.ReadtheJson("C:/Users/tusha/source/repos/JsonInventoryManagement/JsonInventoryManagement/InventoryJson.json");

            //Console.WriteLine(rice.price);
            //Console.WriteLine(rice.weight);
            //Console.WriteLine(rice.name);

            int value = 0;

            for (int i = 0; i < inventory.typesOfRice.Count; i++)
            {
                Console.WriteLine(inventory.typesOfRice[i].name);
                Console.WriteLine(inventory.typesOfRice[i].weight);
                Console.WriteLine(inventory.typesOfRice[i].price);
                value = inventory.typesOfRice[i].weight * inventory.typesOfRice[i].price;
                Console.WriteLine($"Value of {inventory.typesOfRice[i].name} is {value}");
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("Types of Wheat: ");

            for (int i = 0; i < inventory.typesOfWheat.Count; i++)
            {
                Console.WriteLine(inventory.typesOfWheat[i].name);
                Console.WriteLine(inventory.typesOfWheat[i].weight);
                Console.WriteLine(inventory.typesOfWheat[i].price);
                value = inventory.typesOfWheat[i].weight * inventory.typesOfWheat[i].price;
                Console.WriteLine($"Value of {inventory.typesOfWheat[i].name} is {value}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Types of Pulses: ");

            for (int i = 0; i < inventory.typesOfPulses.Count; i++)
            {
                Console.WriteLine(inventory.typesOfPulses[i].name);
                Console.WriteLine(inventory.typesOfPulses[i].weight);
                Console.WriteLine(inventory.typesOfPulses[i].price);
                value = inventory.typesOfPulses[i].weight * inventory.typesOfPulses[i].price;
                Console.WriteLine($"Value of {inventory.typesOfPulses[i].name} is {value}");
            }
        }



    }
}