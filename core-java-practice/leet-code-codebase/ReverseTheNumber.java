import java.util.*;
public class reverse_the_no {
  public static void main(String[] args) {
    Scanner sc=new Scanner(System.in);
    int n=sc.nextInt();
    int rn=0;
    //loop for reversing the number with the logic
    for(int i=0;i<=n;i++){
      int ld=n%10;
      rn=rn*10+ld;
      n=n/10;
    }
    System.out.println(rn);
  }
}