// Interface for movie operations
public interface IMovieService{
    void AddMovie(string title, string time);
    void SearchMovie(string keyword);
    void DisplayAllMovies();
}
