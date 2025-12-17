package Dayone;

import java.util.Scanner;

public class CelsiusToFahrenheitConversion {
  public static void main(String [] args){
    //Write a program that takes temprature in Celsius as input and converts it to fahrenheit using the formula Fahrenheit =(Celsius*9/5)+32
    Scanner sc=new Scanner (System.in);
    double Celsius=sc.nextDouble();
    double Fahrenheit =(Celsius*9/5)+32;
    System.out.println(" Fahrenheit: "+  Fahrenheit);
  }
}
