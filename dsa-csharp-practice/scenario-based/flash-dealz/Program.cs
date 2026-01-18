using System;
class Program{
    static void Main(){
        Product[] products = new Product[5];
        QuickSorter sorter = new QuickSorter();
        int choice;
        do{
            Console.WriteLine("\n===== FlashDealz Menu =====");
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Sort Products by Discount (Quick Sort)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    for (int i = 0; i < products.Length; i++){
                        products[i] = new Product();
                        Console.Write("\nEnter Product id: ");
                        products[i].ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Product Name: ");
                        products[i].ProductName = Console.ReadLine();
                        Console.Write("Enter Discount: ");
                        products[i].Discount = double.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    Console.WriteLine("\nID\tName\tDiscount");
                    foreach (Product p in products){
                        p.Display();
                    }
                    break;
                case 3:
                    sorter.QuickSort(products, 0, products.Length - 1);
                    Console.WriteLine("Products sorted");
                    break;

                case 4:
                    Console.WriteLine("\nThank you");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        } while (choice != 4);
    }
}
