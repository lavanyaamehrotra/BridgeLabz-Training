using System;
public class BrickTransport : GoodsTransport{
    private float brickSize;
    private int brickQuantity;
    private float brickPrice;
    public BrickTransport(string transportId, string transportDate, int transportRating,float brickSize, int brickQuantity, float brickPrice)
        : base(transportId, transportDate, transportRating){
        this.brickSize = brickSize;
        this.brickQuantity = brickQuantity;
        this.brickPrice = brickPrice;
    }
    public int BrickQuantity{
        get { return brickQuantity; }
    }
    public float BrickPrice{
        get { return brickPrice; }
    }
    public override string VehicleSelection(){
        if (brickQuantity < 300){
            return "Truck";
        }else if (brickQuantity <= 500){
            return "Lorry";
        }else{
            return "MonsterLorry";
        }
    }
    public override float CalculateTotalCharge(){
        double price = brickPrice * brickQuantity;
        double tax = price * 0.30;
        double vehicleCost =VehicleSelection().Equals("Truck", StringComparison.OrdinalIgnoreCase) ? 1000 :VehicleSelection().Equals("Lorry", StringComparison.OrdinalIgnoreCase) ? 1700 :3000;
        double discount = 0;
        if (transportRating == 5){
            discount = price * 0.20;
        }
        else if (transportRating == 3 || transportRating == 4){
            discount = price * 0.10;
        }
        return (float)((price + tax + vehicleCost) - discount);
    }
}
