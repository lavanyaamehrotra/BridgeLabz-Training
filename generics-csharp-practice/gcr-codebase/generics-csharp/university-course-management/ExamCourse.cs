using System;
public class ExamCourse : CourseType{
    public int ExamMarks { get; set; }
    public ExamCourse(int id, string name, int marks): base(id, name){
        ExamMarks = marks;
    }
    //evaluate
    public override void Evaluate(){
        Console.WriteLine($"[Exam Course] ID: {CourseId}, Name: {CourseName}, Marks: {ExamMarks}");
    }
}
