import java.util.*;
public class two_sum {
  public static void main(String[] args) {
    Scanner sc=new Scanner(System.in);
    int n=sc.nextInt();
    int arr[]=new int [n];
    for(int i=0;i<n;i++){
      arr[i]=sc.nextInt();
    }
    int target=sc.nextInt();
    int sum=0;
    for(int i=0;i<n;i++){
     for(int j=i+1;j<n;j++){
      //if(i==j) continue;
      if(arr[i]+arr[j]==target){
        System.out.println("yes");
      }
     }
    }
    System.out.println("NO");
  }
}