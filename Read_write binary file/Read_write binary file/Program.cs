using System;
using System.Collections.Generic;
using System.IO;

namespace Read_write_binary_file
{
    class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Product Code: {ProductCode}, Product Name: {ProductName}, Manufacturer: {Manufacturer}, Price: {Price}, Description: {Description}";
        }
    }

    class Program
    {
        const string FilePath = @"E:\SUMMER_2023\C#\csharp_day6\Read_write binary file\Read_write binary file\products.txt";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Search product");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        ShowProducts();
                        break;
                    case "3":
                        SearchProduct();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
            }
            Console.ReadKey();
        }

        static void AddProduct()
        {
            bool available = false;

            while (true)
            {
                Console.WriteLine("Enter product details:");

                Console.Write("Product Code: ");
                string productCode = Console.ReadLine();

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Manufacturer: ");
                string manufacturer = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Product productAdd = new Product
                {
                    ProductCode = productCode,
                    ProductName = productName,
                    Manufacturer = manufacturer,
                    Price = price,
                    Description = description
                };

                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Product product = new Product
                        {
                            ProductCode = sr.ReadLine(),
                            ProductName = sr.ReadLine(),
                            Manufacturer = sr.ReadLine(),
                            Price = double.Parse(sr.ReadLine()),
                            Description = sr.ReadLine()
                        };

                        if (product.ProductCode == productCode.ToString())
                        {
                            Console.WriteLine("Product code is available \n");
                            available = true;
                            break;
                        }
                    }
                }

                if (available) break;

                using (StreamWriter sw = new StreamWriter(FilePath, true))
                {
                    sw.WriteLine(productAdd.ProductCode);
                    sw.WriteLine(productAdd.ProductName);
                    sw.WriteLine(productAdd.Manufacturer);
                    sw.WriteLine(productAdd.Price);
                    sw.WriteLine(productAdd.Description);
                }

                Console.WriteLine("Product added successfully" + "\n");
                break;
            }
        }


        static void ShowProducts()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    Product product = new Product
                    {
                        ProductCode = sr.ReadLine(),
                        ProductName = sr.ReadLine(),
                        Manufacturer = sr.ReadLine(),
                        Price = double.Parse(sr.ReadLine()),
                        Description = sr.ReadLine()
                    };

                    Console.WriteLine(product + "\n");
                }
            }
        }

        private static void SearchProduct()
        {
            Console.Write("Enter product code to search: ");
            string searchCode = Console.ReadLine();

            bool found = false;

            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    Product product = new Product
                    {
                        ProductCode = sr.ReadLine(),
                        ProductName = sr.ReadLine(),
                        Manufacturer = sr.ReadLine(),
                        Price = double.Parse(sr.ReadLine()),
                        Description = sr.ReadLine()
                    };

                    if (product.ProductCode == searchCode.ToString())
                    {
                        Console.WriteLine(product+"\n");
                        found = true;
                        break;
                    }
                }
                
            }

            if (!found)
            {
                Console.WriteLine("Product not found");
            }
        }

    }
}
