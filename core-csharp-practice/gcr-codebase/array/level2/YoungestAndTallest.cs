//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
using System;
class YoungestAndTallest{
    static void Main(string[] args){
       string[] names={"Amar","Akbar","Anthony"};
       int[] age=new int[3];
       int[] height=new int[3];
       for(int i=0;i<3;i++){
        Console.Write("Enter the age of " + names[i] + " ");
        age[i]=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the height of " + names[i] + " ");
        height[i]=Convert.ToInt32(Console.ReadLine());
       }
       //analysing the youngest and tallest friend
       int youngest=0;
       int tallest=0;
       for(int i=1;i<3;i++){
        if(age[i]<age[youngest]){
            youngest=i;
        }
        if(height[i]<height[youngest]){
            tallest=i;
        }
       }
       Console.WriteLine("Youngest friend is: " + names[youngest]);
       Console.WriteLine("Tallest friend is: " + names[tallest]);
    }
}