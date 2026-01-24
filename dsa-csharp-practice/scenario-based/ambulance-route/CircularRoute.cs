using System;
// class manages all Circular Linked List operations
public class CircularRoute{
    private Unit head;
    // adds a new hospital unit to the circular route
    public void AddUnit(string name, bool isAvailable){
        // Create a new unit 
        Unit newUnit = new Unit(name, isAvailable);
        // If no unit exists, make this the first unit
        if(head == null){
            head = newUnit;
            head.Next = head;
            return;
        }
        // Traverse to the last unit in the circular list
        Unit current = head;
        while(current.Next != head){
            current = current.Next;
        }
        current.Next = newUnit;
        newUnit.Next = head;
    }
    //finds the nearest available unit
    public void RoutePatient(){
        if(head == null){
            Console.WriteLine("No hospital units available.");
            return;
        }
        Unit current = head;
        bool unitFound = false;
        do{
            Console.WriteLine("Checking unit: " + current.Name);
            if(current.IsAvailable){
                Console.WriteLine("Patient redirected to: " + current.Name);
                unitFound = true;
                break;
            }
            current = current.Next;
        }while(current != head);
        if(!unitFound){
            Console.WriteLine("All units are currently busy.");
        }
    }
    // removes a hospital unit under maintenance
    public void RemoveUnit(string name){
        if(head == null){
            Console.WriteLine("No units to remove.");
            return;
        }
        Unit current = head;
        Unit previous = null;
        do{
            if(current.Name == name){
                // Unit to remove is the head
                if(current == head){
                    Unit temp = head;
                    // Find the last unit
                    while(temp.Next != head){
                        temp = temp.Next;
                    }
                    // Move head to next unit
                    head = head.Next;
                    temp.Next = head;
                }
                else{
                    previous.Next = current.Next;
                }
                Console.WriteLine(name + " removed for maintenance.");
                return;
            }
            previous = current;
            current = current.Next;
        }while(current != head);
        Console.WriteLine("Unit not found.");
    }

    // Displays all hospital units and their availability
    public void DisplayUnits(){
        if(head == null){
            Console.WriteLine("No hospital units added yet.");
            return;
        }
        Unit current = head;
        Console.WriteLine("\nHospital Units List:");
        do{
            Console.WriteLine("Unit Name: " + current.Name +" | Available: " + (current.IsAvailable ? "Yes" : "No"));
            current = current.Next;
        }while(current != head);
    }
}
