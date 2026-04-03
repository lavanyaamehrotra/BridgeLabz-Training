using System.Collections.Generic;
using System.Linq;
public class Resume<T> where T : JobRole{
    private List<T> resumes = new List<T>();
    //add resume
    public void AddResume(T resume){
        resumes.Add(resume);
    }
    //display
    public void DisplayAll(){
        foreach (var r in resumes)
            r.Display();
    }
    // DSA: Filtering
    public List<T> FilterByExperience(int minExperience){
        return resumes.Where(r => r.Experience >= minExperience).ToList();
    }
    //search by name
    public T SearchByName(string name){
        return resumes.FirstOrDefault(r =>
            r.CandidateName.Equals(name, System.StringComparison.OrdinalIgnoreCase));
    }
    public List<T> GetAll(){
        return resumes;
    }
}
