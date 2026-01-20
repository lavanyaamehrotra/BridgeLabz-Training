public abstract class JobRole{
    public string CandidateName { get; protected set; }
    public int Experience { get; protected set; }
    public string Skills { get; protected set; }
    //constructor
    protected JobRole(string name, int experience, string skills) {
        CandidateName = name;
        Experience = experience;
        Skills = skills;
    }

    public abstract void Display();
}
