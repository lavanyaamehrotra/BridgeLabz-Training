package Dayone;
import java.util.*;
public class PowerCalculation {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    // take the base input
    double base = sc.nextDouble();
    // take the exponent input
    double exponent = sc.nextDouble();
    // calculate the result 
    double result = Math.pow(base, exponent);
    //print the result 
    System.out.println("Result = " + result);
  }
}

