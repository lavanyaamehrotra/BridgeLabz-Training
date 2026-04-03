using System;
using System.Collections.Generic;
public class Course<T> : IReadOnlyCourse<T> where T : CourseType{
    private List<T> courses = new List<T>();
    //add course
    public void AddCourse(T course){
        courses.Add(course);
    }
    //display courses
    public void DisplayCourses(){
        foreach (var course in courses)
            course.Evaluate();
    }
    // DSA - Search by Course ID
    public T GetCourseById(int id){
        return courses.Find(c => c.CourseId == id);
    }
    // For variance demo
    public IEnumerable<T> GetAllCourses(){
        return courses;
    }
}
