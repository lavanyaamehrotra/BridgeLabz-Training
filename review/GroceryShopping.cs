using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.grocery_shopping{
    internal class GroceryShopping{
        static void Main(){
            string[] Names = new string[10];
            double[] Prices = new double[10];
            int[] Stock = new int[10];
            int count = 0;
            int[] cartIndex = new int[10];
            int[] cartQty = new int[10];
            int cartCount = 0;
            int choice;
            do{
                Console.WriteLine("\n-----------GROCERY SHOP MENU -----------------");
                Console.WriteLine("1. Add Grocery Item");
                Console.WriteLine("2. View Items");
                Console.WriteLine("3. Buy Item");
                Console.WriteLine("4. View Cart & Total Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice){
                    case 1:
                        if (count >= 10){
                            Console.WriteLine("limit reached");
                            break;
                        }
                        Console.Write("Enter Item Name: ");
                        Names[count] = Console.ReadLine();
                        Console.Write("Enter Item Price: ");
                        Prices[count] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Quantity Available: ");
                        Stock[count] = Convert.ToInt32(Console.ReadLine());
                        count++;
                        Console.WriteLine("\nItem Added Successfully.");
                        break;
                    case 2:
                        if (count == 0){
                            Console.WriteLine("No items available.");
                            break;
                        }
                        Console.WriteLine("------------------AVAILABLE ITEMS-----------------------");
                        for (int i = 0; i < count; i++){
                            Console.WriteLine($"{i + 1}. {Names[i]}/t Price: Rs{Prices[i]} /t Stock: {Stock[i]}");
                        }
                        break;
                    case 3:
                        if (count == 0){
                            Console.WriteLine("No items available to buy.");
                            break;
                        }
                        Console.Write("Enter Item Number to Buy: ");
                        int id = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (id < 0 || id >= count){
                            Console.WriteLine("Invalid Item Number!");
                            break;
                        }
                        Console.Write("Enter Quantity: ");
                        int q = Convert.ToInt32(Console.ReadLine());
                        if (q > Stock[id]){
                            Console.WriteLine("No stock available.");
                            break;
                        }
                        cartIndex[cartCount] = id;
                        cartQty[cartCount] = q;
                        cartCount++;
                        Stock[id] -= q;
                        Console.WriteLine("\nItem added to cart.");
                        break;
                    case 4:
                        if (cartCount == 0){
                            Console.WriteLine("cart is empty!");
                            break;
                        }Console.WriteLine("--------CART SUMMARY----------");
                        double total = 0;
                        for (int i = 0; i < cartCount; i++){
                            int idx = cartIndex[i];
                            double sub = Prices[idx] * cartQty[i];
                            Console.WriteLine($"{Names[idx]} x {cartQty[i]} = Rs{sub}");
                            total += sub;
                        }
                        Console.WriteLine($"\nGross Total = Rs{total}");
                        break;
                    case 5:
                        Console.WriteLine("Thank you for shopping");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }
    }
}