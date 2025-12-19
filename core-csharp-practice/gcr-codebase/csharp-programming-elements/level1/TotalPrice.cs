// 15. Write a program to input the unit price of an item and the quantity to be bought. Then, calculate the total price.
using System;
class TotalPrice{
  static void Main(string[] args){
    Console.WriteLine("Enter the unit price of the item:");
    double unitPrice=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the quantity to be bought:");
    double quantity=Convert.ToDouble(Console.ReadLine());
    //Formula to calculate total price
    double totalPrice=unitPrice*quantity;
    Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
  }
}