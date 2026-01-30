using System.Collections.Generic;
public class VesselUtil{
    // List to store vessel objects
    private List<Vessel> vesselList = new List<Vessel>();

    // Method to add vessel details to the list
    public void AddVesselPerformance(Vessel vessel){
        vesselList.Add(vessel);
    }
    // Method to search vessel by vesselId (case-sensitive)
    public Vessel GetVesselById(string vesselId){
        // Using for loop instead of foreach
        for (int i = 0; i < vesselList.Count; i++){
            if (vesselList[i].VesselId == vesselId){
                return vesselList[i];
            }
        }
        return null;
    }
    // Method to get vessels with highest average speed
    public List<Vessel> GetHighPerformanceVessels(){
        List<Vessel> result = new List<Vessel>();
        double maxSpeed = 0;
        // Find maximum average speed
        for (int i = 0; i < vesselList.Count; i++){
            if (vesselList[i].AverageSpeed > maxSpeed){
                maxSpeed = vesselList[i].AverageSpeed;
            }
        }
        // Collect vessels having maximum speed
        for (int i = 0; i < vesselList.Count; i++){
            if (vesselList[i].AverageSpeed == maxSpeed){
                result.Add(vesselList[i]);
            }
        }
        return result;
    }
}
