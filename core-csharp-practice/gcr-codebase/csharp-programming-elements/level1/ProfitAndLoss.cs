//4. Create a program to calculate the profit and loss in number and percentage based on the cost price of INR 129 and the selling price of INR 191.
using System;
class ProfitAndLoss{
  static void Main (String[] args){
    double costprice=129;
    double sellingprice=191;
    //formula to calculate profit
    double profit=sellingprice-costprice;
    //formula to calculate profit percentage
    double profitpercentage=(profit/costprice)*100;
    Console.WriteLine("The Cost Price is INR " +costprice+ " and Selling Price is INR " +sellingprice);
    Console.WriteLine("The Profit is INR " +profit+ " and the profit Percentage is " +profitpercentage);
  }
}