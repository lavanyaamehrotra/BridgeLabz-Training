// Represents a hospital unit (node in circular linked list)
public class Unit{
    public string Name;
    public bool IsAvailable;
    public Unit Next;
    //constructor
    public Unit(string name, bool isAvailable){
        Name = name;
        IsAvailable = isAvailable;
        Next = null;
    }
}
