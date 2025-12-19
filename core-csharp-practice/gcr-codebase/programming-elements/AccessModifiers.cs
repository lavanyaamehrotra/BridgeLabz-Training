//perform the access modifier operations
using System;
class AcessModifier{
  //public - accesible everywhere
  public int num1=20;
  //private - accessible only inside the class
  private int num2=40;
  //protected - accessible in this class and subclass
  protected int num3=60;
  //internal - accessible in this project 
  internal int num4 = 80;
  private void ShowPrivate(){
    Console.WriteLine("The private number is: " + num2);
  }
  public void display(){
    Console.WriteLine("The protected number is: " + num3);
    Console.WriteLine("The Public variable is: " + num1);
    Console.WriteLine("The internal variable is: " + num4);
    ShowPrivate();
  }
  static void Main(string[] args){
    AccessModifier am=new AccessModifier();
    am.display();
  }
}