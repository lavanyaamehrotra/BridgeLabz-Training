using System;
public class AssignmentCourse : CourseType{
    public int AssignmentScore { get; set; }
    public AssignmentCourse(int id, string name, int score): base(id, name){
        AssignmentScore = score;
    }
    //evaluate
    public override void Evaluate(){
        Console.WriteLine($"[Assignment Course] ID: {CourseId}, Name: {CourseName}, Score: {AssignmentScore}");
    }
}
