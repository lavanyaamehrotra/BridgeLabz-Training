using System;
public class Program{
  public static void Main(){
    Bird[] birds = new Bird[5];
    birds[0] = new Eagle("Eagles Queen", "Eagle");
    birds[1] = new Sparrow("Sparrow King", "Sparrow");
    birds[2] = new Duck("White Duck", "Duck");
    birds[3] = new Penguin("Penguin Son", "Penguin");
    birds[4] = new Seagull("Sea Bird", "Seagull");
    for (int i = 0; i < birds.Length; i++){
      Bird b = birds[i];
      b.Display();
      if (b is IFlyable){
        IFlyable f = (IFlyable)b;
        f.Fly();
      }
      if (b is ISwimmable){
        ISwimmable s = (ISwimmable)b;
        s.Swim();
      }
      Console.WriteLine();
    }
  }
}
