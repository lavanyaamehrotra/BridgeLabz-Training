// 9. Write a new program similar to the program # 6 but take user input for Student Fee and University Discount
using System;
class StudentFee{
  static void Main(string[] args){
    Console.WriteLine("Enter the Student Fee:");
    double fee=ConvertToDouble(Console.ReadLine());
    Console.WriteLine("Enter the University Discount Percentage:");
    double discountPercent=convertToDouble(Console.ReadLine());
    //formula to caclulate discount amount
    double discount=(discountPercent/100)*fee;
    //formula to calculate discounted fee
    double discountedfee=fee-discount;
    Console.WriteLine("The discount amount is INR " +discount+ " and final discounted fee is INR " +discountedfee);
  }
}