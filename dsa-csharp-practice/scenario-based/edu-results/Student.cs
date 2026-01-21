using System;
public class Student{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public Student(int rollNo, string name, int marks){
        RollNo = rollNo;
        Name = name;
        Marks = marks;
    }
}
