using Systems;
namespace programming-elements{
  class PerimeterOfRectangle{
    static void Main(String[] args) {
        // Length of the rectangle
        int length = int.Parse(Console.ReadLine());
        // Breadth of the rectangle
        int breadth = int.Parse(Console.ReadLine());
        // Calculate perimeter of the rectangle
        int perimeter = 2 * (length + breadth);

        // Print the perimeter
        Console.WriteLine("Perimeter of Rectangle is " + perimeter);
    }
  }
}

