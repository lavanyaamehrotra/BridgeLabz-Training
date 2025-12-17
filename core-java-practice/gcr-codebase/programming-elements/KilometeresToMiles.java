package Dayone;

import java.util.Scanner;

public class KilometeresToMiles {
  //write a prgrm that inputs the kilometers of distance and convert it to miles 
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
        double km = sc.nextDouble();
        double miles = km * 0.621371;
        System.out.println("Distance in miles :" + miles);
  }
}
