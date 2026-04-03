using System;

class Course{
  public string CourseName;
  public string Duration;
  public Course(string courseName, string duration){
    CourseName = courseName;
    Duration = duration;
  }
  public virtual void DisplayCourseInfo(){
    Console.WriteLine("Course Name: " + CourseName);
    Console.WriteLine("Duration: " + Duration);
  }
}
class OnlineCourse : Course{
  public string Platform;
  public bool IsRecorded;
  public OnlineCourse(string courseName, string duration,string platform, bool isRecorded): base(courseName, duration){
    Platform = platform;
    IsRecorded = isRecorded;
  }
  public override void DisplayCourseInfo(){
    base.DisplayCourseInfo();
    Console.WriteLine("Platform: " + Platform);
    Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
  }
}

class PaidOnlineCourse : OnlineCourse{
  public double Fee;
  public double Discount;
  public PaidOnlineCourse(string courseName, string duration,string platform, bool isRecorded,double fee, double discount): base(courseName, duration, platform, isRecorded){
    Fee = fee;
    Discount = discount;
  }
  public override void DisplayCourseInfo(){
    base.DisplayCourseInfo();
    Console.WriteLine("Course Fee: " + Fee);
    Console.WriteLine("Discount: " + Discount + "%");
    Console.WriteLine("Final Price: " + (Fee - (Fee * Discount / 100)));
  }
}
class Program{
  static void Main(){
    PaidOnlineCourse poc = new PaidOnlineCourse("Data Structures","8 Weeks","Udemy",true,5000,20);
    Console.WriteLine("COURSE DETAILS");
    poc.DisplayCourseInfo();
    Console.ReadLine();
  }
}
