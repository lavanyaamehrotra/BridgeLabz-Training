//Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
using System;
class BmiTwoDimensional{
    static void Main(string[] args){
        Console.Write("Enter the number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        double[][] data=new double[n][];
        string[] status=new string[n];
        for(int i=0;i<n;i++){
            data[i]=new double[3];
            Console.Write("Enter the Weight: ");
            data[i][0]=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Height: ");
            data[i][1]=Convert.ToDouble(Console.ReadLine());
            //bmi calculation 
            data[i][2]=data[i][0]/(data[i][1] * data[i][1]);
            //categorization 
            if(data[i][2]<=18.4){
                 status[i]="Underweight";
            }else if(data[i][2]<=24.9){
                status[i]="Normal";
            }else if(data[i][2]<=39.9){
                status[i]="Overweight";
            }else{
                status[i]="Obese";
            }
        }
        for(int i=0;i<n;i++){
            Console.WriteLine("BMI " + data[i][2] + " Status: " + status[i]);
        }
    }
}