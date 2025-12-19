// The University is charging the student a fee of INR 125000 for the course. The University is willing to offer a discount of 10%. Write a program to find the discounted amount and discounted price the student will pay for the course.
using System;
class DiscountedAmountAndDiscountedFee{
  static void Main(string[] args){
    double fee=125000;
    double discountPercent=10;
    //formula to calculate discount amount
    double discount=(discountPercent/100)*fee;
    //formula to calculate discounted fee
    double discountedfee=fee-discount;
    Console.WriteLine("The discount amount is INR " +discount+ " and final dicounted fee is INR " +discountedfee);
  }
}