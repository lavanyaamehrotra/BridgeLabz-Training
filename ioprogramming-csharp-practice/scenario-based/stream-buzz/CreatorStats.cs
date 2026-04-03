using System.Collections.Generic;
public class CreatorStats{
    //to store creator name
    public string CreatorName{get;set;}
    //array to store weekly likes
    public double[] WeeklyLikes{get;set;}
    //static list to store all creators
    public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();
    
}