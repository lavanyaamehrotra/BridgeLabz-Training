//Calculate  the angle between the minute hands of two time zones
using System;
class TimeZone{
	public static double calculateAngle(int hour1, int hour2,int minute1,int minute2){
	
	double a1=(minute1/60.0)*360.0;
	double a2=(minute2/60.0)*360.0;
	double diff=Math.Abs(a1-a2);
	return Math.Min(diff,360-diff);
	}
	
	public static void Main(String[] args)
	{
		Console.WriteLine("hour1,minute1,hour2,minute2");
		int hour1=Convert.ToInt32(Console.ReadLine());
	    int minute1=Convert.ToInt32(Console.ReadLine());
	    int hour2=Convert.ToInt32(Console.ReadLine());
	    int minute2=Convert.ToInt32(Console.ReadLine());
	    double a=calculateAngle(hour1,hour2,minute1,minute2);	
	    Console.WriteLine(a);
	}
}