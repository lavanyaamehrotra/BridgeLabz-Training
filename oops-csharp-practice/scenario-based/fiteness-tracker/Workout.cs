public abstract class Workout : ITrackable{
  protected int Duration; 
  protected UserProfile User;
  protected Workout(int duration, UserProfile user){
    Duration = duration;
    User = user;
  }
  //abstract class
  public abstract double CaloriesBurned();
  //virtual so that implementation can be modified in subclass
  public virtual void StartWorkout(){
    Console.WriteLine("Workout started");
  }
  public virtual void EndWorkout(){
    Console.WriteLine("Workout ended");
  }
}
