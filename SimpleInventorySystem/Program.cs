using System.Xml.Serialization;

namespace SimpleInventorySystem
{
    class Program
    {
        static void Main()
        {
            Inventory inventory = new Inventory();
            string choice;

            do
            {
                Menu();
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.Write("Enter product price: ");
                        double price = double.Parse(Console.ReadLine());
                        Product product = new Product(name, quantity, price);
                        inventory.AddProduct(product);
                        break;
                    case "2":
                        inventory.ViewAllProducts();
                        break;
                    case "3":

                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != "6");
        }
        static void Menu()
        {
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. View all Product");
            Console.WriteLine("3. Edit a Product");
            Console.WriteLine("4. Delete a Product");
            Console.WriteLine("5. Search for a product");
            Console.WriteLine("5. Exit");
        }
    }
}