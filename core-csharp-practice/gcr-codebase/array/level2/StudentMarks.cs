//Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines
using System;
class StudentMarks{
    static void Main(string[] args){
        Console.Write("Enter the number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] physics=new int[n];
        int[] chemistry=new int[n];
        int[] maths=new int[n];
        double[] percentage=new double[n];
        char[] grade=new char[n];
        for(int i=0;i<n;i++){
            Console.Write("Physics Marks: ");
            physics[i]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry Marks: ");
            chemistry[i]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths Marks: ");
            maths[i]=Convert.ToInt32(Console.ReadLine());
            if(physics[i]<0 || chemistry[i]<0 || maths[i]<0){
                Console.WriteLine("Invalid marks! Enter positive value.");
                i--;
            }
        }
        //calculing marks percentage and grade
        for(int i=0;i<n;i++){
            percentage[i]=(physics[i] + chemistry[i] + maths[i])/ 3.0;
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
        Console.WriteLine("Student Result");
        for(int i=0;i<n;i++){
            Console.WriteLine("Physics: " + physics[i] + " ,Chemistry: " + chemistry[i] + " ,Maths: " + maths[i] + " ,Percentage: " + percentage[i] + " ,Grade: " + grade[i]);
        }
    }
}