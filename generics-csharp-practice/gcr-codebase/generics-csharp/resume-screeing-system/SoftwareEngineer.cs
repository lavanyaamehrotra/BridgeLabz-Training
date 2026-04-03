using System;
public class SoftwareEngineer : JobRole{
    public string ProgrammingLanguage { get; private set; }
    //constructor
    public SoftwareEngineer(string name, int experience, string skills, string language): base(name, experience, skills){
        ProgrammingLanguage = language;
    }
    //display
    public override void Display(){
        Console.WriteLine($"[Software Engineer] {CandidateName} | Exp: {Experience} yrs | Skills: {Skills} | Lang: {ProgrammingLanguage}");
    }
}
