package Dayone;

import java.util.Scanner;

public class CalculateSimpleInterest {
  public static void main(String [] args){
    // write a prgm to calculate the simple interest 
        Scanner sc = new Scanner(System.in);
        double p = sc.nextDouble();
        double r = sc.nextDouble();        
        double t = sc.nextDouble();        
        // Calculate simple interest
        double simpleInterest = (p * r * t) / 100;
        // Print the simple interest
        System.out.println("Simple Interest is " + simpleInterest);
    }
}

