using System;
//Circular Linked List operations
class RoundAbout{
    //keeps track of last vehicle
    private VehicleNode last;
    public RoundAbout(){
        last =null;
    }
    //Add vehicle to the roundabout
    public void AddVehicle(string vehicleNumber){
        if (vehicleNumber == null){
            return;
        }
        VehicleNode newNode=new VehicleNode(vehicleNumber);
        //if roundabot is empty
        if (last == null){
            last=newNode;
            last.Next=last;
        }else{
         newNode.Next=last.Next;
         last.Next=newNode;
         last=newNode;   
        }
        Console.WriteLine($"Vehicle {vehicleNumber} entered");
    }
    //remove vehicle from the roundabout
    public void RemoveVehicle(){
        if (last == null){
            Console.WriteLine("Roundabout is empty");
            return;
        }
        //only one vehicle exists
        if (last.Next == last){
            Console.WriteLine($"vehicle {last.vehicleNumber} exited the roundabout");
            last =null;
        }else{
         VehicleNode firstVehicle=last.Next;
         Console.WriteLine($"Vehicle {firstVehicle.vehicleNumber} exited the roundabout");
         last.Next=firstVehicle.Next;   
        }
    }
    //Display current vehicle in the roundabout
    public void Display(){
        if (last == null){
            Console.WriteLine("Roundabout is empty");
            return;
        }
        Console.WriteLine("Rounabout state");
        vehicleNode temp=last.Next;
        do{
            Console.WriteLine(temp.VehicleNumber+"=>");
            temp=temp.Next;
        }while(temp!=last.Next);
        Console.WriteLine("back to start");
    }
}