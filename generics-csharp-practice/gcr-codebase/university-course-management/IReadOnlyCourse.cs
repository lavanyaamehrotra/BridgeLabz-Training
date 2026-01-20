using System.Collections.Generic;
public interface IReadOnlyCourse<out T>{
    IEnumerable<T> GetAllCourses();
}
