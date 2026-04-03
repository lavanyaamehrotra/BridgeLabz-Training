//represents single vehicle in the roundabout
class VehicleNode{
    public string VehicleNumber;
    public VehicleNode Next;
    //constructor
    public VehicleNode(string vehicleNumber){
        VehicleNumber=vehicleNumber;
        Next=null;
    }
}