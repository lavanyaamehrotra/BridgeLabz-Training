using Systems;
namespace programming-elements{
  class KilometeresToMiles {
    //write a prgrm that inputs the kilometers of distance and convert it to miles 
    static void Main(String[] args) {
      double km = double.Parse(Console.ReadLine());
      double miles = km * 0.621371;
      Console.WriteLine("Distance in miles :" + miles);
    }
  }
}
