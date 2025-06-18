using System;

namespace ECommercePlatform
{
    public class ProductSearch
    {
        // Linear Search Implementation
        // Time Complexity: O(n) - where n is the number of products
        public static Product LinearSearch(Product[] products, int productId)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductId == productId)
                {
                    return products[i];
                }
            }
            return null;
        }

        // Binary Search Implementation
        // Time Complexity: O(log n) - where n is the number of products
        // Note: Array must be sorted by ProductId for binary search to work
        public static Product BinarySearch(Product[] products, int productId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (products[mid].ProductId == productId)
                {
                    return products[mid];
                }

                if (products[mid].ProductId < productId)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }

        // Helper method to sort products by ProductId
        public static void SortProducts(Product[] products)
        {
            Array.Sort(products, (p1, p2) => p1.ProductId.CompareTo(p2.ProductId));
        }
    }
} 