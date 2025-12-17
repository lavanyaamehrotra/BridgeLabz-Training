package Dayone;
import java.util.*;
public class PerimeterOfRectangle {
  public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        // Length of the rectangle
        int length = sc.nextInt(); 
        // Breadth of the rectangle
        int breadth = sc.nextInt(); 
        // Calculate perimeter of the rectangle
        int perimeter = 2 * (length + breadth);

        // Print the perimeter
        System.out.println("Perimeter of Rectangle is " + perimeter);
    }
}

