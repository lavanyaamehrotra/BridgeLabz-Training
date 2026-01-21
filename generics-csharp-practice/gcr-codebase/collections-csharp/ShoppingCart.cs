using System;
using System.Collections.Generic;
using System.Collections.Specialized;
class ShoppingCart{
    static Dictionary<string, double> productPrices = new Dictionary<string, double>();
    static OrderedDictionary cart = new OrderedDictionary();
    static SortedDictionary<double, List<string>> sortedByPrice = new SortedDictionary<double, List<string>>();
    static void Main(){
        AddProduct("Laptop", 75000);
        AddProduct("Mouse", 1200);
        AddProduct("Keyboard", 2500);
        AddProduct("Monitor", 15000);
        Console.WriteLine("Shopping Cart (Insertion Order):");
        DisplayCart();
        Console.WriteLine("\nProducts Sorted By Price:");
        DisplaySortedByPrice();
    }
    // Add product to cart
    static void AddProduct(string productName, double price){
        productPrices[productName] = price;
        cart.Add(productName, price);
        UpdateSortedDictionary();
    }
    // Display cart in insertion order
    static void DisplayCart(){
        foreach (DictionaryEntry item in cart){
            Console.WriteLine($"{item.Key} : Rs{item.Value}");
        }
    }
    // Maintain sorted dictionary
    static void UpdateSortedDictionary(){
        sortedByPrice.Clear();
        foreach (var item in productPrices){
            if (!sortedByPrice.ContainsKey(item.Value)){
                sortedByPrice[item.Value] = new List<string>();
            }
            sortedByPrice[item.Value].Add(item.Key);
        }
    }
    // Display products sorted by price
    static void DisplaySortedByPrice(){
        foreach (var entry in sortedByPrice){
            foreach (var product in entry.Value){
                Console.WriteLine($"{product} : Rs{entry.Key}");
            }
        }
    }
}
