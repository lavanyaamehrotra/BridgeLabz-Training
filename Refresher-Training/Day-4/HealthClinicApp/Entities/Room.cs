namespace HealthClinicApp.Entities;
public class Room{
    public int RoomID { get; set; }
    public string RoomNumber { get; set; }
    public int FloorNumber { get; set; }
    public string RoomType { get; set; }
    public Room(int roomID,string roomNumber,int floorNumber,string roomType){
        RoomID = roomID;
        RoomNumber = roomNumber;
        FloorNumber = floorNumber;
        RoomType = roomType;
    }
}