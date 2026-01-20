using System;
public class DataScientist : JobRole{
    public string Domain { get; private set; }
    //constructor
    public DataScientist(string name, int experience, string skills, string domain): base(name, experience, skills){
        Domain = domain;
    }
    //display
    public override void Display(){
        Console.WriteLine($"[Data Scientist] {CandidateName} | Exp: {Experience} yrs | Skills: {Skills} | Domain: {Domain}");
    }
}
