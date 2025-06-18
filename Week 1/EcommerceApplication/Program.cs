using System;
using System.Linq;

namespace ECommercePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sample products
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Smartphone", "Electronics"),
                new Product(3, "Headphones", "Audio"),
                new Product(4, "T-shirt", "Clothing"),
                new Product(5, "Jeans", "Clothing")
            };

            Console.WriteLine("E-commerce Platform Search Demo");
            Console.WriteLine("==============================");

            // Demonstrate Linear Search
            Console.WriteLine("\nLinear Search Demo:");
            Console.WriteLine("-------------------");
            int searchId = 3;
            Product foundProduct = ProductSearch.LinearSearch(products, searchId);
            Console.WriteLine($"Searching for Product ID {searchId} using Linear Search:");
            Console.WriteLine(foundProduct != null ? $"Found: {foundProduct}" : "Product not found");

            // Demonstrate Binary Search
            Console.WriteLine("\nBinary Search Demo:");
            Console.WriteLine("-------------------");
            // Sort products first (required for binary search)
            ProductSearch.SortProducts(products);
            foundProduct = ProductSearch.BinarySearch(products, searchId);
            Console.WriteLine($"Searching for Product ID {searchId} using Binary Search:");
            Console.WriteLine(foundProduct != null ? $"Found: {foundProduct}" : "Product not found");

            // Performance Analysis
            Console.WriteLine("\nPerformance Analysis:");
            Console.WriteLine("--------------------");
            Console.WriteLine("Linear Search:");
            Console.WriteLine("- Time Complexity: O(n)");
            Console.WriteLine("- Best Case: O(1) - when item is at the beginning");
            Console.WriteLine("- Worst Case: O(n) - when item is at the end or not found");
            Console.WriteLine("- Average Case: O(n/2)");

            Console.WriteLine("\nBinary Search:");
            Console.WriteLine("- Time Complexity: O(log n)");
            Console.WriteLine("- Best Case: O(1) - when item is at the middle");
            Console.WriteLine("- Worst Case: O(log n) - when item is at the ends or not found");
            Console.WriteLine("- Average Case: O(log n)");

            Console.WriteLine("\nRecommendation:");
            Console.WriteLine("For an e-commerce platform:");
            Console.WriteLine("1. Use Binary Search when the product catalog is sorted and large");
            Console.WriteLine("2. Use Linear Search when the catalog is small or frequently updated");
            Console.WriteLine("3. Consider using a hash table (Dictionary) for O(1) lookups if memory is not a constraint");
        }
    }
}