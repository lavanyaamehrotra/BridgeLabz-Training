// Encapsulated Movie class
public class Movie{
    public string Title { get; private set; }
    public string Time { get; private set; }
    //constructor
    public Movie(string title, string time){
        Title = title;
        Time = time;
    }
    public override string ToString(){
        return "Movie: " + Title + " | Time: " + Time;
    }
}
