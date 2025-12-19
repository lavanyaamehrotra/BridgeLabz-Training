// 13. Write a program to find the side of the square whose perimeter you read from user
class PerimeterOfSquare{
  static void Main(string[] args){
    Console.WriteLine("Enter the perimeter of the Square:");
    double perimeter=Convert.ToDouble(Console.ReadLine());
    //Formula to calculate side of square
    double side=perimeter/4;
    Console.WriteLine("The length of the side is: " + side + " whose perimeter is " + perimeter);
  }
}