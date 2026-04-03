public class StrengthWorkout : Workout{
  public int Sets { get; set; }
  public StrengthWorkout(int duration, UserProfile user, int sets): base(duration, user){
    Sets = sets;
  }
  //override implementation
  public override double CaloriesBurned(){
    return Duration * Sets * User.Weight * 0.015;
  }
}
