package Dayone;
import java.util.*;
public class AverageOfTwoNumbers {
  public static void main(String[] args) {
    Scanner sc =new Scanner (System.in);
    // take the 1st input
    int a=sc.nextInt();
    //take the 2nd input
    int b=sc.nextInt();
    //take the 3rd input
    int c=sc.nextInt();
    int average=(a+b+c)/2;
    System.out.println("The average is :" + average);
  }
}
