import java.util.*;
public class prime_no {
  public static void main(String[] args) {
    Scanner sc=new Scanner(System.in);
    int n=sc.nextInt();
    int count=0;
    for(int i=1;i<=n;i++){
      if(n%i==0){
        count++;
      }
    }
    //checking if using the formula the count is 2 then only prime otherwise not 
    if(count==2){
      System.out.println("prime no");
    }else{
      System.out.println("not a prime no");
    }
  }
}