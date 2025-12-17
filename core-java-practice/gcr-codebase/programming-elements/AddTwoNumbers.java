
package Dayone;
import java.util.*;
//Write a program that takes two numbers as input from user and prints their sum
public class AddTwoNumbers {
  public static void main (String [] args){
    Scanner sc=new Scanner(System.in);
    int n =sc.nextInt();
    int m=sc.nextInt();
    int sum=n+m;
    System.out.println("The sum is :" +  sum);
  }
}