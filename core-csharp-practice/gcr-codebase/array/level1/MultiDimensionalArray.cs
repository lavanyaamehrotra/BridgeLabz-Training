// Working with Multi-Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a single dimension array
using System;
class MultiDimensionalArray{
  static void Main(string[] args){
    Console.WriteLine("Enter number of row:");
    int row=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number of column:");
    int column=Convert.ToInt32(Console.ReadLine());
    int[,] matrix=new int[row,column];
    Console.WriteLine("Enter the elements of the matrix:");
    //Input elements of the matrix
    for(int i=0;i<row;i++){
      for(int j=0;j<column;j++){
        Console.Write("Element [" + i + "," + j + "]: ");
        matrix[i,j]=Convert.ToInt32(Console.ReadLine());
      }
    }
    int[] array=new int[row*column];
    int index=0;
    //copying elements of 2d array to 1d array
    for(int i=0;i<row;i++){
      for(int j=0;j<column;j++){
        array[index]=matrix[i,j];
        index++;
      }
    }
    Console.WriteLine("The elements of the 1D array are:");
    for(int i=0;i<array.Length;i++){
      Console.WriteLine(array[i]);
    }
  }
}