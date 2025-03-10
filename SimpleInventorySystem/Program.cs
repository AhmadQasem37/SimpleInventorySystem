﻿using System.Xml.Serialization;

namespace SimpleInventorySystem
{
    class Program
    {
        static void Main()
        {
            Inventory inventory = new Inventory();
            string choice;

            Console.WriteLine("\t\t\t\tSimple Inventory Management System");

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
                        decimal price = decimal.Parse(Console.ReadLine());
                        Product product = new Product(name, quantity, price);
                        inventory.AddProduct(product);
                        break;
                    case "2":
                        inventory.ViewAllProducts();
                        break;
                    case "3":
                        Console.Write("Enter product name to edit: ");
                        string newName = Console.ReadLine();
                        inventory.EditProduct(newName);
                        break;
                    case "4":
                        Console.Write("Enter product name to delete: ");
                        string namee = Console.ReadLine();
                        inventory.DeleteProduct(namee);
                        break;
                    case "5":
                        Console.Write("Enter product name to search: ");
                        string searchName = Console.ReadLine();
                        inventory.SearchProduct(searchName);
                        break;
                    case "6":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine();
            } while (choice != "6");
        }
        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. View all Product");
            Console.WriteLine("3. Edit a Product");
            Console.WriteLine("4. Delete a Product");
            Console.WriteLine("5. Search for a product");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }
    }
}