//Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade
using System;
class StudentMarksTwoDimensional{
    static void Main(string[] args){
        Console.Write("Enter the number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int[,] marks=new int[n,3];
        double[] percentage=new double[n];
        char[] grade=new char[n];
        for(int i=0;i<n;i++){
            Console.WriteLine("\nStudent" + (i+1));
            Console.Write("Physics Marks: ");
            marks[i,0]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry Marks: ");
            marks[i,1]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths Marks: ");
            marks[i,2]=Convert.ToInt32(Console.ReadLine());
            if(marks[i,0]<0 || marks[i,1]<0 || marks[i,2]<0){
                Console.WriteLine("Invalid marks! Enter positive value");
                i--;
            }
        }
        for(int i=0;i<n;i++){
            //percentage calculation
            int total=marks[i,0]+marks[i,1]+marks[i,2];
            percentage[i]=total/3.0;
            if(percentage[i]>=80){
                grade[i]='A';
            }else if(percentage[i]>=70){
                grade[i]='B';
            }else if(percentage[i]>=60){
                grade[i]='C';
            }else if(percentage[i]>=50){
                grade[i]='D';
            }else if(percentage[i]>=40){
                grade[i]='E';
            }else{
                grade[i]='R';
            }
        } 
        Console.WriteLine("\n Student Result ");
        for(int i=0;i<n;i++){
            Console.WriteLine("Physics: " + marks[i,0] + " , Chemistry: " + marks[i,1] + " , Maths: " + marks[i,2] + " , Percentage: " + percentage[i] + " , Grade: " + grade[i]);
        }
    }
}