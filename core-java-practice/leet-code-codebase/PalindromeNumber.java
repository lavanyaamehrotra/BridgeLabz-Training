import java.util.*;
public class palindrome_no {
  public static void main(String[] args) {
    Scanner sc=new Scanner(System.in);
    int n=sc.nextInt();
    int rv=0;
    int duplicate=n;
    while (n>0) {
      int ld=n%10;
      rv=rv*10+ld;
      n=n/10;
    }
    //matching if the original and the reverse ones are same or not 
    if(rv==duplicate){
      System.out.println("YES");
    }else{
      System.out.println("NO");
    }
  }
}