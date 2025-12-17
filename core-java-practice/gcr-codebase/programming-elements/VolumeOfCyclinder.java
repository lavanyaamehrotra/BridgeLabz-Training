package Dayone;
import java.util.*;
public class VolumeOfCyclinder {
  public static void main(String [] args){
    // write a prgrm to calculate the volume of cyclinder
    Scanner sc=new Scanner(System.in);
    int n=sc.nextInt();
    //take the user input of radius and height
    int radius=sc.nextInt();
    int height=sc.nextInt();
    //calculate the volume
    int volume=n*radius*radius*radius*height;
    System.out.println("volume of the the cyclinder is:"+volume);

  }
}
