// Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop. Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 
using System;
class LargestAndSecondLargestDynamic{
    static void Main(string[] args){
    Console.Write("Enter the number: ");
    int number=Convert.ToInt32(Console.ReadLine());
    int maxDigit=10;
    int[] digit=new int[maxDigit];
    int idx=0;
    while(number!=0){
        if(idx==maxDigit){
            maxDigit+=10;
            int[] temp=new int[maxDigit];
            for(int i=0;i<digit.Length;i++){
                temp[i]=digit[i];
            }
            digit=temp;
        }
        digit[idx]=number%10;
        idx++;
        number=number/10;
    }
    //finding the largest and second largest
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
    Console.WriteLine("Largest:" + largest);
    Console.WriteLine("Second Largest :" + secondLargest);
    }
}