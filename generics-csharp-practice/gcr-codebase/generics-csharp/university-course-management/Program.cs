using System;
class Program{
    public static void Main(string[] args){
        Console.WriteLine("=== MULTI-LEVEL UNIVERSITY COURSE MANAGEMENT SYSTEM ===\n");
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
        // -------- EXAM COURSES INPUT --------
        Console.Write("Enter number of Exam Courses: ");
        int examCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < examCount; i++){
            Console.WriteLine($"\nEnter details for Exam Course {i + 1}:");
            Console.Write("Course ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Course Name: ");
            string name = Console.ReadLine();
            Console.Write("Exam Marks: ");
            int marks = int.Parse(Console.ReadLine());
            examCourses.AddCourse(new ExamCourse(id, name, marks));
        }
        // -------- ASSIGNMENT COURSES INPUT --------
        Console.Write("\nEnter number of Assignment Courses: ");
        int assignCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < assignCount; i++){
            Console.WriteLine($"\nEnter details for Assignment Course {i + 1}:");
            Console.Write("Course ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Course Name: ");
            string name = Console.ReadLine();
            Console.Write("Assignment Score: ");
            int score = int.Parse(Console.ReadLine());
            assignmentCourses.AddCourse(new AssignmentCourse(id, name, score));
        }
        // -------- DISPLAY ALL COURSES ------
        Console.WriteLine("\n---- Exam Courses ----");
        examCourses.DisplayCourses();
        Console.WriteLine("\n---- Assignment Courses ----");
        assignmentCourses.DisplayCourses();
        // -------- SEARCH FEATURE --------
        Console.Write("\nEnter Exam Course ID to search: ");
        int searchId = int.Parse(Console.ReadLine());
        var foundCourse = examCourses.GetCourseById(searchId);
        if (foundCourse != null){
            Console.WriteLine("\nCourse Found:");
            foundCourse.Evaluate();
        }
        else{
            Console.WriteLine("\nCourse not found!");
        }
        // -------- VARIANCE DEMO --------
        Console.WriteLine("\n=== Variance Demo (Read-only View) ===");
        IReadOnlyCourse<CourseType> readOnlyView = examCourses;
        foreach (var course in readOnlyView.GetAllCourses()){
            course.Evaluate();
        }
        Console.ReadLine();
    }
}
