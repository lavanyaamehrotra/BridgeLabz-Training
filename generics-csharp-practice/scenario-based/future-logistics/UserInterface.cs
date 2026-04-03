using System;
class UserInterface{
    static void Main(){
        Utility utility = new Utility();
        Console.WriteLine("Enter the Goods Transport details");
        string input = Console.ReadLine();
        GoodsTransport transport = utility.ParseDetails(input);
        if (transport == null){
            return;
        }
        Console.WriteLine($"Transporter id : {transport.GetTransportId()}");
        Console.WriteLine($"Date of transport : {transport.GetTransportDate()}");
        Console.WriteLine($"Rating of the transport : {transport.GetTransportRating()}");
        if (transport is BrickTransport bt){
            Console.WriteLine($"Quantity of bricks : {bt.BrickQuantity}");
            Console.WriteLine($"Brick price : {bt.BrickPrice}");
        }
        else if (transport is TimberTransport tt){
            Console.WriteLine($"Type of the timber : {tt.TimberType}");
            Console.WriteLine($"Timber price per kilo : {tt.TimberPrice}");
        }
        Console.WriteLine($"Vehicle for transport : {transport.VehicleSelection()}");
        Console.WriteLine($"Total charge : {transport.CalculateTotalCharge()}");
    }
}
