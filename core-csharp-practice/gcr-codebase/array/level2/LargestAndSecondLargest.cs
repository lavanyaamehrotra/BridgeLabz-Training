//Create a program to store the digits of the number in an array and find the largest and second largest element of the array.
using System;
class LargestAndSecondLargest{
    static void Main(string[] args){
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());
        int maxDigit=10;
        int[] digit=new int[maxDigit];
        int idx=0;
        while(number!=0 && idx<maxDigit){
            digit[idx]=number%10;
            idx++;
            number=number/10;
        }//looking for largest and second largest digit
        int largest=0;
        int secondLargest=0;
        for(int i=0;i<idx;i++){
            if(digit[i]>largest){
                secondLargest=largest;
                largest=digit[i];
            }else if(digit[i]>secondLargest && digit[i]!=largest){
                secondLargest=digit[i];
            }
        }
        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + secondLargest);
    }
}