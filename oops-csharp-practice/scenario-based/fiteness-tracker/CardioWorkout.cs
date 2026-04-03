public class CardioWorkout : Workout{
  public double Speed { get; set; } 
  public CardioWorkout(int duration, UserProfile user, double speed): base(duration, user){
    Speed = speed;
  }
  //override implementation
  public override double CalculateCaloriesBurned(){
    return Duration * Speed * User.Weight * 0.0175;
  }
}
