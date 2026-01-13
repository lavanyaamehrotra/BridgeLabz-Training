using System;

// Utility class
public class MovieUtility : IMovieService{
    private Movie[] movies = new Movie[50];
    private int count = 0;

    // Add movie only 
    public void AddMovie(string title, string time){
        if (!IsValidTime(time)){
            Console.WriteLine("Invalid time format");
            return;
        }
        movies[count++] = new Movie(title, time);
        Console.WriteLine("Movie added successfully.");
    }
    // Linear search using String.Contains()
    public void SearchMovie(string keyword){
        bool found = false;

        for (int i = 0; i < count; i++){
            if (movies[i].Title.Contains(keyword)){
                Console.WriteLine(movies[i]);
                found = true;
            }
        }
        if (!found){
            Console.WriteLine("No movie found.");
        }
    }
    // Display all movies
    public void DisplayAllMovies(){
        for (int i = 0; i < count; i++)
            Console.WriteLine((i + 1) + ". " + movies[i]);
    }
    // time validation 
    private bool IsValidTime(string time){
        if (time.Length != 5 || time[2] != ':'){
            return false;
        }
        int hour = int.Parse(time.Substring(0, 2));
        int min = int.Parse(time.Substring(3, 2));
        return hour >= 0 && hour <= 23 && min >= 0 && min <= 59;
    }
}
