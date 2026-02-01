using System;
public abstract class GoodsTransport{
    protected string transportId;
    protected string transportDate;
    protected int transportRating;
    // constructor
    public GoodsTransport(string transportId, string transportDate, int transportRating){
        this.transportId = transportId;
        this.transportDate = transportDate;
        this.transportRating = transportRating;
    }
    // public getters
    public string GetTransportId(){
        return transportId;
    }
    public string GetTransportDate(){
        return transportDate;
    }
    public int GetTransportRating(){
        return transportRating;
    }
    // abstract methods
    public abstract string VehicleSelection();
    public abstract float CalculateTotalCharge();
}
